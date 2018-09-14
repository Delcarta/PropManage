using ManageProps.codeLogic.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps.codeLogic.Controls.ResidentTabControls
{
    public partial class UserControl : System.Web.UI.UserControl
    {
        public int ResidentID { get; set; }
        public int PropertyID { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadFields();
            }
        }

        protected void LoadFields()
        {
            hdResidentFieldValues.Value = new ResidentBL().GetCustomFieldValues(ResidentID, PropertyID);
        }

        public void Save()
        {
            new ResidentBL().SaveCustomFieldValues(hdResidentFieldValues.Value, int.Parse(Request.QueryString["ResidentID"]));
        }
    }
}