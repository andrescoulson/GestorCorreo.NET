using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail
{
    public partial class Form1 : Form
    {
        int Page;
        ClienteMail cliente;
        ClienteSmtp send;
        FactoryPop f = new FactoryPop();
        FactorySmtp s = new FactorySmtp();        
        DataTable inbox = new DataTable();
        public Form1()
        {
            InitializeComponent();
            inbox.Columns.Add("From");
            inbox.Columns.Add("Subject");
            inbox.Columns.Add("Date");
            panelGridview.Visible = false;
            panelSendEmail.Visible = false;
        }

        private void fillInbox(int AddOrSub)
        {
            Page = Page + AddOrSub;
            if (Page < 0)
            {
                Page = 0;
            }
            inbox = cliente.FillDataGrid(Page); ;
            this.dataGridView1.DataSource = inbox;
           // this.dataGridView2.DataSource = inbox;
           // this.dataGridView2.AutoResizeColumns();
            this.dataGridView1.AutoResizeColumns();
            this.lblPage.Text = "Página " + (Page + 1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user = txtEmail.Text;
            String pass = txtPass.Text;
            String[] words = user.Split('@');
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + 
                              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(user))
            {
               
                cliente = f.Cliente(words[1]);
                send = s.Cliente(words[1]);

                if (cliente != null)
                {
                    cliente.Credentials(user, pass);
                    if (cliente.conectar())
                    {
                        //panelLogin.Visible = false;
                        panelGridview.Visible = true;

                        fillInbox(0);
                    }
                }
                else
                    MessageBox.Show("Error en Envio de Datos Servicio no disponible !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
            else
            {
                MessageBox.Show("Email Invalido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            fillInbox(1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fillInbox(-1);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            panelSendEmail.Visible = true;
        }

        private void btnBackInox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAdjunto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            DialogResult resultado = file.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                listBoxAdjunto.Items.Add(file.FileName);
            }
        }

        private void btnSendd_Click(object sender, EventArgs e)
        {
            String to = txtTo.Text;
            String subject = txtSubject.Text;
            String body = richTxtBx.Text;
            String[] attach = new String[listBoxAdjunto.Items.Count];
            String[] cred =cliente.getCredential();
            for (int i = 0; i < listBoxAdjunto.Items.Count; i++)
            {
                attach[i] = listBoxAdjunto.Items[i].ToString();
            }
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + 
                              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(to))
            {
                send.Send(to, subject, body, attach, cred);
                panelSendEmail.Visible = false;
            }
            else
                MessageBox.Show("Correo invalido !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

       

        
    }
}
