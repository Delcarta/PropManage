using ManageProps.codeLogic.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps.Maintence
{
    public partial class addMaintenceRequest : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MaintenceBL main = new MaintenceBL();
            MaintenceRequestModel mainData = new MaintenceRequestModel();

            mainData.RequestDate = DateTime.Now;
            mainData.RequestDetails = txtIssue.Value;
            mainData.UserID = Sess.Person.UserID;
            if (int.TryParse(txtUnitID.Value, out int unitID))
            {
                mainData.UnitID = unitID;
            }
            mainData.PropertyID = Sess.ActivePropertyID;
            main.AddMaintenceRequest(mainData);

            Response.Redirect("MaintenceRequest.aspx");
        }
    }
}