using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ManageProps.codeLogic.dal
{
    public class WorkOrderDAL : dalBase
    {

        public WorkOrderDAL()
        { }

        public void CreateWorkOrder(WorkOrderModel workModel)
        {
            System.Text.StringBuilder cmdCols = new System.Text.StringBuilder("insert into workorders (ApprovedBy, ApproveDate, MaintenceRequestID, CurrentStatus, Notes ");
            System.Text.StringBuilder cmdVals = new System.Text.StringBuilder("values ( @Approvedby, @ApprovedDate, @MainRequestID, @CurrentStatus, @Notes ");

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@Approvedby", SqlDbType.Int).Value = workModel.ApprovedBy;
            cmd.Parameters.Add("@ApprovedDate", SqlDbType.DateTime).Value = workModel.ApprovedDate;
            cmd.Parameters.Add("@MainRequestID", SqlDbType.Int).Value = workModel.MaintenceRequestID;
            cmd.Parameters.Add("@CurrentStatus", SqlDbType.VarChar, 20).Value = workModel.CurrentStatus;
            cmd.Parameters.Add("@Notes", SqlDbType.VarChar, 6000).Value = workModel.Notes;
            if (workModel.PromiseDate != null)
            {
                cmd.Parameters.Add("@Promise", SqlDbType.DateTime).Value = workModel.PromiseDate;
                cmdCols.Append(" , PromiseDate");
                cmdVals.Append(" , @Promise");
            }

            cmdCols.Append(")");
            cmdVals.Append(")");

            cmd.CommandText = cmdCols.Append(cmdVals.ToString()).ToString();

            ExecuteNonQuery(cmd);

        }

        public DataTable GetWorkOrder(int WorkOrderID)
        {
            SqlCommand cmd = new SqlCommand("select * from workorders where WorkOrderID = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = WorkOrderID;

            return GetDataTable(cmd);
        }

        public void UpdateWorkOrder(WorkOrderModel order)
        {
            SqlCommand cmd = new SqlCommand("update workorders set CurrentStatus = @curr, Notes = @notes, PromiseDate = @prom where WorkOrderID = @id");
            cmd.Parameters.Add("@curr", SqlDbType.VarChar, 20).Value = order.CurrentStatus;
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 6000).Value = order.Notes;
            cmd.Parameters.Add("@prom", SqlDbType.DateTime).Value = order.PromiseDate;
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 6000).Value = order.WorkOrderID;

            ExecuteNonQuery(cmd);
        }
    }

   
}