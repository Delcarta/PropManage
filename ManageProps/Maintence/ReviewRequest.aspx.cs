using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ManageProps.codeLogic.BL;

namespace ManageProps.Maintence
{
    public partial class ReviewRequest : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string requestID = Request.QueryString["requestID"];
                if (int.TryParse(requestID, out int reqID))
                {
                    GetRequest(reqID);
                }
            }
        }

        protected void btnCreateOrder_Click(object sender, EventArgs e)
        {
            WorkOrderModel workOrder = new WorkOrderModel();
            workOrder.Notes = txtNotes.Value;
            workOrder.ApprovedBy = Sess.Person.UserID;
            workOrder.ApprovedDate = DateTime.Now;
            workOrder.MaintenceRequestID = int.Parse(Request.QueryString["requestID"]);
            workOrder.CurrentStatus = "Not Started";
            if (DateTime.TryParse(txtPromise.Value, out DateTime promise))
            {
                workOrder.PromiseDate = promise;
            }

            WorkOrderBL orderBL = new WorkOrderBL();
            orderBL.CreateWorkOrder(workOrder);
            Response.Redirect("~/Work Orders/workorders.aspx");
        }

        protected void btnCloseRequest_Click(object sender, EventArgs e)
        {
            string requestID = Request.QueryString["requestID"];
            if (int.TryParse(requestID, out int reqID))
            {
                MaintenceBL mainBL = new MaintenceBL();
                mainBL.CloseRequest(reqID);
            }
            

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MaintenceRequest.aspx");
        }

        protected void GetRequest(int id)
        {
            DataTable requestInfo = new MaintenceBL().GetMaintenceRequest(id);
            if (requestInfo.Rows.Count > 0)
            {
                DataRow requestRow = requestInfo.Rows[0];
                txtUnitID.Value = requestRow["UnitID"].ToString();
                txtIssue.Value = requestRow["RequestDetails"].ToString();
            }
        }
    }
}