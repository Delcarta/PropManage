using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps.Setup
{
    public partial class PropertySetup : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PropertyModel model = new PropertyModel();
            model.PropertyName = txtPropertyName.Value;
            model.ContactPerson = txtContact.Value;
            model.Address1 = txtAddress1.Value;
            model.Address2 = txtAddress2.Value;
            model.Zip = txtZip.Value;
            model.Phone = txtPhone.Value;
            model.Email = txtEmail.Value;

            model.CompanyID = Sess.Person.CompanyID;

            PropertyBL propBL = new PropertyBL();
            propBL.AddProperty(model);
            Sess.Person.Reload();
            Response.Redirect("~/default.aspx");
        }
    }
}