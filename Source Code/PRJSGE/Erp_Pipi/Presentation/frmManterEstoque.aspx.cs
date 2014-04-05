using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using DevExpress.Web.ASPxGridView;
using Entity;
using Business;
using DevExpress.Web.ASPxEditors;
using System.Collections.Generic;
using System.Drawing;

namespace Presentation
{
    public partial class frmManterEstoque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.Public);
            Response.Cache.SetMaxAge(new TimeSpan(1, 0, 0));

        }

        protected void btnEsportarXls_Click(object sender, EventArgs e)
        {
            gvExporter.WriteXlsToResponse();
        }

        protected void btnExportarPdf_Click(object sender, EventArgs e)
        {
            gvExporter.WritePdfToResponse();
        }

        protected void gdvProdutos_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["idProduto"] = (sender as ASPxGridView).GetMasterRowKeyValue();
        }

        protected void gdvEstoque_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            if (e.Column.FieldName == "IdProduto")
            {
                e.Editor.Focus();
            }
        }

        protected void gdvEstoque_CustomErrorText(object sender, ASPxGridViewCustomErrorTextEventArgs e)
        {
            if (e.Exception.InnerException != null)
            {
                e.ErrorText = e.Exception.InnerException.Message;
            }
        }

        protected void gdvEstoque_HtmlRowPrepared(object sender, ASPxGridViewTableRowEventArgs e)
        {
            int quantidadeAtual = 0;
            ENEstoque estoque = null;
            if (e.KeyValue != null)
            {
                estoque = (new BUEstoque()).GetProdutosByIdFromEstoque(e.KeyValue.ToString());
            }

            if (estoque != null)
            {
                quantidadeAtual = estoque.QuantidadeEntrada - estoque.QuantidadeVendida;

                if (quantidadeAtual <= 5)
                {
                    e.Row.ForeColor = Color.Red;
                }
            }
        }

        protected void cbpChart_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            if (e.Parameter != null)
            {
                Session["idProduto"] = e.Parameter;
            }
        }
        protected void cbpProcessoRetirada_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            if (e.Parameter != null)
            {
                string codigoProduto = e.Parameter.Substring(e.Parameter.IndexOf("#") + 1, (int)(e.Parameter.Length - e.Parameter.IndexOf("#") - 1));
                int quantidadeProduto = Convert.ToInt32(e.Parameter.Substring(0, e.Parameter.IndexOf("#")));

                ENEstoque estoque = (new BUEstoque()).GetProdutosByIdFromEstoque(codigoProduto);

                if (estoque != null)
                {
                    //Verifica se a quantidade alterada não é menor do que a existente.
                    if (quantidadeProduto <= estoque.QuantidadeEntrada)
                    {
                        int quantidadeAtual = estoque.QuantidadeEntrada;

                        if (quantidadeAtual == quantidadeProduto)
                        {
                            (new BUEstoque()).DeleteProdutoFromEstoque(estoque);
                        }
                        else
                        {
                            estoque.QuantidadeEntrada = quantidadeAtual - quantidadeProduto;
                            estoque.ValorTotalCusto = estoque.QuantidadeEntrada * estoque.ValorCustoUnitario;
                            estoque.ValorTotalVenda = estoque.QuantidadeEntrada * estoque.ValorVendaUnitario;
                            (new BUEstoque()).UpdateProdutoFromEstoque(estoque);
                            this.gdvEstoque.DataBind();
                        }
                    }
                    else
                    {
                        //Informa ao cliente sobre quantidade incorreta.
                        throw new Exception(@"Quantidade acima do valor existente em estoque.");
                    }
                }
            }
        }

        protected void gdvEstoque_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            gdvEstoque.DataBind();
        }

        protected void gdvEstoque_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {

        }

        protected void gdvEstoque_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            e.Cancel = true;

            string idProdutoEstoque = e.NewValues["IdProduto"].ToString();
            DateTime dtEntrada = Convert.ToDateTime(e.NewValues["Entrada"].ToString());
            int quantidadeEntrada = Convert.ToInt32(e.NewValues["QuantidadeEntrada"].ToString());
            string valor = e.NewValues["ValorCustoUnitario"].ToString();
            float valorCustoUnitario = float.Parse(e.NewValues["ValorCustoUnitario"].ToString());
            float valorVendaUnitario = float.Parse(e.NewValues["ValorVendaUnitario"].ToString());

            ENEstoque estoqueCriteria = (new BUEstoque()).GetProdutosByIdFromEstoque(idProdutoEstoque);
            if (estoqueCriteria != null)
            {
                estoqueCriteria.Entrada = dtEntrada;
                estoqueCriteria.QuantidadeEntrada += quantidadeEntrada;
                estoqueCriteria.ValorCustoUnitario = valorCustoUnitario;
                estoqueCriteria.ValorVendaUnitario = valorVendaUnitario;
                estoqueCriteria.ValorTotalCusto = estoqueCriteria.QuantidadeEntrada * valorCustoUnitario;
                estoqueCriteria.ValorTotalVenda = estoqueCriteria.QuantidadeEntrada * valorVendaUnitario;

                (new BUEstoque()).UpdateProdutoFromEstoque(estoqueCriteria);
                gdvEstoque.DataBind();
                gdvEstoque.CancelEdit();
            }
            else
            {
                //Cria o produto no estoque caso ele não exista.
                ENEstoque estoque = new ENEstoque();
                estoque.IdProduto = idProdutoEstoque;
                estoque.Entrada = dtEntrada;
                estoque.QuantidadeEntrada = quantidadeEntrada;
                estoque.ValorCustoUnitario = valorCustoUnitario;
                estoque.ValorVendaUnitario = valorVendaUnitario;

                estoque.ValorTotalCusto = quantidadeEntrada * valorCustoUnitario;
                estoque.ValorTotalVenda = quantidadeEntrada * float.Parse(valorVendaUnitario.ToString("N2"));

                (new BUEstoque()).AddProdutoOnEstoque(estoque);

                gdvEstoque.DataBind();
                gdvEstoque.CancelEdit();
            }
        }

        protected void gdvEstoque_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            e.Cancel = true;

            string idProdutoEstoque = e.NewValues["IdProduto"].ToString();
            DateTime dtEntrada = Convert.ToDateTime(e.NewValues["Entrada"].ToString());
            int quantidadeEntrada = Convert.ToInt32(e.NewValues["QuantidadeEntrada"].ToString());
            string valor = e.NewValues["ValorCustoUnitario"].ToString();
            float valorCustoUnitario = float.Parse(e.NewValues["ValorCustoUnitario"].ToString());
            float valorVendaUnitario = float.Parse(e.NewValues["ValorVendaUnitario"].ToString());

            ENEstoque estoqueCriteria = (new BUEstoque()).GetProdutosByIdFromEstoque(idProdutoEstoque);
            if (estoqueCriteria != null)
            {
                estoqueCriteria.Entrada = dtEntrada;
                estoqueCriteria.QuantidadeEntrada = quantidadeEntrada;
                estoqueCriteria.ValorCustoUnitario = valorCustoUnitario;
                estoqueCriteria.ValorVendaUnitario = valorVendaUnitario;
                estoqueCriteria.ValorTotalCusto = estoqueCriteria.QuantidadeEntrada * valorCustoUnitario;
                estoqueCriteria.ValorTotalVenda = estoqueCriteria.QuantidadeEntrada * valorVendaUnitario;

                (new BUEstoque()).UpdateProdutoFromEstoque(estoqueCriteria);
                gdvEstoque.DataBind();
                gdvEstoque.CancelEdit();
            }
            else
            {
                throw new Exception(@"Impossível editar produto do estoque.");
            }
        }
    }
}
