using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mail
{
    public class FactoryPop
    {
        public  ClienteMail Cliente(String mail)
        {
            switch(mail)
            {
                case "yahoo.com":
                    return new ClienteMail(new YahooPop3());
                case "gmail.com":
                    return new ClienteMail(new GmailPop3());
                case "hotmail.com":
                    return new ClienteMail(new HotmailPop3());
            }

            return null;
        }
    }
}
