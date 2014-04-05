using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;
using System.Data;

namespace Business
{
    public class BUEstoque
    {
        /// <summary>
        /// Seleciona todos os Produtos do Estoque.
        /// </summary>
        /// <returns>ENEstoque</returns>
        public List<ENEstoque> GetAllProdutosFromEstoque()
        {
            return (new DAEstoque()).Read(2, string.Empty, DateTime.Now);
        }

        /// <summary>
        /// Seleciona os Produtos pelo ID.
        /// </summary>
        /// <returns>ENEstoque</returns>
        public ENEstoque GetProdutosByIdFromEstoque(string idProduto)
        {
            List<ENEstoque> lstProdutosEstoque = (new DAEstoque()).Read(1, idProduto, DateTime.Now);
            if (lstProdutosEstoque.Count != 0)
            {
                return lstProdutosEstoque[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Seleciona os Produtos do Estoque pela Quantidade em Estoque.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public List<ENEstoque> GetProdutosByDateFromEstoque(DateTime dtEntrada)
        {
            return (new DAEstoque()).Read(3, string.Empty, dtEntrada);
        }

        /// <summary>
        /// Atualiza uma Produto no Estoque
        /// </summary>
        /// <param name="Obj">ENEstoque Obj</param>
        public void UpdateProdutoFromEstoque(ENEstoque Obj)
        {
            (new DAEstoque()).Update(Obj);
        }

        /// <summary>
        /// Adiciona um novo Produto ao Estoque.
        /// </summary>
        /// <param name="Obj">ENEstoque Obj</param>
        public void AddProdutoOnEstoque(ENEstoque Obj)
        {
            ENProduto produto = (new BUProduto()).GetProdutoById(Obj.IdProduto);
            if (produto != null)
            {
                (new DAEstoque()).Create(Obj);
            }
            else
            {
                throw new Exception("Produto não cadastrado no sistema.");
            }
        }

        /// <summary>
        /// Deleta um Produto do Estoque
        /// </summary>
        /// <param name="Obj">ENEstoque Obj</param>
        public void DeleteProdutoFromEstoque(ENEstoque Obj)
        {
            if (Obj.Entrada == DateTime.MinValue)
            {
                Obj.Entrada = DateTime.Now;
            }
            (new DAEstoque()).Delete(Obj);
        }

        public float RetornaPossivelValorVenda(float nvValorCustoUnitario, float antValorCustoUnitario, float antValorVendaUnitario)
        {
            float possivelVlVndaUnit = 0;
            //Cálculo dos possíveis valores de venda.
            if (nvValorCustoUnitario != antValorCustoUnitario)
            {
                if (nvValorCustoUnitario < antValorCustoUnitario)
                {
                    possivelVlVndaUnit = (nvValorCustoUnitario * antValorVendaUnitario) / antValorCustoUnitario;
                }
            }

            return possivelVlVndaUnit;
        }

        public DataTable RetornaCalculosEstoque()
        {
            return (new DACalculoEstoque()).Read();
        }

        /// <summary>
        /// Método de retorno do datatable para população do relatório de estoque.
        /// </summary>
        /// <param name="dtEntrada"></param>
        /// <param name="codProduto"></param>
        /// <returns></returns>
        public DataTable RetornaRelatorio(string codProduto)
        {
            try
            {
                return new DAEstoque().RetornaRelatorio(codProduto);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
