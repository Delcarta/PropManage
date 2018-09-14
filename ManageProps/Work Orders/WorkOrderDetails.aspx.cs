using ManageProps.codeLogic.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps.Work_Orders
{
    public partial class WorkOrderDetails : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadData();
            }
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            WorkOrderModel workOrder = new WorkOrderModel();
            workOrder.CurrentStatus = txtStatus.Value;
            workOrder.Notes = txtNotes.Value;
            workOrder.WorkOrderID = int.Parse(txtWorkOrderID.Value);
            if (DateTime.TryParse(txtPromiseDate.Value, out DateTime promise))
            {
                workOrder.PromiseDate = promise;
            }

            WorkOrderBL workOrderBL = new WorkOrderBL();
            workOrderBL.UpdateWorkOrder(workOrder);
            Response.Redirect("WorkOrders.aspx");
        }

        protected void LoadData()
        {
            DataTable workInfo = new WorkOrderBL().GetWorkOrder(int.Parse(Request.QueryString["WorkOrderID"]));
            if (workInfo.Rows.Count > 0)
            {
                DataTable mainInfo = new MaintenceBL().GetMaintenceRequest(int.Parse(workInfo.Rows[0]["MaintenceRequestID"].ToString()));

                txtWorkOrderID.Value = workInfo.Rows[0]["WorkOrderID"].ToString();
                txtRequestID.Value = workInfo.Rows[0]["MaintenceRequestID"].ToString();
                txtNotes.Value = workInfo.Rows[0]["Notes"].ToString();
                txtPromiseDate.Value = workInfo.Rows[0]["PromiseDate"].ToString();
                txtStatus.Value = workInfo.Rows[0]["CurrentStatus"].ToString();

                txtIssue.Value = mainInfo.Rows[0]["RequestDetails"].ToString();
                txtUnitID.Value = mainInfo.Rows[0]["UnitID"].ToString();
            }
            


        }
    }
}