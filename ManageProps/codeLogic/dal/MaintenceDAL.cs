using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManageProps.codeLogic.dal
{
    public class MaintenceDAL : dalBase
    {
        public MaintenceDAL()
        { }

        public void addMaintenceRequest(MaintenceRequestModel requestInfo)
        {
            SqlCommand cmd = new SqlCommand("Insert into MaintenceRequests values (@RequestDate, @RequestDetails, @user, @unit, isnull((select ResidentID from Residents where unitid = @unit and MoveOutDate is null), 0) ,@propID);");
            cmd.Parameters.Add("@RequestDate", SqlDbType.DateTime ).Value = requestInfo.RequestDate;
            cmd.Parameters.Add("@RequestDetails", SqlDbType.VarChar, 6000).Value = requestInfo.RequestDetails;
            cmd.Parameters.Add("@user", SqlDbType.Int).Value = requestInfo.UserID;
            cmd.Parameters.Add("@unit", SqlDbType.Int).Value = requestInfo.UnitID;
            cmd.Parameters.Add("@propID", SqlDbType.Int).Value = requestInfo.PropertyID;

            ExecuteNonQuery(cmd);
        }

        public DataTable GetMaintenceRequest(int requestID)
        {
            SqlCommand cmd = new SqlCommand("select * from maintenceRequests where requestid = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = requestID;

            return GetDataTable(cmd);
        }

        public void CloseRequest(int requestID)
        {
            SqlCommand cmd = new SqlCommand("Update maintenceRequests set IsClosed = 1 where requestID = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = requestID;

            ExecuteNonQuery(cmd);
        }
    }
}