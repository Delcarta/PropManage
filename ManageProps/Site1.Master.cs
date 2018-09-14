using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageProps
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected iaSession _currentSess;
        public iaSession currentSess
        {
            get
            {
                if (_currentSess == null)
                {
                    _currentSess = Session["UserSession"] as iaSession;
                }
                return _currentSess;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    string pageTitle = SiteMap.CurrentNode.Title;
                    Page.Title = pageTitle;
                    lblPageTitle.InnerText = pageTitle;
                }
                catch
                {
                    siteCrumbs.Visible = false;
                }
               

                if (currentSess == null || !currentSess.IsValid)
                {
                    Response.Redirect("~/login.aspx");
                }

                if (!currentSess.Person.HasCompany || !currentSess.Person.HasProperty)
                {
                    navSideBar.Visible = false;
                }
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                lblTitle.Text = string.Format("{0}", currentSess.Person.Title);
                lblName.Text = textInfo.ToTitleCase(string.Format("{0} {1}", currentSess.Person.FirstName, currentSess.Person.LastName));

            }
        }
    }
}