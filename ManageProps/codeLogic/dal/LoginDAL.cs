using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for login
/// </summary>
public  class LoginDAL : dalBase
{
    
    public LoginDAL() : base()
    {
        
        
    }

    public iaSession LogInUser(string username, string password)
    {
        SqlCommand sqlcmd = new SqlCommand("select * from users where username = @user and password = @pass");
        sqlcmd.Parameters.Add("@user", SqlDbType.VarChar, 30).Value = username;
        sqlcmd.Parameters.Add("@pass", SqlDbType.VarChar, 30).Value = password;

        DataTable user = GetDataTable(sqlcmd);
        if (user.Rows.Count > 0)
        {
            //user exists
            UserBL validatedPerson = new UserBL(user);
            return new iaSession(validatedPerson);
        }
        else
        {
            //user does not exist
            return null;
        }
    }

    public iaSession CreateUser(string email, string userName, string pass, string firstName, string lastName)
    {
        SqlCommand sqlcmd = new SqlCommand("if not exists ( select * from users where email = @email or userName = @user) begin " +
                                                "insert into users (Email, UserName, Password, UserType, FirstName, LastName) output inserted.* values (@email, @user, @pass, 'O', @first, @last)" +
                                                " end;");
        sqlcmd.Parameters.Add("@user", SqlDbType.VarChar, 30).Value = userName;
        sqlcmd.Parameters.Add("@pass", SqlDbType.VarChar, 30).Value = pass;
        sqlcmd.Parameters.Add("@email", SqlDbType.VarChar, 70).Value = email;
        sqlcmd.Parameters.Add("@first", SqlDbType.VarChar, 50).Value = firstName;
        sqlcmd.Parameters.Add("@last", SqlDbType.VarChar, 50).Value = lastName;

        DataTable user = GetDataTable(sqlcmd);
        if (user.Rows.Count > 0)
        {
            //user exists
            UserBL validatedPerson = new UserBL(user);
            return new iaSession(validatedPerson);
        }
        else
        {
            //user does not exist
            return null;
        }
    }

    public int ResetPassword(string email, Guid guid)
    {
        SqlCommand sqlCmd = new SqlCommand("with recover as (select UserID, @id as id, dateadd(hh, 2, getdate()) as Expiry from Users where email = @email) " +
                                                    "insert into userpasswordreset select * from recover");

        sqlCmd.Parameters.Add("@email", SqlDbType.VarChar, 70).Value = email;
        sqlCmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = guid;

        return ExecuteNonQuery(sqlCmd);
    }

    public DataTable GetPasswordResetInfo(Guid key)
    {
        SqlCommand sqlCmd = new SqlCommand("select * from userpasswordreset where ResetKey = @reset");
        sqlCmd.Parameters.Add("@reset", SqlDbType.UniqueIdentifier).Value = key;
        return GetDataTable(sqlCmd);
    }

    public void SetPassword(string pass, int id)
    {
        SqlCommand sqlCmd = new SqlCommand("update users set password = @pass where userid = @id");
        sqlCmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = pass;
        sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        ExecuteNonQuery(sqlCmd);
    }
}