using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;
using System.Data.SqlClient;
using System.Data;

namespace Business
{
    public class BUVenda
    {
        
        /// <summary>
        /// Retorna a última venda.
        /// </summary>
        /// <returns>ENVenda</returns>
        public int GetLastVenda()
        {

            return (new DAVenda()).GetLastSell();
        }

        /// <summary>
        /// Retorna todas as vendas pela data.
        /// </summary>
        /// <returns>ENVenda</returns>
        public List<ENVenda> GetAllVendasByData(DateTime dtVenda)
        {
            return (new DAVenda()).Read(4, 0, 0, dtVenda);
        }

        /// <summary>
        /// Retorna todas as Vendas.
        /// </summary>
        /// <returns>ENVenda</returns>
        public List<ENVenda> GetAllVendas()
        {
            return (new DAVenda()).Read(2, 0, 0, DateTime.Now.Date);
        }

        /// <summary>
        /// Seleciona uma venda pelo ID.
        /// </summary>
        /// <param name="FaixaSalarial">int idFavorito</param>
        /// <returns>ENVenda</returns>
        public List<ENVenda> GetVendaById(int idVenda)
        {
            return (new DAVenda()).Read(1, idVenda, 0, DateTime.Now.Date);
        }

        /// <summary>
        /// Seleciona uma venda pelo ID do Carrinho.
        /// </summary>
        /// <param name="FaixaSalarial">int idFuncionario</param>
        /// <returns>ENVenda</returns>
        public List<ENVenda> GetVendaByIdAndIdCarrinho(int idVenda, int idCarrinho)
        {
            return (new DAVenda()).Read(3, idVenda, idCarrinho, DateTime.Now.Date);
        }

        /// <summary>
        /// Atualiza uma Venda.
        /// </summary>
        /// <param name="Obj">ENVenda Obj</param>
        public void UpdateVenda(ENVenda Obj)
        {
            (new DAVenda()).Update(Obj);
        }

        /// <summary>
        /// Cria uma nova Venda.
        /// </summary>
        /// <param name="Obj">ENVenda Obj</param>
        public void CreateVenda(ENVenda Obj)
        {
            (new DAVenda()).Create(Obj);
        }

        /// <summary>
        /// Apaga uma Venda.
        /// </summary>
        /// <param name="Obj">ENVenda Obj</param>
        public void DeleteVenda(ENVenda Obj)
        {
            try
            {
                Obj.DteVenda = DateTime.Now;
                (new DAVenda()).Delete(Obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Retorna um DataSet.
        /// Caso seja sem data, os dados de vendas serão dos dias atuais.
        /// </summary>
        /// <param name="Obj">ENVenda Obj</param>
        public DataTable RetornaRelatorio(DateTime dtInicial, DateTime dtFinal)
        {
            try
            {
                return (new DAVenda()).RetornaRelatorio(dtInicial, dtFinal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna um DataSet.
        /// </summary>
        /// <param name="Obj">ENVenda Obj</param>
        public DataTable RetornaRelatorioProdutosVendaDia(DateTime dtInicial, DateTime dtFinal)
        {
            try
            {
                return (new DAVenda()).RetornaRelatorioVendaDia(dtInicial, dtFinal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna um DataSet.
        /// </summary>
        /// <param name="Obj">ENVenda Obj</param>
        public DataTable RetornaRelatorioProdutosVendaDiaByProduto(DateTime dtInicial, DateTime dtFinal, string idProduto)
        {
            try
            {
                return (new DAVenda()).RetornaRelatorioVendaDiaByProduto(dtInicial, dtFinal, idProduto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
