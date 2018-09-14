using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManageProps.codeLogic.DataModels;
using Newtonsoft.Json;

namespace ManageProps
{
    public partial class Apply : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (int.TryParse(Request.QueryString["propertyID"], out int propId))
            {
                using (var context = new LocalPropManageEntities())
                {
                    Property prop = (from x in context.Properties 
                                    where x.PropertyID == propId
                                    select x).FirstOrDefault();

                    if (prop != null)
                    {
                        //populate address
                        lblPropertyName.Text = prop.PropertyName;
                        lblPropertyAddress.Text = prop.PropertyAddress1;
                        lblPropertyPhone.Text = prop.Phone;
                    }
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            

            ResidentAppBL ResidentApp = new ResidentAppBL();
            ApplicationApplicant primary = new ApplicationApplicant();
            ApplicationApplicant secondary = new ApplicationApplicant();

            DateTime PrimaryDOB;
            if (DateTime.TryParse(txtPrimaryDOB.Value, out PrimaryDOB))
            {

                primary.FirstName = txtPrimaryFirstName.Value;
                primary.LastName = txtPrimaryLastName.Value;
                primary.Phone = txtPrimaryPhone.Value;
                primary.Social = txtPrimarySocial.Value;
                primary.Email = txtPrimaryEmail.Value;
                primary.DOB = PrimaryDOB;
                primary.DriversLicenseNum = txtPrimaryDrivers.Value;

                ResidentApp.AddApplicant(primary);
            }
            else
            {
                //do not proceed without a primary applicant
                return;
            }


            DateTime SecondaryDOB;
            if (DateTime.TryParse(txtSecondaryDOB.Value, out SecondaryDOB))
            {
                secondary.FirstName = txtSecondaryFirstName.Value;
                secondary.LastName = txtSecondaryLastName.Value;
                secondary.Phone = txtSecondaryPhone.Value;
                secondary.Social = txtSecondarySocial.Value;
                secondary.Email = txtSecondaryEmail.Value;
                secondary.DOB = SecondaryDOB;
                secondary.DriversLicenseNum = txtSecondaryDrivers.Value;

                ResidentApp.AddApplicant(secondary);
            }


            List<ApplicationPets> pets = JsonConvert.DeserializeObject<List<ApplicationPets>>(hdPets.Value);
            if (pets != null && pets.Any())
            {
                ResidentApp.AddPets(pets);
            }


            List<ApplicationOccupants> othersPeople = JsonConvert.DeserializeObject<List<ApplicationOccupants>>(hdOccupants.Value);
            if (othersPeople != null && othersPeople.Any())
            {
                ResidentApp.AddOccupants(othersPeople);
            }

            ResidentApp.ProcessApp();
        }
    }
}