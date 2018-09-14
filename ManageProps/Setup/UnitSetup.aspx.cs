using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps.Setup
{
    public partial class UnitSetup : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UnitModel unitM = new UnitModel();
            unitM.PropertyID = Sess.ActivePropertyID;
            unitM.UnitLotNum = int.Parse(txtLotNum.Value);
            unitM.Address1 = txtAddress1.Value;
            unitM.Address2 = txtAddress2.Value;
            unitM.Zip = txtZip.Value;

            UnitDAL unitStore = new UnitDAL();
            unitStore.AddNewUnit(unitM);
        }
    }
}