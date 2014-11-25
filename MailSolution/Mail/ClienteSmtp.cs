using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mail
{
    public class ClienteSmtp
    {
        ISmtp sender;

        public ClienteSmtp(ISmtp sender)
        {
            this.sender = sender;
        }

        public void Send(String To, String Subject, String Body, String[] Attach,String [] credentials)
        {
            sender.enviar(To,Subject,Body,Attach,credentials);
        }
    }
}
