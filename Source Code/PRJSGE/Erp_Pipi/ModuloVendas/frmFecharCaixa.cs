using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;
using Business;

namespace ModuloVendas
{
    public partial class frmFecharCaixa : Form
    {
        public frmFecharCaixa()
        {
            InitializeComponent();
        }

        private void frmFecharCaixa_Load(object sender, EventArgs e)
        {
            //Recupera o último registro em aberto do dia com status 1.
            ENCaixa caixa = (new BUCaixa()).GetLastestTransitionValue();

            if (caixa != null)
            {
                lblValorAtual.Text = caixa.FltValorTransicao.ToString("n2");
            }
            else
            {
                MessageBox.Show("O caixa não está aberto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            ENCaixa caixa = (new BUCaixa()).GetLastestTransitionValue();
            caixa.BitStatus = '0';
            caixa.FltValorFechamento = caixa.FltValorTransicao;

            (new BUCaixa()).UpdateCaixa(caixa);
            this.Close();
        }
    }
}
