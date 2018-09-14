using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for UserDAL
/// </summary>
public class UserDAL : dalBase
{
    public UserDAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataTable GetUser(int UserID)
    {
        SqlCommand cmd = new SqlCommand("select * from users where userid = @userid");
        cmd.Parameters.Add("@userid", SqlDbType.Int).Value = UserID;
        return GetDataTable(cmd);
    }
}