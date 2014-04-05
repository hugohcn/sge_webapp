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
    public class DATipoPagamento
    {
        /// <summary>
        /// Seleciona uma lista de Tipos de pagamentos de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Logins</returns>
        public List<ENTipoPagamento> Read(int EspecificoR, int idTipoPagamento)
        {
            List<ENTipoPagamento> _objs = new List<ENTipoPagamento>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoPagamentoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdTipoPagamento", idTipoPagamento);
            _cmd.Parameters.AddWithValue("@sprstrNome", string.Empty);
            
            _con.Open();            
            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENTipoPagamento NewObj = new ENTipoPagamento();
                    NewObj.IdTipoPagamento = Convert.ToInt32(rd[0].ToString());
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
        /// Atualiza um Tipo de Pagamento
        /// </summary>
        /// <param name="Obj">Entidade TipoPagamento</param>
        public void Update(ENTipoPagamento Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoPagamentoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", string.Empty);
            _cmd.Parameters.AddWithValue("@sprintIdTipoPagamento", Obj.IdTipoPagamento);
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
        /// Cria um registro de Tipo Pagamento
        /// </summary>
        /// <param name="Obj">Objeto TipoPagamento</param>
        public void Create(ENTipoPagamento Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoPagamentoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", string.Empty);
            _cmd.Parameters.AddWithValue("@sprintIdTipoPagamento", Obj.IdTipoPagamento);
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
        /// Apaga um Tipo de Pagamento.
        /// </summary>
        /// <param name="Obj">Objeto TipoPagamento</param>
        public void Delete(ENTipoPagamento Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprTipoPagamentoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0); 
            _cmd.Parameters.AddWithValue("@sprintIdTipoPagamento", Obj.IdTipoPagamento);
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
    }
}
