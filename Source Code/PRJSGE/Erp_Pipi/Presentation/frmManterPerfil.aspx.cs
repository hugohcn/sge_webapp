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
using Entity;
using BusinessLayer;

namespace Presentation
{
    public partial class frmManterPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["idUser"] != null)
                {
                    ENFuncionario funcionario = new ENFuncionario();
                    funcionario = (new BUFuncionario()).GetFuncionarioById(Convert.ToInt32(Session["idUser"]));

                    if (funcionario != null)
                    {
                        txtNome.Text = funcionario.StrNome;
                        txtEndereco.Text = funcionario.StrEndereco;
                        txtNumero.Text = funcionario.IntNumero.ToString();
                        txtBairro.Text = funcionario.StrBairro;
                        txtCidade.Text = funcionario.StrCidade;
                        txtEstado.Text = funcionario.StrEstado;
                        txtCep.Text = funcionario.StrCep;
                        txtTelefone.Text = funcionario.StrTelefone;
                        txtCelular.Text = funcionario.StrCelular;
                        txtFax.Text = funcionario.StrFax;
                        txtEmail.Text = funcionario.StrEmail;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "x", "alert('Funcionário não cadastrado.')", true);
                    }
                }
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            ENFuncionario funcionarioEdit = new ENFuncionario();
            try
            {
                funcionarioEdit.IntIdFuncionario = Convert.ToInt32(Session["idUser"]);
                funcionarioEdit.StrNome = txtNome.Text;
                funcionarioEdit.StrEndereco = txtEndereco.Text;
                funcionarioEdit.IntNumero = Convert.ToInt32(txtNumero.Text);
                funcionarioEdit.StrBairro = txtBairro.Text;
                funcionarioEdit.StrCidade = txtCidade.Text;
                funcionarioEdit.StrEstado = txtEstado.Text;
                funcionarioEdit.StrCep = txtCep.Text;
                funcionarioEdit.StrTelefone = txtTelefone.Text;
                funcionarioEdit.StrCelular = txtCelular.Text;
                funcionarioEdit.StrFax = txtFax.Text;
                funcionarioEdit.StrEmail = txtEmail.Text;
                
                BUFuncionario buFuncionario = new BUFuncionario();
                buFuncionario.UpdateFuncionario(funcionarioEdit);

                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "x", "alert('Dados atualizados com sucesso.')", true);
            }
            catch (Exception eX)
            {

                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "x", "alert('" + eX.Message + "')", true);
            }
        }
    }
}
