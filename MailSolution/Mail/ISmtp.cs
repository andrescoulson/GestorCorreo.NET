using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Mail
{
    public interface ISmtp
    {
        void enviar(String To, String Subject, String Body, String[] Attach);             
    }
}
