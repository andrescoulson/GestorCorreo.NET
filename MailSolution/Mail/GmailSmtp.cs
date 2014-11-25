using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Mail
{
    public class GmailSmtp : ISmtp
    {

        public void enviar(String To, String Subject, String Body, String[] Attach, String[] credentials)
        {
            String[] credential = credentials;
            try
            {
                SmtpClient c = new SmtpClient("smtp.gmail.com", 587);
                MailAddress add = new MailAddress(To);
                MailMessage msg = new MailMessage();
                msg.To.Add(add);
                msg.From = new MailAddress(credential[0]);
                msg.IsBodyHtml = true;
                msg.Subject = Subject;
                msg.Body = Body;
                c.Credentials = new NetworkCredential(credential[0], credential[1]);
                c.EnableSsl = true;
                for (int i = 0; i < Attach.Length; i++)
                {
                    if (Attach[i] != null)
                    {
                        Attachment attach = new Attachment(Attach[i]);
                        msg.Attachments.Add(attach);
                    }
                }
                c.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
