using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for company
/// </summary>
public class CompanyDAL : dalBase
{
    public CompanyDAL() : base()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataTable GetCompany(int CompanyID)
    {
        SqlCommand cmd = new SqlCommand("Select * from Company where CompanyID = @Company");
        cmd.Parameters.Add("@Company", SqlDbType.Int).Value = CompanyID;
        return GetDataTable(cmd);
    }

    public void AddNewCompany(CompanyModel theComp)
    {
        SqlCommand cmd = new SqlCommand("insert into company values (@CompanyName, @DBAName, @Add1, @Add2, @Zip, @Phone, @Email, @User) ;update users set isowner = 1,  companyid = (SELECT CAST(scope_identity() AS int)) where userid = @User;");
        cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar, 100).Value = theComp.CompanyName;
        cmd.Parameters.Add("@DBAName", SqlDbType.VarChar, 100).Value = theComp.DBAName;
        cmd.Parameters.Add("@Add1", SqlDbType.VarChar, 100).Value = theComp.Address1;
        cmd.Parameters.Add("@Add2", SqlDbType.VarChar, 100).Value = theComp.Address2 ;
        cmd.Parameters.Add("@Zip", SqlDbType.VarChar, 10).Value = theComp.Zip;
        cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 15).Value = theComp.Phone;
        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 70).Value = theComp.Email;
        cmd.Parameters.Add("@User", SqlDbType.Int).Value = theComp.UserID;

        ExecuteNonQuery(cmd);
    }
} 