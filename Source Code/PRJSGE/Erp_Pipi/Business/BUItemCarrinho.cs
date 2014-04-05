using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BUItemCarrinho
    {
        /// <summary>
        /// Selecina todos Itens de um Carrinho.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public List<ENItemCarrinho> GetAllItensCarrinho()
        {
            return (new DAItemCarrinho()).Read(2, 0, 0, 0);
        }

        /// <summary>
        /// Seleciona um Carrinho pelo ID.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public ENItemCarrinho GetCarrinhoById(int idCarrinho)
        {
            List<ENItemCarrinho> lstItemCarrinho = (new DAItemCarrinho()).Read(1, idCarrinho, 0, 0);
            if (lstItemCarrinho.Count > 0)
            {
                return lstItemCarrinho[0];
            }
            return null;
        }

        /// <summary>
        /// Seleciona um Carrinho pelo ID da Venda.
        /// </summary>
        /// <param name="idVenda"></param>
        /// <returns>Lista de Produtos pertecentes a venda informada.</returns>
        public List<ENItemCarrinho> GetCarrinhoByIdVenda(int idVenda)
        {
            return (new DAItemCarrinho()).Read(3, 0, 0, idVenda);
        }

        /// <summary>
        /// Atualiza um Carrinho.
        /// </summary>
        /// <param name="Obj">ENCliente Obj</param>
        public void UpdateCarrinho(ENItemCarrinho Obj)
        {
            (new DAItemCarrinho()).Update(Obj);
        }

        /// <summary>
        /// Cria um novo Carrinho.
        /// </summary>
        /// <param name="Obj">ENCarteira Obj</param>
        public void CreateCarrinho(ENItemCarrinho Obj)
        {
            (new DAItemCarrinho()).Create(Obj);
        }

        /// <summary>
        /// Apaga um Carrinho.
        /// </summary>
        /// <param name="Obj">ENCarteira Obj</param>
        public void DeleteCarrinho(ENItemCarrinho Obj)
        {

            (new DAItemCarrinho()).Delete(Obj);
        }
    }
}
