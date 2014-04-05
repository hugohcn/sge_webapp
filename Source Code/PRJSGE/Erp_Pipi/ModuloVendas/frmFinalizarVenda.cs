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
    public partial class frmFinalizarVenda : Form
    {
        ENVenda venda = null;
        List<ENItemCarrinho> lstItemCarrinho = new List<ENItemCarrinho>();
        public frmFinalizarVenda()
        {
            InitializeComponent();
        }

        public frmFinalizarVenda(ENVenda itemVenda, List<ENItemCarrinho> lstItemCarrinho)
        {
            InitializeComponent();
            venda = itemVenda;
            this.lstItemCarrinho = lstItemCarrinho;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFinalizarVenda_Load(object sender, EventArgs e)
        {
            txtValorRecebido.Focus();
            lblValorTotal.Text = (float.Parse(venda.FltValorTotal.ToString("N2")) - float.Parse(venda.FltValorDesconto.ToString("N2"))).ToString("N2");
            lblValorDesconto.Text = venda.FltValorDesconto.ToString("N2");

        }

        private void btnEfetuarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                ENCaixa cx = (new BUCaixa()).GetLastestTransitionValue();

                if (cx != null)
                {
                    float valorPago = float.Parse(txtValorRecebido.Text);
                    lblValorTroco.Text = (valorPago - float.Parse(lblValorTotal.Text)).ToString("n2");

                    //Salvando a venda.
                    venda.BitStatusVenda = true;
                    venda.FltValorTotal = float.Parse(lblValorTotal.Text);
                    venda.FltValorDesconto = float.Parse(lblValorDesconto.Text);
                    venda.DteVenda = DateTime.Now.Date;

                    (new BUVenda()).CreateVenda(venda);

                    int ultimaVenda = (new BUVenda()).GetLastVenda();

                    //Salvando os itens do carrinho.
                    foreach (ENItemCarrinho x in lstItemCarrinho)
                    {
                        //Retirando itens do estoque.

                        ENEstoque estoque = (new BUEstoque()).GetProdutosByIdFromEstoque(x.IdProduto);

                        if (estoque != null)
                        {
                            estoque.QuantidadeVendida += x.IntQuatidade;
                            estoque.QuantidadeEntrada = estoque.QuantidadeEntrada - x.IntQuatidade;
                            (new BUEstoque()).UpdateProdutoFromEstoque(estoque);
                        }

                        //FIM retirada.
                        x.IdVenda = ultimaVenda;
                        (new BUItemCarrinho()).CreateCarrinho(x);
                    }

                    //Salvar a venda na tabela de caixa.
                    //Se existir o caixa aberto...dar um update no valor de transicao.
                    ENCaixa cxa = (new BUCaixa()).GetLastestTransitionValue();
                    if (cxa != null)
                    {
                        float aux = cxa.FltValorTransicao;

                        cxa.FltValorTransicao = aux + venda.FltValorTotal;

                        (new BUCaixa()).UpdateCaixa(cxa);

                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Caixa fechado. Impossível efetuar venda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtValorRecebido_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorRecebido.Text))
            {
                 lblValorTroco.Text = (float.Parse(txtValorRecebido.Text) - float.Parse(lblValorTotal.Text)).ToString("n2");     
            }
        }
    }
}
