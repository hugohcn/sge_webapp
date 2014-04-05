using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BUTipoProduto
    {
        /// <summary>
        /// Selecina todos os Tipos de Produtos.
        /// </summary>
        /// <returns>ENTipoProduto</returns>
        public List<ENTipoProduto> GetAllTipoProduto()
        {
            return (new DATipoProduto()).Read(2, 0);
        }

        /// <summary>
        /// Seleciona um Tipo de Produto.
        /// </summary>
        /// <param name="FaixaSalarial">int idTipoProduto</param>
        /// <returns>ENTipoProduto</returns>
        public ENTipoProduto GetTipoProdutoById(int idTipoProduto)
        {
            List<ENTipoProduto> tipoProduto = new List<ENTipoProduto>();
            tipoProduto = (new DATipoProduto()).Read(1, idTipoProduto);
            return tipoProduto[0];
        }

        /// <summary>
        /// Atualiza um Tipo de Produto.
        /// </summary>
        /// <param name="Obj">ENTipoProduto Obj</param>
        public void UpdateTipoProduto(ENTipoProduto Obj)
        {
            (new DATipoProduto()).Update(Obj);
        }

        /// <summary>
        /// Cria um novo Tipo de Produto.
        /// </summary>
        /// <param name="Obj">ENTipoProduto Obj</param>
        public void CreateTipoProduto(ENTipoProduto Obj)
        {
            (new DATipoProduto()).Create(Obj);
        }

        /// <summary>
        /// Apaga um Tipo de Produto.
        /// </summary>
        /// <param name="Obj">ENTipoProduto Obj</param>
        public void DeleteTipoProduto(ENTipoProduto Obj)
        {
            (new DATipoProduto()).Delete(Obj);
        }
    }
}
