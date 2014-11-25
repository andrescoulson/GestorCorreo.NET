using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mail
{
    public abstract class ServerPop3 
    {
        
         public abstract ClienteMail Validate(String mail);
        
    }
}
