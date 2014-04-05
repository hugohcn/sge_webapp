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
    public partial class frmReportVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.rpViewerVendas.DataBind();
        }

        protected void cbpPanelReport_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            //if (dtInicial.Date != DateTime.MinValue && dtFinal.Date != DateTime.MinValue)
            //{
            //    // Obtendo os dados que serão exibidos no gráfico
            //    DataTable dtb = (new BUVenda()).RetornaRelatorio(dtInicial.Date, dtFinal.Date);

            //    dsRelatorio.tblVendasDataTable dtbVendas = new dsRelatorio.tblVendasDataTable();
            //    dtbVendas.Merge(dtb, true, MissingSchemaAction.Ignore);

            //    rptVenda rptVendas = new rptVenda();
            //    rptVendas.DataSource = dtbVendas;

            //    this.rpViewerVendas.Report = rptVendas;
            //}
            //else
        }
    }
}
