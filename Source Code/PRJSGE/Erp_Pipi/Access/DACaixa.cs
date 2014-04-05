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
    public class DACaixa
    {
        /// <summary>
        /// Retorna o último valor de transição em aberto.
        /// </summary>
        /// <param name="EspecificoR"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public List<ENCaixa> GetLastestTransitionValue(int EspecificoR, char status)
        {
            List<ENCaixa> cx = new List<ENCaixa>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCaixaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintDteCaixa", DateTime.Now.Date);
            _cmd.Parameters.AddWithValue("@sprfltValorAbertura", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorFechamento", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorTransicao", 0);
            _cmd.Parameters.AddWithValue("@sprbitStatus", status);
            _con.Open();

            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENCaixa NewObj = new ENCaixa();
                    NewObj.DataCaixa = Convert.ToDateTime(rd[0].ToString());
                    NewObj.FltValorAbertura = float.Parse(rd[1].ToString());
                    NewObj.FltValorFechamento = float.Parse(rd[2].ToString());
                    NewObj.FltValorTransicao = float.Parse(rd[3].ToString());
                    NewObj.BitStatus = char.Parse(rd[4].ToString());

                    cx.Add(NewObj);
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

            return cx;
        }


        /// <summary>
        /// Seleciona uma lista de Caixas de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Caixas</returns>
        public List<ENCaixa> Read(int EspecificoR, DateTime idCaixa)
        {
            List<ENCaixa> _objs = new List<ENCaixa>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCaixaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintDteCaixa", idCaixa.Date);
            _cmd.Parameters.AddWithValue("@sprfltValorAbertura", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorFechamento", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorTransicao", 0);
            _cmd.Parameters.AddWithValue("@sprbitStatus", '1');
            _con.Open();

            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENCaixa NewObj = new ENCaixa();
                    NewObj.DataCaixa = Convert.ToDateTime(rd[0].ToString());
                    NewObj.FltValorAbertura = float.Parse(rd[1].ToString());
                    NewObj.FltValorFechamento = float.Parse(rd[2].ToString());
                    NewObj.FltValorTransicao = float.Parse(rd[3].ToString());
                    NewObj.BitStatus = char.Parse(rd[4].ToString());

                    _objs.Add(NewObj);
                }
            }
            catch(Exception ex)
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
        /// Atualiza um registro de Caixa
        /// </summary>
        /// <param name="Obj">Entidade Caixa</param>
        public void Update(ENCaixa Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCaixaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintDteCaixa", Obj.DataCaixa);
            _cmd.Parameters.AddWithValue("@sprfltValorAbertura", Obj.FltValorAbertura);
            _cmd.Parameters.AddWithValue("@sprfltValorFechamento", Obj.FltValorFechamento);
            _cmd.Parameters.AddWithValue("@sprfltValorTransicao", Obj.FltValorTransicao);
            _cmd.Parameters.AddWithValue("@sprbitStatus", Obj.BitStatus);
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
        public void Create(ENCaixa Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCaixaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintDteCaixa", Obj.DataCaixa);
            _cmd.Parameters.AddWithValue("@sprfltValorAbertura", Obj.FltValorAbertura);
            _cmd.Parameters.AddWithValue("@sprfltValorFechamento", Obj.FltValorFechamento);
            _cmd.Parameters.AddWithValue("@sprfltValorTransicao", Obj.FltValorTransicao);
            _cmd.Parameters.AddWithValue("@sprbitStatus", Obj.BitStatus);

            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.InnerException != null)
                {
                    throw new Exception(sqlEx.InnerException.Message);
                }
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
        public void Delete(ENCaixa Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCaixaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintDteCaixa", Obj.DataCaixa);
            _cmd.Parameters.AddWithValue("@sprfltValorAbertura", Obj.FltValorAbertura);
            _cmd.Parameters.AddWithValue("@sprfltValorFechamento", Obj.FltValorFechamento);
            _cmd.Parameters.AddWithValue("@sprfltValorTransicao", Obj.FltValorTransicao);
            _cmd.Parameters.AddWithValue("@sprbitStatus", Obj.BitStatus);

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
        /// Retorna SQL adapter para relatório de vendas com data escolhida.
        /// </summary>
        /// <param name="dtInicial"></param>
        /// <param name="dtFinal"></param>
        /// <returns></returns>
        public DataTable RetornaRelatorio(DateTime dtInicial, DateTime dtFinal)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(@"  SELECT DTECAIXA, FLTVALORABERTURA, FLTVALORFECHAMENTO, FLTVALORTRANSICAO,
                                                            BITSTATUS
                                                            FROM TBLCAIXA 
                                                            WHERE DTECAIXA BETWEEN @DataInicial AND @DataFinal",
                    ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);

                adp.SelectCommand.Parameters.AddWithValue("@DataInicial", dtInicial.Date);
                adp.SelectCommand.Parameters.AddWithValue("@DataFinal", dtFinal.Date);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
