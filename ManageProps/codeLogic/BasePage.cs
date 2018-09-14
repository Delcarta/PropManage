

public class BasePage : System.Web.UI.Page
{
    private iaSession _sess;
    public iaSession Sess
    {
        get
        {
            if (this._sess != null)
            {
                return _sess;
            }
            else
            {
               _sess = Session["UserSession"] as iaSession;
                if (this._sess == null)
                    Response.Redirect("~/Login.aspx");
                return _sess;
            }
        }
    }

    


}