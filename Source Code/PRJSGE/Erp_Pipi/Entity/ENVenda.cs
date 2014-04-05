using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENVenda
    {
        private int _idVenda;
        /// <summary>
        /// Identificador da Venda.
        /// </summary>
        public int IdVenda
        {
            get { return _idVenda; }
            set { _idVenda = value; }
        }
        private int _idItemCarrinho;
        /// <summary>
        /// Identificador do Carrinho com os Produtos.
        /// </summary>
        public int IdItemCarrinho
        {
            get { return _idItemCarrinho; }
            set { _idItemCarrinho = value; }
        }
        private int _tipoPagamento;
        /// <summary>
        /// Tipo de Pagamento da Venda.
        /// </summary>
        public int TipoPagamento
        {
            get { return _tipoPagamento; }
            set { _tipoPagamento = value; }
        }
        private float _fltValorDesconto;
        /// <summary>
        /// Valor de Desconto da Venda.
        /// </summary>
        public float FltValorDesconto
        {
            get { return _fltValorDesconto; }
            set { _fltValorDesconto = value; }
        }
        private float _fltValorTotal;
        /// <summary>
        /// Valor Total da Venda.
        /// </summary>
        public float FltValorTotal
        {
            get { return _fltValorTotal; }
            set { _fltValorTotal = value; }
        }
        private bool _bitStatusVenda;
        /// <summary>
        /// Status da Venda
        /// 0(false) - Venda não Concluída.
        /// 1(true) - Venda Concluída.
        /// </summary>
        public bool BitStatusVenda
        {
            get { return _bitStatusVenda; }
            set { _bitStatusVenda = value; }
        }

        private DateTime _dteVenda;
        /// <summary>
        /// Data da venda.
        /// </summary>
        public DateTime DteVenda
        {
            get { return _dteVenda; }
            set { _dteVenda = value; }
        }

    }
}
