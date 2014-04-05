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
    public class DACarteira
    {
        /// <summary>
        /// Seleciona uma lista de Carteiras de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Carteiras</returns>
        public List<ENCarteira> Read(int EspecificoR, int idCarteira, int idCliente)
        {
            List<ENCarteira> _objs = new List<ENCarteira>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCarteiraCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdCarteira", idCarteira);
            _cmd.Parameters.AddWithValue("@sprintIdCliente", idCliente);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", 0);
            _cmd.Parameters.AddWithValue("@sprdteDataPagamento", DateTime.Now);
            _cmd.Parameters.AddWithValue("@sprfltValorCredito", 0);
            _cmd.Parameters.AddWithValue("@sprbitStatusCarteira", 0);
            _con.Open();

            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENCarteira NewObj = new ENCarteira();
                    NewObj.IdCarteira = Convert.ToInt32(rd[0].ToString());
                    NewObj.IdCliente = Convert.ToInt32(rd[1].ToString());
                    NewObj.FltValorTotal = float.Parse(rd[2].ToString());
                    NewObj.DteDataPagamento = Convert.ToDateTime(rd[3].ToString());
                    NewObj.FltValorCredito = float.Parse(rd[4].ToString());
                    NewObj.BitStatusCarteira = bool.Parse(rd[5].ToString());
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
        /// Atualiza um registro da Carteira
        /// </summary>
        /// <param name="Obj">Entidade Carteira</param>
        public void Update(ENCarteira Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCarteiraCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCarteira", Obj.IdCarteira);
            _cmd.Parameters.AddWithValue("@sprintIdCliente", Obj.IdCliente);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", Obj.FltValorTotal);
            _cmd.Parameters.AddWithValue("@sprdteDataPagamento", Obj.DteDataPagamento);
            _cmd.Parameters.AddWithValue("@sprfltValorCredito", Obj.FltValorCredito);
            _cmd.Parameters.AddWithValue("@sprbitStatusCarteira", Obj.BitStatusCarteira);
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
        /// Executa baixa um registro da Carteira
        /// </summary>
        /// <param name="Obj">Entidade Carteira</param>
        public void EfetuarBaixa(ENCarteira Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCarteiraCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCarteira", Obj.IdCarteira);
            _cmd.Parameters.AddWithValue("@sprintIdCliente", Obj.IdCliente);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", Obj.FltValorTotal);
            _cmd.Parameters.AddWithValue("@sprdteDataPagamento", Obj.DteDataPagamento);
            _cmd.Parameters.AddWithValue("@sprfltValorCredito", Obj.FltValorCredito);
            _cmd.Parameters.AddWithValue("@sprbitStatusCarteira", Obj.BitStatusCarteira);
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
        /// Cria um registro na tabela Carteira(tblCarteira).
        /// </summary>
        /// <param name="Obj">Objeto Carteira</param>
        public void Create(ENCarteira Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCarteiraCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCarteira", Obj.IdCarteira);
            _cmd.Parameters.AddWithValue("@sprintIdCliente", Obj.IdCliente);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", Obj.FltValorTotal);
            _cmd.Parameters.AddWithValue("@sprdteDataPagamento", Obj.DteDataPagamento);
            _cmd.Parameters.AddWithValue("@sprfltValorCredito", Obj.FltValorCredito);
            _cmd.Parameters.AddWithValue("@sprbitStatusCarteira", Obj.BitStatusCarteira);

            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _con.Close();
            }
        }

        /// <summary>
        /// Apaga uma Carteira da tabela tblCarteira.
        /// Para apagar a Carteira o cliente precisa estar desvinculado do sistema. (Deletado)
        /// </summary>
        /// <param name="Obj">Objeto Carteira</param>
        public void Delete(ENCarteira Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCarteiraCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCarteira", Obj.IdCarteira);
            _cmd.Parameters.AddWithValue("@sprintIdCliente", Obj.IdCliente);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", Obj.FltValorTotal);
            _cmd.Parameters.AddWithValue("@sprdteDataPagamento", DateTime.Now);
            _cmd.Parameters.AddWithValue("@sprfltValorCredito", Obj.FltValorCredito);
            _cmd.Parameters.AddWithValue("@sprbitStatusCarteira", Obj.BitStatusCarteira);

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
