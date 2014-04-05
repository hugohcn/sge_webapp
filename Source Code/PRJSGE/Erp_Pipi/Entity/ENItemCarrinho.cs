using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENItemCarrinho
    {
        private int _idItemCarrinho;
        /// <summary>
        /// Cesta de Vendas.
        /// </summary>
        public int IdItemCarrinho
        {
            get { return _idItemCarrinho; }
            set { _idItemCarrinho = value; }
        }
        private string _idProduto;
        /// <summary>
        /// Identificador do Produto Escolhido para Venda.
        /// </summary>
        public string IdProduto
        {
            get { return _idProduto; }
            set { _idProduto = value; }
        }
        private int _intQuatidade;
        /// <summary>
        /// Quantidade do Produto incluso na Cesta.
        /// </summary>
        public int IntQuatidade
        {
            get { return _intQuatidade; }
            set { _intQuatidade = value; }
        }

        private int _idVenda;
        /// <summary>
        /// Identificador da venda.
        /// </summary>
        public int IdVenda
        {
            get { return _idVenda; }
            set { _idVenda = value; }
        }
    }
}
