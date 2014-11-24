using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Mail
{
    public class HotmailSmtp : ISmtp
    {
        public IPop3 server
        {
            protected get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void enviar(string To, string Subject, string Body, string[] Attach)
        {
            throw new NotImplementedException();
        }
    }
}
