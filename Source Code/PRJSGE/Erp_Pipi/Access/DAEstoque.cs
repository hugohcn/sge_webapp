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
    public class DAEstoque
    {
        /// <summary>
        /// Seleciona o Estoque de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Estoque</returns>
        public List<ENEstoque> Read(int EspecificoR, string idProduto, DateTime dtEntrada)
        {
            List<ENEstoque> _objs = new List<ENEstoque>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprEstoqueCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", idProduto);
            _cmd.Parameters.AddWithValue("@sprdteEntrada", dtEntrada);
            _cmd.Parameters.AddWithValue("@sprintQuantidadeEntrada", 0);
            _cmd.Parameters.AddWithValue("@sprintQuantidadeVendida", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorCustoUnitario", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorVendaUnitario", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorTotalCusto", 0);
            _cmd.Parameters.AddWithValue("@sprfltValorTotalVenda", 0);
            _con.Open();
            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENEstoque NewObj = new ENEstoque();

                    NewObj.IdProduto = rd[0].ToString();
                    NewObj.Entrada = Convert.ToDateTime(rd[1].ToString());
                    NewObj.QuantidadeEntrada = Convert.ToInt32(rd[2].ToString());
                    NewObj.QuantidadeVendida = Convert.ToInt32(rd[3].ToString());
                    NewObj.ValorCustoUnitario = float.Parse(rd[4].ToString());
                    NewObj.ValorVendaUnitario = float.Parse(rd[5].ToString());
                    NewObj.ValorTotalCusto = float.Parse(rd[6].ToString());
                    NewObj.ValorTotalVenda = float.Parse(rd[7].ToString());
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
        /// Atualiza um registro do Estoque.
        /// </summary>
        /// <param name="Obj">Entidade Estoque</param>
        public void Update(ENEstoque Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprEstoqueCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", Obj.IdProduto);
            _cmd.Parameters.AddWithValue("@sprdteEntrada", Obj.Entrada);
            _cmd.Parameters.AddWithValue("@sprintQuantidadeEntrada", Obj.QuantidadeEntrada);
            _cmd.Parameters.AddWithValue("@sprintQuantidadeVendida", Obj.QuantidadeVendida);
            _cmd.Parameters.AddWithValue("@sprfltValorCustoUnitario", Obj.ValorCustoUnitario);
            _cmd.Parameters.AddWithValue("@sprfltValorVendaUnitario", Obj.ValorVendaUnitario);
            _cmd.Parameters.AddWithValue("@sprfltValorTotalCusto", Obj.ValorTotalCusto);
            _cmd.Parameters.AddWithValue("@sprfltValorTotalVenda", Obj.ValorTotalVenda);

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
        /// Cria um registro na tabela Estoque(tblEstoque).
        /// </summary>
        /// <param name="Obj">Objeto Estoque</param>
        public void Create(ENEstoque Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprEstoqueCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", Obj.IdProduto);
            _cmd.Parameters.AddWithValue("@sprdteEntrada", Obj.Entrada);
            _cmd.Parameters.AddWithValue("@sprintQuantidadeEntrada", Obj.QuantidadeEntrada);
            _cmd.Parameters.AddWithValue("@sprintQuantidadeVendida", Obj.QuantidadeVendida);
            _cmd.Parameters.AddWithValue("@sprfltValorCustoUnitario", Obj.ValorCustoUnitario);
            _cmd.Parameters.AddWithValue("@sprfltValorVendaUnitario", Obj.ValorVendaUnitario);
            _cmd.Parameters.AddWithValue("@sprfltValorTotalCusto", Obj.ValorTotalCusto);
            _cmd.Parameters.AddWithValue("@sprfltValorTotalVenda", Obj.ValorTotalVenda);
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
        /// Deleta um Produto da tabela Estoque(tblEstoque).
        /// </summary>
        /// <param name="Obj">Objeto Cliente</param>
        public void Delete(ENEstoque Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprEstoqueCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", Obj.IdProduto);
            _cmd.Parameters.AddWithValue("@sprdteEntrada", Obj.Entrada);
            _cmd.Parameters.AddWithValue("@sprintQuantidadeEntrada", Obj.QuantidadeEntrada);
            _cmd.Parameters.AddWithValue("@sprintQuantidadeVendida", Obj.QuantidadeVendida);
            _cmd.Parameters.AddWithValue("@sprfltValorCustoUnitario", Obj.ValorCustoUnitario);
            _cmd.Parameters.AddWithValue("@sprfltValorVendaUnitario", Obj.ValorVendaUnitario);
            _cmd.Parameters.AddWithValue("@sprfltValorTotalCusto", Obj.ValorTotalCusto);
            _cmd.Parameters.AddWithValue("@sprfltValorTotalVenda", Obj.ValorTotalVenda);

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
        public DataTable RetornaRelatorio(string codProduto)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("", ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
                string sql = @"  SELECT TBLPRODUTO.STRNOME, TBLESTOQUE.ID_PRODUTO, TBLESTOQUE.DTEENTRADA, TBLESTOQUE.INTQUANTIDADEENTRADA, 
                                                            TBLESTOQUE.INTQUANTIDADEVENDIDA, TBLESTOQUE.FLTVALORCUSTOUNITARIO, TBLESTOQUE.FLTVALORVENDAUNITARIO, 
                                                            TBLESTOQUE.VALORTOTALCUSTO, TBLESTOQUE.VALORTOTALVENDA
                                                            FROM TBLESTOQUE INNER JOIN
                                                            TBLPRODUTO ON TBLESTOQUE.ID_PRODUTO = TBLPRODUTO.ID_PRODUTO ";

                SqlCommand selectCommand = new SqlCommand(sql);

                if (!string.IsNullOrEmpty(codProduto))
                {
                    sql += @"WHERE TBLESTOQUE.ID_PRODUTO = @codProduto ";
                    selectCommand.Parameters.AddWithValue("@codProduto", codProduto);
                }

                selectCommand.CommandText = sql;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
                
                selectCommand.Connection = con;
                adp.SelectCommand = selectCommand;
                
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

    public class DACalculoEstoque
    {
        /// <summary>
        /// Calcula os possíveis parâmetros de contas do estoque.
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Estoque</returns>
        public DataTable Read()
        {
            DataTable dtCalculos = null;
            try
            {
                
                string sqlQuery = @"SELECT
	                                count(TBLESTOQUE.ID_PRODUTO) as 'ITENS CADASTRADOS NO ESTOQUE',
	                                sum(FLTVALORCUSTOUNITARIO)* sum(INTQUANTIDADEENTRADA) - sum(INTQUANTIDADEVENDIDA) as 'CUSTO TOTAL DO ESTOQUE',
	                                sum(FLTVALORVENDAUNITARIO)* sum(INTQUANTIDADEENTRADA) - sum(INTQUANTIDADEVENDIDA) as 'VALOR VENDA TOTAL ESTOQUE',
	                                min(DTEENTRADA) as 'DATA DE ENTRADA DO PRIMEIRO PRODUTO',
	                                max(DTEENTRADA) as 'DATA DE ENTRADA DO ULTIMO PRODUTO',
	                                sum(INTQUANTIDADEENTRADA) as 'TOTAL DE PRODUTOS DE ENTRADA',
	                                sum(INTQUANTIDADEVENDIDA) as 'TOTAL DE PRODUTOS VENDIDOS',
	                                (sum(INTQUANTIDADEENTRADA)) - (sum(INTQUANTIDADEVENDIDA)) as 'QUANTIDADE EXISTENTE EM ESTOQUE',
	                                sum(FLTVALORVENDAUNITARIO)* sum(INTQUANTIDADEENTRADA) - sum(INTQUANTIDADEVENDIDA) - sum(FLTVALORCUSTOUNITARIO)* sum(INTQUANTIDADEENTRADA) - sum(INTQUANTIDADEVENDIDA) as 'LUCRO TOTAL DO ESTOQUE'
                                    FROM TBLESTOQUE";
                SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
                SqlCommand _cmd = new SqlCommand();
                _cmd.CommandText = sqlQuery;

                SqlDataAdapter da = new SqlDataAdapter(_cmd);
                _con.Open();
                da.Fill(dtCalculos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCalculos;
        }
    }
}
