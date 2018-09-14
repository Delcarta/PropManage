using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace ManageProps.codeLogic.BL
{
    public class EmailBL
    {
        public EmailBL()
        { }

        public void SendRecoveryEmail(string Email, Guid guid)
        {
            String userName = "dskipper@simplymanage.net";
            String password = "Oria6742!";
            String fromEmail = "no-reply@simplymanage.net";
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(Email));
            msg.From = new MailAddress(fromEmail);
            msg.Subject = "Simply Manage Password Reset Link";
            msg.Body = String.Format("This link will expire in 2 hours. http://www.simplymanage.net/resetPassword.aspx?id={0}", guid);
            msg.IsBodyHtml = true;
            SmtpClient client = new SmtpClient
            {
                Host = "smtp.office365.com",
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(userName, password),
                Port = 587,
                EnableSsl = true,
                Timeout = 100000

            };

            client.Send(msg);
        }
    }
}