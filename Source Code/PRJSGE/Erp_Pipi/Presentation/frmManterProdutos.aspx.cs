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
using System.Drawing;

namespace Presentation
{
    public partial class frmManterProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExportarPdf_Click(object sender, EventArgs e)
        {
            gdvExporter.WritePdfToResponse();
        }

        protected void btnExportarXls_Click(object sender, EventArgs e)
        {
            gdvExporter.WriteXlsToResponse();
        }

        protected void gdvProdutos_CustomErrorText(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomErrorTextEventArgs e)
        {
            if (e.Exception.InnerException != null)
            {
                e.ErrorText = e.Exception.InnerException.Message;
            }
            else
            {
                e.ErrorText = "Erro não identificado do sistema. Comunique ao administrador e/ou fabricante";
            }
        }

        protected void gdvProdutos_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewEditorEventArgs e)
        {
            if (e.Column.FieldName == "IdProduto")
            {
                e.Editor.Focus();
            }
        }
    }
}
