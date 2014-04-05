using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;
using Entity;

namespace ModuloVendas
{
    public partial class frmModuloVendas : Form
    {
        List<ENItemCarrinho> lstItemCarrinho = new List<ENItemCarrinho>();

        public frmModuloVendas()
        {
            InitializeComponent();
        }

        private void frmModuloVendas_Load(object sender, EventArgs e)
        {
            //VERIFICA SE EXISTE CAIXA ABERTO. CASO NÃO EXISTA O USUÁRIO DEVERÁ ABRIR UM.
            //ENCaixa caixa = (new BUCaixa()).GetLastestTransitionValue();
            //if (caixa == null)
            //{
            //    txtCodigoProduto.Enabled = false;
            //    txtQuantidade.Enabled = false;
            //    txtDesconto.Enabled = false;
            //    gdvProdutos.Enabled = false;
            //    cmbTipoPagamento.Enabled = false;
            //    btnEfetuarVenda.Enabled = false;
            //    btnLimparForm.Enabled = false;
            //}
            //else
            //{
            //    txtCodigoProduto.Enabled = true;
            //    txtQuantidade.Enabled = true;
            //    txtDesconto.Enabled = true;
            //    gdvProdutos.Enabled = true;
            //    cmbTipoPagamento.Enabled = true;
            //}
            
            // TODO: This line of code loads data into the 'dsTipoPagamento.TBLTIPOPAGAMENTO' table. You can move, or remove it, as needed.
            this.tBLTIPOPAGAMENTOTableAdapter.Fill(this.dsTipoPagamento.TBLTIPOPAGAMENTO);
            lblValor.Text = "0,00";
            txtCodigoProduto.Focus(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmConfigurarDados()).ShowDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAbrirCaixa()).ShowDialog();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmFecharCaixa()).ShowDialog();
        }

        private void txtQuantidade_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(txtCodigoProduto.Text))
                    {
                        if (!string.IsNullOrEmpty(txtQuantidade.Text))
                        {
                            string codigoProduto = txtCodigoProduto.Text;
                            gdvProdutos.AutoGenerateColumns = false;

                            //Recuperando produto.
                            ENProduto produto = (new BUProduto()).GetProdutoById(codigoProduto);

                            if (produto != null)
                            {
                                float aux = 0;
                                ENEstoque estoque = (new BUEstoque()).GetProdutosByIdFromEstoque(codigoProduto);
                                if (estoque != null)
                                {

                                    DataGridViewRow gdvRow = new DataGridViewRow();
                                    gdvRow.CreateCells(gdvProdutos);
                                    gdvRow.Cells[0].Value = produto.IdProduto;
                                    gdvRow.Cells[1].Value = produto.StrNome;
                                    gdvRow.Cells[2].Value = estoque.ValorVendaUnitario.ToString("n2");
                                    gdvRow.Cells[3].Value = txtQuantidade.Text;
                                    aux = float.Parse((Convert.ToInt32(txtQuantidade.Text) * estoque.ValorVendaUnitario).ToString("n2"));
                                    gdvRow.Cells[4].Value = aux.ToString("n2");
                                    lblValor.Text = (float.Parse(lblValor.Text) + aux).ToString("n2");
                                    gdvProdutos.Rows.Add(gdvRow);

                                    //Adiciona o iten do grid na lista de itens do carrinho.
                                    ENItemCarrinho itemCarrinho = new ENItemCarrinho();
                                    itemCarrinho.IdProduto = produto.IdProduto;
                                    itemCarrinho.IntQuatidade = Convert.ToInt32(txtQuantidade.Text);

                                    lstItemCarrinho.Add(itemCarrinho);

                                    txtCodigoProduto.Text = string.Empty;
                                    txtCodigoProduto.Focus();
                                    txtQuantidade.Text = string.Empty;
                                    aux = 0;
                                }
                                else
                                {
                                    MessageBox.Show("Produto não cadastrado no estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Produto não cadastrado no sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Informe a quantidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe o código do produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gdvProdutos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                float valorAtualCompra = float.Parse(lblValor.Text);

                string codigoProduto = e.Row.Cells[0].Value.ToString();
                string nomeProduto = e.Row.Cells[1].Value.ToString();
                float valorVenda = float.Parse(e.Row.Cells[2].Value.ToString());
                int quantidadeVendida = Convert.ToInt32(e.Row.Cells[3].Value.ToString());
                float valorTotal = float.Parse(e.Row.Cells[4].Value.ToString());

                lblValor.Text = (valorAtualCompra - valorTotal).ToString("n2");
                txtCodigoProduto.Text = string.Empty;
                txtQuantidade.Text = string.Empty;
                txtCodigoProduto.Focus();

                //Remove produto da lista de Itens do carrinho.
                foreach (ENItemCarrinho x in lstItemCarrinho)
                {
                    if (x.IdProduto == codigoProduto)
                    {
                        lstItemCarrinho.Remove(x);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            this.gdvProdutos.Rows.Clear();
            txtCodigoProduto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtDesconto.Text = "0,00";
            lblValor.Text = "0,00";
            cmbTipoPagamento.SelectedIndex = 0;
            txtCodigoProduto.Focus();
            lstItemCarrinho.Clear();
        }

        private void btnEfetuarVenda_Click(object sender, EventArgs e)
        {
            if (lstItemCarrinho.Count == 0)
            {
                MessageBox.Show("Informe ao menos um produto para finalizar a venda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigoProduto.Focus();
            }
            else
            {
                ENVenda venda = new ENVenda();
                venda.FltValorDesconto = float.Parse(txtDesconto.Text);

                venda.FltValorTotal = float.Parse(lblValor.Text);

                if (cmbTipoPagamento.SelectedValue != null)
                {
                    venda.TipoPagamento = Convert.ToInt32(cmbTipoPagamento.SelectedValue);
                }
                
                frmFinalizarVenda fnlVenda = new frmFinalizarVenda(venda, lstItemCarrinho);
                fnlVenda.ShowDialog();

                lstItemCarrinho.Clear();
                gdvProdutos.Rows.Clear();
                lstItemCarrinho.Clear();
                gdvProdutos.Rows.Clear();
                lblValor.Text = "0,00";
                txtCodigoProduto.Focus();
                txtDesconto.Text = "0,00";
                cmbTipoPagamento.SelectedIndex = 0;

            }
        }

        private void reabrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmCancelarVenda()).ShowDialog();
        }

        private void contToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmContato()).ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://localhost/administracao");
        }
    }
}
