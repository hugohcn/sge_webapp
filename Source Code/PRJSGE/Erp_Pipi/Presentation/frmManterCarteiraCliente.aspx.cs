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
using DevExpress.Web.ASPxPopupControl;
using Entity;
using Business;

namespace Presentation
{
    public partial class frmManterCarteiraCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gdvCarteiras_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs e)
        {
            if (Convert.ToDateTime(e.GetValue("DteDataPagamento")) <= DateTime.Now)
            {
                e.Row.ForeColor = Color.Red;
            }
        }

        protected void cpPopValorPago_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            if (e.Parameter != null)
            {
                Session["iKey"] = Convert.ToInt32(e.Parameter);
            }
        }

        protected void gdvCarteiras_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
        {
            if (e.Parameters != null && e.Parameters != string.Empty)
            {
                if (Session["iKey"] != null)
                {
                    ENCarteira carteira = (new BUCarteira()).GetCarteiraById(Convert.ToInt32(Session["iKey"]));
                    txtValorPago.Text = string.Empty;
                    (new BUCarteira()).BaixaCarteira(carteira.IdCarteira, float.Parse(e.Parameters));
                    this.gdvCarteiras.DataBind();
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "x", "alert('Erro: Informe um valor para efetuar baixa.')", true);
            }
        }

        protected void gdvCarteiras_CustomErrorText(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomErrorTextEventArgs e)
        {
            if (e.Exception.InnerException.Message == "O usuário ainda obtem créditos.")
            {
                e.ErrorText = "O usuário ainda obtem créditos.";
            }
        }

        protected void btnExportarXls_Click(object sender, EventArgs e)
        {
            gvExporter.WriteXlsToResponse();
        }

        protected void btnExportarPdf_Click(object sender, EventArgs e)
        {
            gvExporter.WritePdfToResponse();
        }
    }
}
