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
    public class GmailPop3 : Pop3Server, IPop3
    {
<<<<<<< HEAD

        DataTable inbox = new DataTable();
=======
>>>>>>> origin/master

        DataTable inbox = new DataTable();
        public GmailPop3()
        {
            this.server = new Pop3Client();
            this.Host = "pop.gmail.com";
            this.Port = 995;
            inbox.Columns.Add("From");
            inbox.Columns.Add("Subject");
            inbox.Columns.Add("Date");
        }

        public GmailPop3(String user, String pass)
        {
            this.Host = "pop.gmail.com";
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

        public OpenPop.Mime.Message GetMessage(int p)
        {
           return this.server.GetMessage(p);
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

            max = this.server.GetMessageCount() - (max * 10);
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


        public DataTable FillInbox(int Page)
<<<<<<< HEAD
        {
                       
            Dictionary<int, MyHeaders> headers = this.getInbox(Page);           
=======
        {      

            Dictionary<int, MyHeaders> headers = this.getInbox(Page);
            inbox.Rows.Clear();
>>>>>>> origin/master
            foreach (KeyValuePair<int, MyHeaders> entry in headers)
            {
                try
                {
                    inbox.Rows.Add(entry.Value.From, entry.Value.Subject, entry.Value.Date);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

            return inbox;
        }

              
        public String[] getCredential()
        {
            String[] result = new String[2];

            result[0] = this.User;
            result[1] = this.Password;

            return result;
        }


        public int GetCountMessage()
        {
            return this.server.GetMessageCount();
        }
    }
}
