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
    public class DATipoCusto
    {
        /// <summary>
        /// Seleciona uma lista de tipos de Custos.
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Tipos de Custo</returns>
        public List<ENTipoCusto> Read(int EspecificoR, int idTipoCusto, string strNome)
        {
            List<ENTipoCusto> _objs = new List<ENTipoCusto>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoCustoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdTipoCusto", idTipoCusto);
            _cmd.Parameters.AddWithValue("@sprstrNome", strNome);
            _con.Open();

            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENTipoCusto NewObj = new ENTipoCusto();
                    NewObj.IdTipoCusto = Convert.ToInt32(rd[0].ToString());
                    NewObj.StrNome = rd[1].ToString();
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
        /// Atualiza um registro de Tipo de Custo
        /// </summary>
        /// <param name="Obj">Entidade Caixa</param>
        public void UpdateTipoCusto(ENTipoCusto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoCustoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdTipoCusto", Obj.IdTipoCusto);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
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
        /// Cria um registro Tipo de Custo
        /// </summary>
        /// <param name="Obj">Objeto Caixa</param>
        public void CreateTipoCusto(ENTipoCusto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoCustoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdTipoCusto", Obj.IdTipoCusto);
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
        /// Deleta um tipo de Custo.
        /// </summary>
        /// <param name="Obj">Objeto Caixa</param>
        public void DeleteTipoCusto(ENTipoCusto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoCustoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdTipoCusto", Obj.IdTipoCusto);
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
    }
}
