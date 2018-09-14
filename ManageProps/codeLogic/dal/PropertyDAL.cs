using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for property
/// </summary>
public class PropertyDAL : dalBase
{
    public PropertyDAL() : base()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataTable GetProperty(int PropertyID)
    {
        SqlCommand cmd = new SqlCommand("Select * from Property where PropertyID = @PropertyID");
        cmd.Parameters.Add("@PropertyID", SqlDbType.Int).Value = PropertyID;
        return GetDataTable(cmd);
    }

    public DataTable GetProperties(int CompanyID)
    {
        SqlCommand cmd = new SqlCommand("Select * from Property where CompanyID = @CompanyID");
        cmd.Parameters.Add("@CompanyID", SqlDbType.Int).Value = CompanyID;
        return GetDataTable(cmd);
    }

    public void AddNewProperty(PropertyModel propInfo)
    {
        SqlCommand cmd = new SqlCommand("insert into property values (@PropertyName,  @Add1, @Add2, @Phone, @Zip, @ContactPerson,  @Email, @CompanyID) ;");
        cmd.Parameters.Add("@PropertyName", SqlDbType.VarChar, 100).Value = propInfo.PropertyName;
        cmd.Parameters.Add("@ContactPerson", SqlDbType.VarChar, 100).Value = propInfo.ContactPerson;
        cmd.Parameters.Add("@Add1", SqlDbType.VarChar, 100).Value = propInfo.Address1;
        cmd.Parameters.Add("@Add2", SqlDbType.VarChar, 100).Value = propInfo.Address2;
        cmd.Parameters.Add("@Zip", SqlDbType.VarChar, 10).Value = propInfo.Zip;
        cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 15).Value = propInfo.Phone;
        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 70).Value = propInfo.Email;
        cmd.Parameters.Add("@CompanyID", SqlDbType.Int).Value = propInfo.CompanyID;

        ExecuteNonQuery(cmd);
    }
}