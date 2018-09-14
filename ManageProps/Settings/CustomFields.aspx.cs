using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using ManageProps.codeLogic.BL;
using ManageProps.codeLogic.DataModels;
using Newtonsoft.Json;

namespace ManageProps.Settings
{
    public partial class CustomFields : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SettingsBL setBL = new SettingsBL();
                string fields = setBL.GetCustomFields(Sess.ActivePropertyID);
                if (!String.IsNullOrEmpty(fields))
                {
                    
                    hdCustomFields.Value = fields;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            SettingsBL setBL = new SettingsBL();
            setBL.SaveCustomFields(hdCustomFields.Value, Sess.ActivePropertyID, Sess.Person.CompanyID);
            Response.Redirect("settings.aspx");
        }
    }
}