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

namespace Presentation
{
    public partial class frmManterClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExportarXls_Click(object sender, EventArgs e)
        {
            gvExporter.WriteXlsToResponse();
        }

        protected void btnExportarPdf_Click(object sender, EventArgs e)
        {
            gvExporter.WritePdfToResponse();
        }

        protected void gdvCarteiraCliente_BeforePerformDataSelect(object sender, EventArgs e)
        {
            Session["idCliente"] = (sender as ASPxGridView).GetMasterRowKeyValue();
        }

        protected void gdvClientes_CustomErrorText(object sender, ASPxGridViewCustomErrorTextEventArgs e)
        {
            if (e.Exception.InnerException != null)
            {
                if (e.Exception.InnerException.Message.StartsWith("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    e.ErrorText = @"Não é possível excluir um cliente com saldo devedor na carteira.";
                }
            }
        }
    }
}
