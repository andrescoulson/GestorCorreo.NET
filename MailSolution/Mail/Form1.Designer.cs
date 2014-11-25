namespace Mail
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelGridview = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSendEmail = new System.Windows.Forms.Panel();
            this.btnBackInox = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.richTxtBx = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxAdjunto = new System.Windows.Forms.ListBox();
            this.btnAddAdjunto = new System.Windows.Forms.Button();
            this.btnSendd = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSendEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelGridview);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.lblPass);
            this.panelLogin.Controls.Add(this.txtEmail);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(676, 541);
            this.panelLogin.TabIndex = 0;
            // 
            // panelGridview
            // 
            this.panelGridview.Controls.Add(this.panelSendEmail);
            this.panelGridview.Controls.Add(this.label2);
            this.panelGridview.Controls.Add(this.dataGridView1);
            this.panelGridview.Controls.Add(this.btnSend);
            this.panelGridview.Controls.Add(this.lblPage);
            this.panelGridview.Controls.Add(this.btnBack);
            this.panelGridview.Controls.Add(this.btnNext);
            this.panelGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridview.Location = new System.Drawing.Point(0, 0);
            this.panelGridview.Name = "panelGridview";
            this.panelGridview.Size = new System.Drawing.Size(676, 541);
            this.panelGridview.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(573, 38);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Nuevo";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(322, 475);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(35, 13);
            this.lblPage.TabIndex = 3;
            this.lblPage.Text = "label2";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Anterior";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(573, 466);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(296, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Enviar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(227, 261);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(289, 20);
            this.txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(115, 261);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(226, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "INBOX";
            // 
            // panelSendEmail
            // 
            this.panelSendEmail.Controls.Add(this.btnSendd);
            this.panelSendEmail.Controls.Add(this.btnAddAdjunto);
            this.panelSendEmail.Controls.Add(this.listBoxAdjunto);
            this.panelSendEmail.Controls.Add(this.label3);
            this.panelSendEmail.Controls.Add(this.richTxtBx);
            this.panelSendEmail.Controls.Add(this.txtSubject);
            this.panelSendEmail.Controls.Add(this.txtTo);
            this.panelSendEmail.Controls.Add(this.lblSubject);
            this.panelSendEmail.Controls.Add(this.lblTo);
            this.panelSendEmail.Controls.Add(this.btnBackInox);
            this.panelSendEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSendEmail.Location = new System.Drawing.Point(0, 0);
            this.panelSendEmail.Name = "panelSendEmail";
            this.panelSendEmail.Size = new System.Drawing.Size(676, 541);
            this.panelSendEmail.TabIndex = 6;
            // 
            // btnBackInox
            // 
            this.btnBackInox.Location = new System.Drawing.Point(28, 38);
            this.btnBackInox.Name = "btnBackInox";
            this.btnBackInox.Size = new System.Drawing.Size(75, 23);
            this.btnBackInox.TabIndex = 0;
            this.btnBackInox.Text = "Inbox";
            this.btnBackInox.UseVisualStyleBackColor = true;
            this.btnBackInox.Click += new System.EventHandler(this.btnBackInox_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(151, 100);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Para";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(140, 142);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(40, 13);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Asunto";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(196, 97);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(452, 20);
            this.txtTo.TabIndex = 3;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(196, 139);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(452, 20);
            this.txtSubject.TabIndex = 4;
            // 
            // richTxtBx
            // 
            this.richTxtBx.Location = new System.Drawing.Point(196, 184);
            this.richTxtBx.Name = "richTxtBx";
            this.richTxtBx.Size = new System.Drawing.Size(452, 305);
            this.richTxtBx.TabIndex = 5;
            this.richTxtBx.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adjunto";
            // 
            // listBoxAdjunto
            // 
            this.listBoxAdjunto.FormattingEnabled = true;
            this.listBoxAdjunto.Location = new System.Drawing.Point(28, 184);
            this.listBoxAdjunto.Name = "listBoxAdjunto";
            this.listBoxAdjunto.Size = new System.Drawing.Size(135, 303);
            this.listBoxAdjunto.TabIndex = 7;
            // 
            // btnAddAdjunto
            // 
            this.btnAddAdjunto.Location = new System.Drawing.Point(49, 507);
            this.btnAddAdjunto.Name = "btnAddAdjunto";
            this.btnAddAdjunto.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdjunto.TabIndex = 8;
            this.btnAddAdjunto.Text = "Agregar";
            this.btnAddAdjunto.UseVisualStyleBackColor = true;
            this.btnAddAdjunto.Click += new System.EventHandler(this.btnAddAdjunto_Click);
            // 
            // btnSendd
            // 
            this.btnSendd.Location = new System.Drawing.Point(573, 47);
            this.btnSendd.Name = "btnSendd";
            this.btnSendd.Size = new System.Drawing.Size(75, 23);
            this.btnSendd.TabIndex = 9;
            this.btnSendd.Text = "Send";
            this.btnSendd.UseVisualStyleBackColor = true;
            this.btnSendd.Click += new System.EventHandler(this.btnSendd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 541);
            this.Controls.Add(this.panelLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelGridview.ResumeLayout(false);
            this.panelGridview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSendEmail.ResumeLayout(false);
            this.panelSendEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGridview;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSendEmail;
        private System.Windows.Forms.Button btnSendd;
        private System.Windows.Forms.Button btnAddAdjunto;
        private System.Windows.Forms.ListBox listBoxAdjunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTxtBx;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnBackInox;
    }
}

