using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps.Setup
{
    public partial class CompanySetup : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CompanyModel model = new CompanyModel();
            model.CompanyName = txtCompanyName.Value;
            model.DBAName = txtDBA.Value;
            model.Address1 = txtAddress1.Value;
            model.Address2 = txtAddress2.Value;
            model.Zip = txtZip.Value;
            model.Phone = txtPhone.Value;
            model.Email = txtEmail.Value;

            model.UserID = Sess.Person.UserID;

            CompanyBL compBL = new CompanyBL();
            compBL.AddCompany(model);

            Sess.Person.Reload();
            Response.Redirect("propertySetup.aspx");
        }
    }
}