using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;
using System.Data;

namespace Business
{
    public class BUProduto
    {
        /// <summary>
        /// Selecina todos os Produtos
        /// </summary>
        /// <returns>List(ENProduto)</returns>
        public List<ENProduto> GetAllProdutos()
        {
            return (new DAProduto()).Read(2, string.Empty, 0, 0);
        }

        /// <summary>
        /// Seleciona um Produto pelo Id
        /// </summary>
        /// <param name="FaixaSalarial">int idProduto</param>
        /// <returns>ENProduto</returns>
        public DataSet GetDataProdutoById(string IdProduto)
        {
            return (new DAProduto()).ReadIdProduto(1, IdProduto, 0, 0); 

        }

        /// <summary>
        /// Seleciona um Produto pelo Id
        /// </summary>
        /// <param name="FaixaSalarial">int idProduto</param>
        /// <returns>ENProduto</returns>
        public ENProduto GetProdutoById(string idProduto)
        {
            List<ENProduto> listaProdutos = (new DAProduto()).Read(1, idProduto, 0, 0);
            if (listaProdutos.Count == 0 || listaProdutos == null)
            {
                return null;
            }
            return listaProdutos[0];
            
        }

        /// <summary>
        /// Seleciona vários Produtos pelo tipo.
        /// </summary>
        /// <param name="FaixaSalarial">int idTipoProduto</param>
        /// <returns>ENProduto</returns>
        public ENProduto GetProdutoByTipoProduto(int idTipoProduto)
        {
            List<ENProduto> listaProdutos = (new DAProduto()).Read(3, string.Empty, idTipoProduto, 0);
            return listaProdutos[0];
        }

        /// <summary>
        /// Seleciona vários Produtos pelo Revendedor.
        /// </summary>
        /// <param name="FaixaSalarial">int idRevendedor</param>
        /// <returns>ENProduto</returns>
        public ENProduto GetProdutoByRevendedor(int idRevendedor)
        {
            List<ENProduto> listaProdutos = (new DAProduto()).Read(4, string.Empty, 0, idRevendedor);
            return listaProdutos[0];
        }

        /// <summary>
        /// Atualiza um Produto
        /// </summary>
        /// <param name="Obj">ENProduto Obj</param>
        public void UpdateProduto(ENProduto Obj)
        {
            (new DAProduto()).Update(Obj);
        }

        /// <summary>
        /// Cria um novo Produto
        /// </summary>
        /// <param name="Obj">ENProduto Obj</param>
        public void CreateProduto(ENProduto Obj)
        {
            ENProduto produto = (new BUProduto()).GetProdutoById(Obj.IdProduto);
            if (produto == null)
            {
                (new DAProduto()).Create(Obj);
            }
            else
            {
                throw new Exception("Produto já cadastrado.");
            }
        }

        /// <summary>
        /// Apaga um Produto
        /// </summary>
        /// <param name="Obj">ENProduto Obj</param>
        public void DeleteProduto(ENProduto Obj)
        {
            //Verifica se produto ainda existe no estoque.
            ENEstoque estoque = (new BUEstoque()).GetProdutosByIdFromEstoque(Obj.IdProduto);

            if (estoque == null)
            {
                if (Obj.DteDataCadastro == DateTime.MinValue || Obj.DteDataCadastro == null)
                {
                    Obj.DteDataCadastro = DateTime.Now;
                }
                if (Obj.StrNome == null)
                {
                    Obj.StrNome = string.Empty;
                }
                (new DAProduto()).Delete(Obj);
            }
            else
            {
                throw new Exception("Ainda existem produtos no estoque. Remova-os primeiro.");
            }
        }
    }
}
