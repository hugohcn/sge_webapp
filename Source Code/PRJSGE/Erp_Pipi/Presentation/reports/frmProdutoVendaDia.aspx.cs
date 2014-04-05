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
using DevExpress.Web.ASPxGridView;
using DevExpress.Data;

namespace Presentation.reports
{
    public partial class frmProdutoVendaDia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cbpRelatorioVendaDetalhadaDia_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            
        }

        protected void gdvProdutos_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            if (dtInicial.Date != DateTime.MinValue && dtFinal.Date != DateTime.MinValue)
            {
                DataTable dtb = (new BUVenda()).RetornaRelatorioProdutosVendaDia(dtInicial.Date, dtFinal.Date);

                gdvProdutos.DataSource = dtb;
                gdvProdutos.DataBind();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "x", "alert('Erro: Especifique uma data de início e fim.')", true);
            }
        }
    }
}
