using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Presentation.controls
{
    public partial class menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["systemAdmin"] != null)
            {
                if (Session["systemAdmin"].ToString().ToLower() == "true")
                {
                    menuAdmin.Visible = true;
                    //menuFuncionario.Visible = false;
                }
                else
                {
                    menuAdmin.Visible = false;
                    //menuFuncionario.Visible = true;
                }
                
            }
            else
            {
                Response.Redirect("frmLogin.aspx", false);
            }
        }

        protected void menuFuncionario_ItemClick(object source, DevExpress.Web.ASPxMenu.MenuItemEventArgs e)
        {
            if (e.Item.Name == "LogOff")
            {
                Session.Clear();
                Response.Redirect("frmLogin.aspx?logOut=true", false);
            }
        }

        protected void menuAdmin_ItemClick(object source, DevExpress.Web.ASPxMenu.MenuItemEventArgs e)
        {
            if (e.Item.Name == "LogOff")
            {
                Session.Clear();
                Response.Redirect("frmLogin.aspx?logOut=true", false);
            }
        }

        protected void cbpMensagemAdmin_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            
            
        }
    }
}