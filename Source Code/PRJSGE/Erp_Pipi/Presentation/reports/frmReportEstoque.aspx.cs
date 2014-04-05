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
    public partial class frmReportEstoque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cbpPanelReport_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                // Obtendo os dados que serão exibidos no gráfico
                DataTable dtb = (new BUEstoque()).RetornaRelatorio(txtCodigo.Text);

                dsRelatorio.tblEstoqueDataTable dtbEstoque = new dsRelatorio.tblEstoqueDataTable();
                dtbEstoque.Merge(dtb, true, MissingSchemaAction.Ignore);

                rptEstoque rptEstoque = new rptEstoque();
                rptEstoque.DataSource = dtbEstoque;

                this.ReportViewer1.Report = rptEstoque;
            }
            else
                this.ReportViewer1.DataBind();
        }
    }
}
