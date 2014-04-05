using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using Entity;

namespace ModuloVendas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.txtLogin.Text == string.Empty || this.txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Informe login/senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                List<ENLogin> lstLogin = (new BULogin()).GetUsuarioByLogin(this.txtLogin.Text, this.txtSenha.Text);
                if (lstLogin.Count > 0)
                {
                    if (lstLogin[0].StrLogin == txtLogin.Text && lstLogin[0].StrSenha == txtSenha.Text)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
