using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenPop.Pop3;
using System.Data;

namespace Mail
{
    public interface IPop3
    {
        
    
        bool conectar();

        DataTable FillInbox(int p);

        OpenPop.Mime.Message GetMessage(int c);

        int GetCountMessage();

        String[] getCredential();

        void Credentials(String user, String pass);

        Dictionary<int, MyHeaders> getInbox(int max);
    }
}
