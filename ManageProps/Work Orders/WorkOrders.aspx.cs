using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps.Work_Orders
{
    public partial class WorkOrders : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string baseurl = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/');
                hdRequestData.Value = String.Format("{1}/codeLogic/Services/WorkOrderServices.asmx/GetWorkOrders?propertyID={0}", Sess.ActivePropertyID, baseurl);
            }
        }
    }
}