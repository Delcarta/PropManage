using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManageProps.codeLogic.BL;
namespace ManageProps
{
    public partial class resetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Guid key;
            if (Guid.TryParse(Request.QueryString["id"], out key))
            {
                LoginBL logBl = new LoginBL(key);
                if (!logBl.ResetLinkExpired)
                {
                    hdUserID.Value = logBl.ResetUserID;
                }
                else
                {
                    divExpired.Visible = true;
                }
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            LoginBL log = new LoginBL();
            log.ChangePassword(txtPass1.Value, int.Parse(hdUserID.Value));
        }
    }
}