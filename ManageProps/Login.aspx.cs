using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TxtLogin_Click(object sender, EventArgs e)
        {
            LoginDAL L = new LoginDAL();
            iaSession sess = L.LogInUser(txtLoginUserName.Value, txtLoginPassword.Value);
            if (sess != null && sess.IsValid)
            {
                Session["UserSession"] = sess;
                if (!sess.Person.HasCompany)
                {
                    Response.Redirect("setup/companySetup.aspx");
                }
                else if (!sess.Person.HasProperty)
                {
                    Response.Redirect("setup/propertySetup.aspx");
                }
                else
                {
                    Response.Redirect("default.aspx");
                }

            }
            else
            {
                divLogInError.Visible = true;
                txtLoginPassword.Value = "";
                txtLoginUserName.Value = "";
            }
        }
    }
}