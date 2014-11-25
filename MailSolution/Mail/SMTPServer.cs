using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Mail
{
    public abstract class SMTPServer 
    {
        public Pop3Server server;
        public abstract void print();
     }
}
