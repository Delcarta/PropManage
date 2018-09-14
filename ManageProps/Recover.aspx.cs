using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using ManageProps.codeLogic.BL;

namespace ManageProps
{
    public partial class Recover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            LoginBL log = new LoginBL();
            log.ResetEmailPassword(txtEmail.Value);
            
        }
    }
}