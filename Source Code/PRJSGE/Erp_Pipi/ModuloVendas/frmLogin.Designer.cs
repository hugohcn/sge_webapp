namespace ModuloVendas
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.lnkLogar = new System.Windows.Forms.LinkLabel();
            this.lnkSair = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(323, 54);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtLogin.Properties.Appearance.Options.UseFont = true;
            this.txtLogin.Properties.LookAndFeel.SkinName = "Money Twins";
            this.txtLogin.Properties.LookAndFeel.UseWindowsXPTheme = true;
            this.txtLogin.Size = new System.Drawing.Size(114, 19);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.ToolTip = "Insira o login de acesso ao sistema.";
            this.txtLogin.ToolTipTitle = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(323, 80);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(114, 19);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.ToolTip = "Insira a snha de acesso ao sistema.";
            this.txtSenha.ToolTipTitle = "Senha";
            // 
            // imgLogin
            // 
            this.imgLogin.Image = global::ModuloVendas.Properties.Resources.sge_login_banner__;
            this.imgLogin.Location = new System.Drawing.Point(0, 0);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(477, 143);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogin.TabIndex = 0;
            this.imgLogin.TabStop = false;
            // 
            // lnkLogar
            // 
            this.lnkLogar.AutoSize = true;
            this.lnkLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lnkLogar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLogar.LinkColor = System.Drawing.Color.Black;
            this.lnkLogar.Location = new System.Drawing.Point(365, 118);
            this.lnkLogar.Name = "lnkLogar";
            this.lnkLogar.Size = new System.Drawing.Size(34, 13);
            this.lnkLogar.TabIndex = 7;
            this.lnkLogar.TabStop = true;
            this.lnkLogar.Text = "Logar";
            this.lnkLogar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkSair
            // 
            this.lnkSair.AutoSize = true;
            this.lnkSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lnkSair.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSair.ForeColor = System.Drawing.Color.Black;
            this.lnkSair.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSair.LinkColor = System.Drawing.Color.Black;
            this.lnkSair.Location = new System.Drawing.Point(320, 118);
            this.lnkSair.Name = "lnkSair";
            this.lnkSair.Size = new System.Drawing.Size(25, 13);
            this.lnkSair.TabIndex = 8;
            this.lnkSair.TabStop = true;
            this.lnkSair.Text = "Sair";
            this.lnkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.lnkLogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.CancelButton = this.lnkSair;
            this.ClientSize = new System.Drawing.Size(487, 151);
            this.Controls.Add(this.lnkSair);
            this.Controls.Add(this.lnkLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.imgLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogin;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private System.Windows.Forms.LinkLabel lnkLogar;
        private System.Windows.Forms.LinkLabel lnkSair;
    }
}