using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            string email, user, pass, first, last;
            email = txtEmail.Value;
            user = txtUser.Value;
            pass = txtPassword.Value;
            first = txtFirstName.Value;
            last = txtLastName.Value;

            LoginDAL L = new LoginDAL();
            iaSession sess = L.CreateUser(email, user, pass, first, last);
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
        }
    }
}