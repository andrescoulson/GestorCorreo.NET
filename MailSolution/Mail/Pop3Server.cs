using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mail
{
    public abstract class Pop3Server
    {
        public Pop3Client server;
        public String Host;
        public int Port;
        public String User;
        public String Password;

        public abstract void Disconect();
    }
}
