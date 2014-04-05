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
    public class DAVenda
    {
        /// <summary>
        /// Retorna a última venda efetuada.
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Vendas</returns>
        public int GetLastSell()
        {
            int ultimoId = 0;
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprVendaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 3);
            _cmd.Parameters.AddWithValue("@sprintIdVenda", 0);
            _cmd.Parameters.AddWithValue("@sprintIdItemCarrinho", 0);
            _cmd.Parameters.AddWithValue("@sprintIdTipoPagamento", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorDesconto", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", 0);
            _cmd.Parameters.AddWithValue("@sprbitStatusVenda", 0);
            _cmd.Parameters.AddWithValue("@sprdteVenda", DateTime.Now.Date);

            _con.Open();

            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ultimoId = Convert.ToInt32(rd[0].ToString());
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

            return ultimoId;
        }


        /// <summary>
        /// Seleciona uma lista de Vendas de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Vendas</returns>
        public List<ENVenda> Read(int EspecificoR, int idVenda, int idItemCarrinho, DateTime dtVenda)
        {
            List<ENVenda> _objs = new List<ENVenda>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprVendaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdVenda", idVenda);
            _cmd.Parameters.AddWithValue("@sprintIdItemCarrinho", idItemCarrinho);
            _cmd.Parameters.AddWithValue("@sprintIdTipoPagamento", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorDesconto", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", 0);
            _cmd.Parameters.AddWithValue("@sprbitStatusVenda", 0);
            _cmd.Parameters.AddWithValue("@sprdteVenda", dtVenda);
            
            _con.Open();
            
            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENVenda NewObj = new ENVenda();
                    NewObj.IdVenda = Convert.ToInt32(rd[0].ToString());
                    NewObj.IdItemCarrinho= Convert.ToInt32(rd[1].ToString());
                    NewObj.TipoPagamento = Convert.ToInt32(rd[1].ToString());
                    NewObj.FltValorDesconto = float.Parse(rd[2].ToString());
                    NewObj.FltValorTotal = float.Parse(rd[3].ToString());
                    NewObj.BitStatusVenda = bool.Parse(rd[4].ToString());
                    NewObj.DteVenda = Convert.ToDateTime(rd[5].ToString());
                    
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
        /// Atualiza um registro do Venda
        /// </summary>
        /// <param name="Obj">Entidade Venda</param>
        public void Update(ENVenda Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprVendaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", string.Empty);
            _cmd.Parameters.AddWithValue("@sprintIdVenda", Obj.IdVenda);
            _cmd.Parameters.AddWithValue("@sprintIdItemCarrinho", Obj.IdItemCarrinho);
            _cmd.Parameters.AddWithValue("@sprintIdTipoPagamento", Obj.TipoPagamento);
            _cmd.Parameters.AddWithValue("@sprfltValorDesconto", Obj.FltValorDesconto);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", Obj.FltValorTotal);
            _cmd.Parameters.AddWithValue("@sprbitStatusVenda", Obj.BitStatusVenda);
            _cmd.Parameters.AddWithValue("@sprdteVenda", Obj.DteVenda);
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
        /// Cria um registro de Venda
        /// </summary>
        /// <param name="Obj">Objeto Venda</param>
        public void Create(ENVenda Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprVendaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdVenda", Obj.IdVenda);
            _cmd.Parameters.AddWithValue("@sprintIdItemCarrinho", Obj.IdItemCarrinho);
            _cmd.Parameters.AddWithValue("@sprintIdTipoPagamento", Obj.TipoPagamento);
            _cmd.Parameters.AddWithValue("@sprfltValorDesconto", Obj.FltValorDesconto);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", Obj.FltValorTotal);
            _cmd.Parameters.AddWithValue("@sprbitStatusVenda", Obj.BitStatusVenda);
            _cmd.Parameters.AddWithValue("@sprdteVenda", Obj.DteVenda);
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
        /// Apaga um registro de Venda
        /// </summary>
        /// <param name="Obj">Objeto Venda</param>
        public void Delete(ENVenda Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprVendaCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdVenda", Obj.IdVenda);
            _cmd.Parameters.AddWithValue("@sprintIdItemCarrinho", Obj.IdItemCarrinho);
            _cmd.Parameters.AddWithValue("@sprintIdTipoPagamento", Obj.TipoPagamento);
            _cmd.Parameters.AddWithValue("@sprfltValorDesconto", Obj.FltValorDesconto);
            _cmd.Parameters.AddWithValue("@sprfltValorTotal", Obj.FltValorTotal);
            _cmd.Parameters.AddWithValue("@sprbitStatusVenda", Obj.BitStatusVenda);
            _cmd.Parameters.AddWithValue("@sprdteVenda", Obj.DteVenda);
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
        /// Retorna SQL adapter para relatório de vendas com data escolhida.
        /// </summary>
        /// <param name="dtInicial"></param>
        /// <param name="dtFinal"></param>
        /// <returns></returns>
        public DataTable RetornaRelatorio(DateTime dtInicial, DateTime dtFinal)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(@"  SELECT TBLVENDA.ID_VENDA, TBLVENDA.ID_TIPOPAGAMENTO, TBLVENDA.FLTVALORDESCONTO,
                                                            TBLVENDA.FLTVALORTOTAL, TBLVENDA.BITSTATUSVENDA, TBLVENDA.DTEVENDA, 
                                                            TBLTIPOPAGAMENTO.STRNOME, TBLTIPOPAGAMENTO.ID_TIPOPAGAMENTO AS 'Id Pagamento'
                                                            FROM TBLVENDA, tblTipoPagamento
                                                            WHERE TBLVENDA.ID_TIPOPAGAMENTO = TBLTIPOPAGAMENTO.ID_TIPOPAGAMENTO
                                                            AND DTEVENDA BETWEEN @DataInicial AND @DataFinal",
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

        /// <summary>
        /// Retorna SQL adapter para relatório de vendas com data escolhida.
        /// </summary>
        /// <param name="dtInicial"></param>
        /// <param name="dtFinal"></param>
        /// <returns></returns>
        public DataTable RetornaRelatorioVendaDia(DateTime dtInicial, DateTime dtFinal)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(@"  
                                                            select sum(intQuantidade) as quantidade,(sum(fltValorTotal)) as 'total',
strNome as produto
from (
        SELECT  tblVenda.fltValorTotal,
                                                                            tblProduto.strNome,
                                                                            tblItemCarrinho.Id_Produto as idProduto,
                                                                            tblItemCarrinho.intQuantidade,
                                                                            tblVenda.dteVenda
	                                                                FROM tblItemCarrinho, tblVenda, tblProduto, tblEstoque
	                                                                WHERE tblVenda.DteVenda between @dtInicial and @dtFinal
	                                                                AND tblEstoque.id_produto = tblItemCarrinho.Id_Produto
	                                                                AND tblItemCarrinho.Id_Venda = tblVenda.Id_venda
	                                                                AND tblItemCarrinho.Id_produto = tblProduto.Id_produto) as tot
	                                                                GROUP BY strNome
                                                                    ORDER BY strNome", ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);

                adp.SelectCommand.Parameters.AddWithValue("@dtInicial", dtInicial.Date);
                adp.SelectCommand.Parameters.AddWithValue("@dtFinal", dtFinal.Date);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna SQL adapter para relatório de vendas com data escolhida.
        /// </summary>
        /// <param name="dtInicial"></param>
        /// <param name="dtFinal"></param>
        /// <returns></returns>
        public DataTable RetornaRelatorioVendaDiaByProduto(DateTime dtInicial, DateTime dtFinal, string idProduto)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(@"  
                                                            select sum(intQuantidade) as quantidade, (sum(fltvalorVendaUnitario)) as 'total',
                                                            strNome as produto
                                                            from (
	                                                                select tblEstoque.fltValorVendaUnitario, tblProduto.strNome, tblItemCarrinho.Id_Produto as idProduto,
                                                                    tblItemCarrinho.intQuantidade, tblVenda.dteVenda
	                                                                from tblItemCarrinho, tblVenda, tblProduto, tblEstoque
	                                                                where tblVenda.DteVenda between @dtInicial and @dtFinal
	                                                                and tblEstoque.id_produto = tblItemCarrinho.Id_Produto
	                                                                and tblItemCarrinho.Id_Venda = tblVenda.Id_venda
	                                                                and tblItemCarrinho.Id_produto = tblProduto.Id_produto
	                                                                and tblItemCarrinho.Id_produto = @idProduto) as tot
	                                                        group by strNome
	                                                        order by strNome", ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);

                adp.SelectCommand.Parameters.AddWithValue("@dtInicial", dtInicial.Date);
                adp.SelectCommand.Parameters.AddWithValue("@dtFinal", dtFinal.Date);
                adp.SelectCommand.Parameters.AddWithValue("@idProduto", idProduto);

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
