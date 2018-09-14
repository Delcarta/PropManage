using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManageProps.codeLogic.dal
{
    public class SettingsDAL : dalBase
    {
        public SettingsDAL()
        { }

        public void SaveCustomFields(string fields, int propertyID, int companyID, bool isCompanyWide = false)
        {
            SqlCommand sqlCmd = new SqlCommand("if not exists(select propertyID from CustomFields where propertyID = @propID and companyID = @compID) " +
                                                    "begin insert into customfields values (@fields, @companyWide, @propID, @compID) end else " +
                                                    "begin update customfields set fields = @fields where propertyID = @propID and companyID = @compID end");

            sqlCmd.Parameters.Add("@propID", SqlDbType.Int).Value = propertyID;
            sqlCmd.Parameters.Add("@compID", SqlDbType.Int).Value = companyID;
            sqlCmd.Parameters.Add("@fields", SqlDbType.VarChar, fields.Length).Value = fields;
            sqlCmd.Parameters.Add("@companyWide", SqlDbType.Bit).Value = isCompanyWide;

            ExecuteNonQuery(sqlCmd);
        }

        public string GetCustomFields(int propID)
        {
            SqlCommand sqlCmd = new SqlCommand("select fields from customfields where propertyID = @propID");
            sqlCmd.Parameters.Add("@propID", SqlDbType.Int).Value = propID;
            var fields = ExecuteScalar(sqlCmd);
            if (fields != null)
                return (string)fields;
            else
                return null;
        }
    }
}