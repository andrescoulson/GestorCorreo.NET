using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Mail
{
    public class ClienteMail
    {
        IPop3 cliente;

        public ClienteMail(IPop3 cliente)
        {
            this.cliente = cliente;
        }

        public bool conectar()
        {
            return cliente.conectar();
        }

        public void Credentials(String u,string p)
        {
            cliente.Credentials(u, p);
        }

        public String[] getCredential()
        {
            return cliente.getCredential();
        }

        public DataTable FillDataGrid(int p)
        {
            return cliente.FillInbox(p);
        }


    }
}
