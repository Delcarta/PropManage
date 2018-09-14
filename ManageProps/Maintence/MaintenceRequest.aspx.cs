using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps.Maintence
{
    public partial class MaintenceRequest : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string baseurl = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/');
                hdRequestData.Value = String.Format("{1}/codeLogic/Services/MaintenenceServices.asmx/GetMaintenenceRequests?propertyID={0}", Sess.ActivePropertyID, baseurl);
            }
        }
    }
}