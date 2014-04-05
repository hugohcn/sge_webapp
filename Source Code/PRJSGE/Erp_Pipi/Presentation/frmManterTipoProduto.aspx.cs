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

namespace Presentation
{
    public partial class frmManterTipoProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gdvTipoProduto_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
        {
            this.gdvTipoProduto.AddNewRow();
        }

        protected void btnExportarPDF_Click(object sender, EventArgs e)
        {
            gvExporter.WritePdfToResponse();
        }

        protected void btnExportarXLS_Click(object sender, EventArgs e)
        {
            gvExporter.WriteXlsToResponse();
        }

        protected void gdvTipoProduto_CustomErrorText(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomErrorTextEventArgs e)
        {
            if (e.Exception.InnerException != null)
            {
                if (e.Exception.InnerException.Message.StartsWith(@"The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    e.ErrorText = "Não é possível excluir tipo de produto pois existem produtos classificados com o mesmo.";
                }
            }
        }
    }
}
