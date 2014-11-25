using OpenPop.Mime.Header;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mail
{
    public class YahooPop3 : Pop3Server, IPop3
    {
        DataTable inbox = new DataTable();
        public YahooPop3()
        {
            this.server = new Pop3Client();
            this.Host = "pop.mail.yahoo.com";
            //this.Host = "plus.pop.mail.yahoo.com";
            this.Port = 995;
            inbox.Columns.Add("From");
            inbox.Columns.Add("Subject");
            inbox.Columns.Add("Date");
        }

        public YahooPop3(String user, String pass)
        {
            this.Host = "pop.mail.yahoo.com";
            //this.Host = "plus.pop.mail.yahoo.com";
            this.Port = 995;
            this.User = user;
            this.Password = pass; 
        }

        public bool conectar()
        {
            try
            {
                this.server.Connect(this.Host, this.Port, true);
                this.server.Authenticate(this.User, this.Password);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public DataTable FillInbox(int Page)
        {
            
            
            
            Dictionary<int, MyHeaders> headers = this.getInbox(Page);
            inbox.Rows.Clear();
            foreach (KeyValuePair<int, MyHeaders> entry in headers)
            {
                inbox.Rows.Add(entry.Value.From, entry.Value.Subject, entry.Value.Date);

            }

            return inbox;
        }

        public OpenPop.Mime.Message GetMessage(int p)
        {
            return this.server.GetMessage(p);
        }

        public int GetCountMessage()
        {
            return this.server.GetMessageCount();
        }

        public override bool Disconect()
        {
            return true;
        }

        public void Credentials(string user, string pass)
        {
            this.User = user;
            this.Password = pass;
        }

        public Dictionary<int, MyHeaders> getInbox(int max)
        {
            Dictionary<int, MyHeaders> result = new Dictionary<int, MyHeaders>();

            max = server.GetMessageCount() - (max * 10);
            int min = max - 10;
            if (min < 1)
            {
                min = 1;
            }
            MyHeaders temp;
            MessageHeader headers;
            for (int i = max; i >= min; i--)
            {
                headers = server.GetMessageHeaders(i);
                temp = new MyHeaders(headers.From.DisplayName, headers.Subject, headers.Date);
                result.Add(i, temp);

            }

            return result;
        }

        public String[] getCredential()
        {
            String[] result = new String[2];

            result[0] = this.User;
            result[1] = this.Password;

            return result;
        }
    }
}
