using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Access
{
    public class DAProduto
    {
        /// <summary>
        /// Seleciona uma lista de Logins de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Logins</returns>
        public List<ENProduto> Read(int EspecificoR, string idProduto, int idTipoProduto, int idRevendedor)
        {
            List<ENProduto> _objs = new List<ENProduto>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprProdutoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", idProduto);
            _cmd.Parameters.AddWithValue("@sprintIdTipoProduto", idTipoProduto);
            _cmd.Parameters.AddWithValue("@sprintIdRevendedor", idRevendedor);
            _cmd.Parameters.AddWithValue("@sprstrNome", string.Empty);
            _cmd.Parameters.AddWithValue("@sprdteCadastro", DateTime.Now);
            _cmd.Parameters.AddWithValue("@sprfltValor", 0);
            
            _con.Open();
            
            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENProduto NewObj = new ENProduto();
                    NewObj.IdProduto = rd[0].ToString();
                    NewObj.IdTipoProduto = Convert.ToInt32(rd[1].ToString());
                    NewObj.IdRevendedor = Convert.ToInt32(rd[2].ToString());
                    NewObj.StrNome = rd[3].ToString();
                    NewObj.DteDataCadastro = Convert.ToDateTime(rd[4].ToString());
                    NewObj.FltValor = float.Parse(rd[5].ToString());
                    _objs.Add(NewObj);
                }
            }
            finally
            {
                rd.Close();
            }
            return _objs;
        }

        /// <summary>
        /// Seleciona uma lista de Logins de acordo com os parâmetros e retorna um DataTable
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Logins</returns>
        public DataSet ReadIdProduto(int EspecificoR, string idProduto, int idTipoProduto, int idRevendedor)
        {
            DataSet ds = new DataSet();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);

            string sqlQuery = @"select * from tblProduto where id_Produto = @IdProduto";
            
            SqlCommand _cmd = new SqlCommand(sqlQuery, _con);
            _cmd.Parameters.AddWithValue("IdProduto", idProduto);
            SqlDataAdapter da = new SqlDataAdapter(_cmd);
            
            try
            {
                _con.Open();
                da.Fill(ds);
                //while (rd.Read())
                //{
                //    ENProduto NewObj = new ENProduto();
                //    NewObj.IdProduto = rd[0].ToString();
                //    NewObj.IdTipoProduto = Convert.ToInt32(rd[1].ToString());
                //    NewObj.IdRevendedor = Convert.ToInt32(rd[2].ToString());
                //    NewObj.StrNome = rd[3].ToString();
                //    NewObj.DteDataCadastro = Convert.ToDateTime(rd[4].ToString());
                //    NewObj.FltValor = float.Parse(rd[5].ToString());
                //    _objs.Add(NewObj);
                //}
            }catch(Exception ex)
            {
                throw ex;
            }

            return ds;
        }

        /// <summary>
        /// Atualiza um registro da tabela Produto.
        /// </summary>
        /// <param name="Obj">Entidade Produto</param>
        public void Update(ENProduto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprProdutoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", Obj.IdProduto);
            _cmd.Parameters.AddWithValue("@sprintIdTipoProduto", Obj.IdTipoProduto);
            _cmd.Parameters.AddWithValue("@sprintIdRevendedor", Obj.IdRevendedor);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprdteCadastro", Obj.DteDataCadastro);
            _cmd.Parameters.AddWithValue("@sprfltValor", Obj.FltValor);
            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            finally
            {
                _con.Close();
            }
        }

        /// <summary>
        /// Cria um registro na tabela Produto(tblProduto).
        /// </summary>
        /// <param name="Obj">Objeto Produto</param>
        public void Create(ENProduto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprProdutoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", Obj.IdProduto.ToString());
            _cmd.Parameters.AddWithValue("@sprintIdTipoProduto", Obj.IdTipoProduto);
            _cmd.Parameters.AddWithValue("@sprintIdRevendedor", Obj.IdRevendedor);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprdteCadastro", Obj.DteDataCadastro);
            _cmd.Parameters.AddWithValue("@sprfltValor", Obj.FltValor);
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
        /// Apaga um registro da tabela Produto(tblProduto).
        /// </summary>
        /// <param name="Obj">Objeto Produto</param>
        public void Delete(ENProduto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprProdutoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", Obj.IdProduto);
            _cmd.Parameters.AddWithValue("@sprintIdTipoProduto", Obj.IdTipoProduto);
            _cmd.Parameters.AddWithValue("@sprintIdRevendedor", Obj.IdRevendedor);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprdteCadastro", Obj.DteDataCadastro);
            _cmd.Parameters.AddWithValue("@sprfltValor", Obj.FltValor);
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
    }
}
