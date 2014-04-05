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
    public partial class frmReportVendaPeriodo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void cbpVendasPeriodo_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            if (dtInicial.Date != DateTime.MinValue && dtFinal.Date != DateTime.MinValue)
            {
                float totVendas = 0, totDesc = 0;
                DataTable dtb = (new BUVenda()).RetornaRelatorio(dtInicial.Date, dtFinal.Date);

                foreach (DataRow x in dtb.Rows)
                {
                    totVendas += float.Parse(x["fltvalortotal"].ToString());
                    totDesc += float.Parse(x["fltvalordesconto"].ToString());
                }

                lblNVendas.Text = dtb.Rows.Count.ToString();
                lblTotalDescontos.Text = totDesc.ToString("N2");
                lblTotalVendas.Text = totVendas.ToString("N2");
                lblTotal.Text = (totVendas - totDesc).ToString("N2");
            }
        }
    }
}
