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
    public class DACustos
    {
        /// <summary>
        /// Seleciona todos os custos do banco.
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Custos</returns>
        public List<ENCusto> Read(int EspecificoR, int idCusto, int idTipoCusto, DateTime dteCusto, float fltValor)
        {
            List<ENCusto> _objs = new List<ENCusto>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCustoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdCusto", idCusto);
            _cmd.Parameters.AddWithValue("@sprintIdTipoCusto", idTipoCusto);
            _cmd.Parameters.AddWithValue("@sprstrDescricao", string.Empty);
            _cmd.Parameters.AddWithValue("@sprdteDataCusto", dteCusto);
            _cmd.Parameters.AddWithValue("@sprfltValorCusto", fltValor);
            _con.Open();
            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            {
                while (rd.Read())
                {
                    ENCusto NewObj = new ENCusto();

                    NewObj.IdCusto = Convert.ToInt32(rd[0].ToString());
                    NewObj.IdTipoCusto = Convert.ToInt32(rd[1].ToString());
                    NewObj.StrDescricao = rd[2].ToString();
                    NewObj.DteDataCusto = Convert.ToDateTime(rd[3].ToString());
                    NewObj.FltValorCusto = float.Parse(rd[4].ToString());

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
        /// Atualiza um Custo.
        /// </summary>
        /// <param name="Obj">Entidade Custo</param>
        public void UpdateCusto(ENCusto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCustoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCusto", Obj.IdCusto);
            _cmd.Parameters.AddWithValue("@sprintIdTipoCusto", Obj.IdTipoCusto);
            _cmd.Parameters.AddWithValue("@sprstrDescricao", Obj.StrDescricao);
            _cmd.Parameters.AddWithValue("@sprdteDataCusto", Obj.DteDataCusto);
            _cmd.Parameters.AddWithValue("@sprfltValorCusto", Obj.FltValorCusto);
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
        /// Cria um Custo.
        /// </summary>
        /// <param name="Obj">Objeto Custo</param>
        public void CreateCusto(ENCusto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCustoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCusto", Obj.IdCusto);
            _cmd.Parameters.AddWithValue("@sprintIdTipoCusto", Obj.IdTipoCusto);
            _cmd.Parameters.AddWithValue("@sprstrDescricao", Obj.StrDescricao);
            _cmd.Parameters.AddWithValue("@sprdteDataCusto", Obj.DteDataCusto);
            _cmd.Parameters.AddWithValue("@sprfltValorCusto", Obj.FltValorCusto);
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
        /// Deleta um Custo.
        /// </summary>
        /// <param name="Obj">Objeto Custo</param>
        public void DeleteCusto(ENCusto Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprCustoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCusto", Obj.IdCusto);
            _cmd.Parameters.AddWithValue("@sprintIdTipoCusto", Obj.IdTipoCusto);
            _cmd.Parameters.AddWithValue("@sprstrDescricao", Obj.StrDescricao);
            _cmd.Parameters.AddWithValue("@sprdteDataCusto", Obj.DteDataCusto);
            _cmd.Parameters.AddWithValue("@sprfltValorCusto", Obj.FltValorCusto);

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
