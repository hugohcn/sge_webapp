using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Access
{
    public class DARevendedor
    {
        /// <summary>
        /// Seleciona uma lista de Revendedores de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>ENRevendedor</returns>
        public List<ENRevendedor> ReadAllRevendedor(int EspecificoR, int idRevendedor)
        {
            List<ENRevendedor> _objs = new List<ENRevendedor>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprRevendedorCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdRevendedor", idRevendedor);
            _cmd.Parameters.AddWithValue("@sprstrNome", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", string.Empty);
            _cmd.Parameters.AddWithValue("@strintNumero", 0);
            _cmd.Parameters.AddWithValue("@sprstrBairro", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCidade", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEstado", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCep", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrTelefone", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCelular", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrFax", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEmail", string.Empty);
            _con.Open();

            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENRevendedor NewObj = new ENRevendedor();
                    NewObj.IdRevendedor = Convert.ToInt32(rd[0].ToString());
                    NewObj.StrNome = rd[1].ToString();
                    NewObj.StrEndereco = rd[2].ToString();
                    NewObj.IntNumero = Convert.ToInt32(rd[3].ToString());
                    NewObj.StrBairro = rd[4].ToString();
                    NewObj.StrCidade = rd[5].ToString();
                    NewObj.StrEstado = rd[6].ToString();
                    NewObj.StrCep = rd[7].ToString();
                    NewObj.StrTelefone = rd[8].ToString();
                    NewObj.StrCelular = rd[9].ToString();
                    NewObj.StrFax = rd[10].ToString();
                    NewObj.StrEmail = rd[11].ToString();
                    _objs.Add(NewObj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                rd.Close();
            }
            return _objs;
        }

        /// <summary>
        /// Atualiza um registro de Revendedor
        /// </summary>
        /// <param name="Obj">ENRevendedor</param>
        public void UpdateRevendedor(ENRevendedor Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprRevendedorCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdRevendedor", Obj.IdRevendedor);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", Obj.StrEndereco);
            _cmd.Parameters.AddWithValue("@strintNumero", Obj.IntNumero);
            _cmd.Parameters.AddWithValue("@sprstrBairro", Obj.StrBairro);
            _cmd.Parameters.AddWithValue("@sprstrCidade", Obj.StrCidade);
            _cmd.Parameters.AddWithValue("@sprstrEstado", Obj.StrEstado);
            _cmd.Parameters.AddWithValue("@sprstrCep", Obj.StrCep);
            _cmd.Parameters.AddWithValue("@sprstrTelefone", Obj.StrTelefone);
            _cmd.Parameters.AddWithValue("@sprstrCelular", Obj.StrCelular);
            _cmd.Parameters.AddWithValue("@sprstrFax", Obj.StrFax);
            _cmd.Parameters.AddWithValue("@sprstrEmail", Obj.StrEmail);
            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }
        }

        /// <summary>
        /// Cria um Revendedor.
        /// </summary>
        /// <param name="Obj">ENRevendedor</param>
        public void CreateRevendedor(ENRevendedor Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprRevendedorCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdRevendedor", Obj.IdRevendedor);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", Obj.StrEndereco);
            _cmd.Parameters.AddWithValue("@strintNumero", Obj.IntNumero);
            _cmd.Parameters.AddWithValue("@sprstrBairro", Obj.StrBairro);
            _cmd.Parameters.AddWithValue("@sprstrCidade", Obj.StrCidade);
            _cmd.Parameters.AddWithValue("@sprstrEstado", Obj.StrEstado);
            _cmd.Parameters.AddWithValue("@sprstrCep", Obj.StrCep);
            _cmd.Parameters.AddWithValue("@sprstrTelefone", Obj.StrTelefone);
            _cmd.Parameters.AddWithValue("@sprstrCelular", Obj.StrCelular);
            _cmd.Parameters.AddWithValue("@sprstrFax", Obj.StrFax);
            _cmd.Parameters.AddWithValue("@sprstrEmail", Obj.StrEmail);

            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }
        }

        /// <summary>
        /// Cria um registro na tabela Caixa(tblCaixa).
        /// </summary>
        /// <param name="Obj">Objeto Caixa</param>
        public void DeleteRevendedor(ENRevendedor Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprRevendedorCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdRevendedor", Obj.IdRevendedor);
            _cmd.Parameters.AddWithValue("@sprstrNome", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", string.Empty);
            _cmd.Parameters.AddWithValue("@strintNumero", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrBairro", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCidade", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEstado", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCep", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrTelefone", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCelular", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrFax", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEmail", string.Empty);
            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }
        }
    }
}
