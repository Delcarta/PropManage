using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManageProps.codeLogic.dal
{
    public class ResidentDAL : dalBase
    {
        public ResidentDAL()
        { }

        public string GetResidentCustomFieldValues(int ResidentID)
        {
            SqlCommand sqlCmd = new SqlCommand("select FieldValues from ResidentCustomFieldValues where residentID = @id");
            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = ResidentID;
            return (string)ExecuteScalar(sqlCmd);
            
        }

        public void SaveResidentCustomFieldValues(string values, int ResidentID)
        {
            SqlCommand sqlCmd = new SqlCommand("if not exists(select residentID from ResidentCustomFieldValues where residentID = @id) " +
                                                "begin insert into ResidentCustomFieldValues values (@id, @values) end else " +
                                                "begin update ResidentCustomFieldValues set fieldValues = @values where residentID = @id end;");
            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = ResidentID;
            sqlCmd.Parameters.Add("@values", SqlDbType.VarChar, 2000).Value = values;
            ExecuteNonQuery(sqlCmd);
        }

        public DataTable GetResidents(int PropertyID)
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from Residents where PropertyID = @PropertyID");
            sqlCmd.Parameters.Add("@PropertyID", SqlDbType.Int).Value = PropertyID;
            return GetDataTable(sqlCmd);
        }
    }
}