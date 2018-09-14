using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps.Residents
{
    public partial class ResidentDetails : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetTabValues();
            }
        }

        private void SetTabValues()
        {
            if (int.TryParse(Request.QueryString["ResidentID"], out int resID))
            {
                //user defined fields
                tabFields.ResidentID = resID;
                tabFields.PropertyID = Sess.ActivePropertyID;
            }


             
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            tabFields.Save();//Custom Fields Tab
        }
    }
}