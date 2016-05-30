using System;
using System.Text;
using System.Web;
using System.Net.Mail;
using System.Configuration;

namespace PM4P
{
    class EmailSpoof
    {
        public void sendEmail(string fromName, string fromEmail, string body, string subject, string toEmail, string port, string server)
        {
            MailAddress to = new MailAddress(toEmail);
            MailAddress from = new MailAddress(fromEmail);
            MailMessage msg = new MailMessage(from, to);

            msg.Subject = subject;
            msg.Body = body;

            SmtpClient client = new SmtpClient(server);

            try
            {
                client.Send(msg);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
