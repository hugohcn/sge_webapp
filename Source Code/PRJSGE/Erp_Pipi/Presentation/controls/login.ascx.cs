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
using Entity;
using System.Collections.Generic;
using BusinessLayer;

namespace Presentation.controls
{
    public partial class login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            List<ENLogin> login = (new BULogin()).GetUsuarioByLogin(txtLogin.Text, txtSenha.Text);
            if (login.Count != 0)
            {
                Session["systemAdmin"] = login[0].IsAdmin;
                Session["idUser"] = login[0].IdFuncionario;
                Session["idLogin"] = login[0].IdLogin;
                Session["strLogin"] = login[0].StrLogin;
                Response.Redirect("frmAmbiente.aspx", false);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "x", "alert('Erro: Usuário e/ou Senha incorreto(s).')", true);
            }

        }
    }
}