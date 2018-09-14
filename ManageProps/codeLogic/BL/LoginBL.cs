using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageProps.codeLogic.BL
{
    public class LoginBL
    {
        public bool ResetLinkExpired { get; } = true;
        public string ResetUserID { get; }

        public LoginBL()
        { }

        /// <summary>
        /// Constructor for resetting password.  Sets ResetUserID and ResetLinkExpired. Accepts Guid as key.
        /// </summary>
        /// <param name="key"></param>
        public LoginBL(Guid key)
        {

            LoginDAL logdb = new LoginDAL();
            System.Data.DataTable result = logdb.GetPasswordResetInfo(key);
            if (result.Rows.Count > 0)
            {
                if (DateTime.Now < Convert.ToDateTime(result.Rows[0]["Expiry"]))
                {
                    ResetLinkExpired = false;
                    ResetUserID = result.Rows[0]["UserID"].ToString();
                }
            }

        }

       

        public void ResetEmailPassword(string Email)
        {
            LoginDAL log = new LoginDAL();
            Guid guid = Guid.NewGuid();
            int rowCount = log.ResetPassword(Email, guid);

            if (rowCount > 0)
            {
                EmailBL mailSend = new EmailBL();
                mailSend.SendRecoveryEmail(Email, guid);
            }
        }

        public void ChangePassword(string pass, int id)
        {
            LoginDAL log = new LoginDAL();
            log.SetPassword(pass, id);
        }
    }

    
}