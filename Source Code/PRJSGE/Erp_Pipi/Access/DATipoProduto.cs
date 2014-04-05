using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Access
{
    public class DATipoProduto
    {
        /// <summary>
        /// Seleciona uma lista de Tipos de produto de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Tipos de Produto</returns>
        public List<ENTipoProduto> Read(int EspecificoR, int idTipoProduto)
        {
            List<ENTipoProduto> _objs = new List<ENTipoProduto>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoProdutoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdTipoProduto", idTipoProduto);
            _cmd.Parameters.AddWithValue("@sprstrNome", string.Empty);

            _con.Open();
            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENTipoProduto NewObj = new ENTipoProduto();
                    NewObj.IdTipoProduto = Convert.ToInt32(rd[0].ToString());
                    NewObj.StrNome = rd[1].ToString();
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
        /// Atualiza um Tipo de Produto
        /// </summary>
        /// <param name="Obj">Entidade TipoProduto</param>
        public void Update(ENTipoProduto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoProdutoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdTipoProduto", Obj.IdTipoProduto);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
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
        /// Cria um registro de Tipo Produto
        /// </summary>
        /// <param name="Obj">Objeto TipoProduto</param>
        public void Create(ENTipoProduto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoProdutoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdTipoProduto", Obj.IdTipoProduto);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
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
        /// Apaga um Tipo de Produto.
        /// </summary>
        /// <param name="Obj">Objeto TipoProduto</param>
        public void Delete(ENTipoProduto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoProdutoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdTipoProduto", Obj.IdTipoProduto);
            _cmd.Parameters.AddWithValue("@sprstrNome", string.Empty);
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
