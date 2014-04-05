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
    public partial class frmAbrirCaixa : Form
    {
        public frmAbrirCaixa()
        {
            InitializeComponent();
        }

        private void frmAbrirCaixa_Load(object sender, EventArgs e)
        {
            //Carrega alguns dados do dia e do último caixa.
            lblDataAtual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtValorAbertura.Focus();
            //Verifica se o caixa do dia já foi aberto.
            ENCaixa caixa = (new BUCaixa()).GetLastestTransitionValue();

            if (caixa != null)
            {
                MessageBox.Show("O caixa atual já está aberto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            ENCaixa _caixa = (new BUCaixa()).GetCaixaByDate(DateTime.Now.Date);

            if (_caixa != null)
            {
                if (_caixa.BitStatus == '0')
                {
                    _caixa.BitStatus = '1';
                }

                _caixa.FltValorAbertura = float.Parse(txtValorAbertura.Text);
                _caixa.DataCaixa = DateTime.Now.Date;
                _caixa.FltValorTransicao = 0;

                (new BUCaixa()).UpdateCaixa(_caixa);
                MessageBox.Show("Operação efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                ENCaixa newCaixa = new ENCaixa();

                newCaixa.BitStatus = '1';
                newCaixa.DataCaixa = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                newCaixa.FltValorAbertura = float.Parse(txtValorAbertura.Text);
                newCaixa.FltValorFechamento = 0;
                newCaixa.FltValorTransicao = 0;

                (new BUCaixa()).CriarCaixa(newCaixa);

                MessageBox.Show("Operação efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValorAbertura.Enabled = false;
                btnAbrirCaixa.Enabled = false;
                btnCancelar.Enabled = false;
                this.Close();
            }
        }
    }
}
