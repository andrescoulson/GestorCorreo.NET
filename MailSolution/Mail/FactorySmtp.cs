using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mail
{
    public class FactorySmtp
    {

        public ClienteSmtp Cliente(String mail)
        {
            switch (mail)
            {
                case "yahoo.com":
                    return new ClienteSmtp(new YahooSmtp());
                case "gmail.com":
                    return new ClienteSmtp(new GmailSmtp());
                case "hotmail.com":
                    return new ClienteSmtp(new HotmailSmtp());
            }

            return null;
        }
    }
}
