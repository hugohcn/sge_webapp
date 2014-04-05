using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace Access
{
    public class DASaldoCarteira
    {
        /// <summary>
        /// Seleciona todas as carteiras quitadas.
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Carteiras</returns>
        public List<ENSaldoCarteira> ReadSaldoCarteira(int EspecificoR, int idSaldoCarteira, int idCarteira, DateTime dteBaixa)
        {
            List<ENSaldoCarteira> _objs = new List<ENSaldoCarteira>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprSaldoCarteiraCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdSaldoCarteira", idSaldoCarteira);
            _cmd.Parameters.AddWithValue("@sprintIdCarteira", idCarteira);
            _cmd.Parameters.AddWithValue("@sprdteBaixa", dteBaixa);
            _cmd.Parameters.AddWithValue("@sprfltValorPago", 0);
            _con.Open();

            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENSaldoCarteira NewObj = new ENSaldoCarteira();
                    NewObj.IdSaldoCarteira = Convert.ToInt32(rd[0].ToString());
                    NewObj.IdCarteira = Convert.ToInt32(rd[1].ToString());
                    NewObj.DteBaixa = Convert.ToDateTime(rd[2].ToString());
                    NewObj.ValorPago = float.Parse(rd[3].ToString());
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
        /// Atualiza um registro do Saldo Carteira.
        /// </summary>
        /// <param name="Obj">Entidade Saldo Carteira</param>
        public void UpdateSaldoCarteira(ENSaldoCarteira Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprSaldoCarteiraCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdSaldoCarteira", Obj.IdSaldoCarteira);
            _cmd.Parameters.AddWithValue("@sprintIdCarteira", Obj.IdCarteira);
            _cmd.Parameters.AddWithValue("@sprdteBaixa", Obj.DteBaixa);
            _cmd.Parameters.AddWithValue("@sprfltValorPago", Obj.ValorPago);
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
        /// Cria um registro na tabela Saldo da Carteira
        /// </summary>
        /// <param name="Obj">Objeto Caixa</param>
        public void CreateSaldoCarteira(ENSaldoCarteira Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprSaldoCarteiraCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdSaldoCarteira", Obj.IdSaldoCarteira);
            _cmd.Parameters.AddWithValue("@sprintIdCarteira", Obj.IdCarteira);
            _cmd.Parameters.AddWithValue("@sprdteBaixa", Obj.DteBaixa);
            _cmd.Parameters.AddWithValue("@sprfltValorPago", Obj.ValorPago);

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
        /// Deleta um registro na tabela de Saldo da Carteira.
        /// </summary>
        /// <param name="Obj">Objeto Caixa</param>
        public void DeleteSaldoCarteira(ENSaldoCarteira Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprSaldoCarteiraCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdSaldoCarteira", Obj.IdSaldoCarteira);
            _cmd.Parameters.AddWithValue("@sprintIdCarteira", Obj.IdCarteira);
            _cmd.Parameters.AddWithValue("@sprdteBaixa", Obj.DteBaixa);
            _cmd.Parameters.AddWithValue("@sprfltValorPago", Obj.ValorPago);

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
