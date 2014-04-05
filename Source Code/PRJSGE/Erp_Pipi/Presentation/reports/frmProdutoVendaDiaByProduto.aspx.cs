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
using Business;

namespace Presentation.reports
{
    public partial class frmProdutoVendaDiaByProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigoProduto.Focus();
        }

        protected void gdvProdutosByIdVendaDia_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
        {
            if (dtInicial.Date != DateTime.MinValue && dtFinal.Date != DateTime.MinValue && !string.IsNullOrEmpty(txtCodigoProduto.Text))
            {
                
                DataTable dtb = (new BUVenda()).RetornaRelatorioProdutosVendaDiaByProduto(dtInicial.Date, dtFinal.Date, txtCodigoProduto.Text);

                gdvProdutosByIdVendaDia.DataSource = dtb;

                gdvProdutosByIdVendaDia.DataBind();

            }
            else
            {

                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "x", "alert('Erro: Especifique o período e o código do produto.')", true);

            }
        }
    }
}
