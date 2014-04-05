using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENEstoque
    {
        private string _idProduto;
        /// <summary>
        /// Identificador do Produto.
        /// </summary>
        public string IdProduto
        {
            get { return _idProduto; }
            set { _idProduto = value; }
        }
        private DateTime _entrada;
        /// <summary>
        /// Data de Entrada do Produto no Estoque.
        /// </summary>
        public DateTime Entrada
        {
            get { return _entrada; }
            set { _entrada = value; }
        }
        private int _quantidadeEntrada;
        /// <summary>
        /// Quantidade que foi estocada.
        /// </summary>
        public int QuantidadeEntrada
        {
            get { return _quantidadeEntrada; }
            set { _quantidadeEntrada = value; }
        }
        
        private int _quantidadeVendida;
        /// <summary>
        /// Quantidade de produtos vendidos desde a data de entrada do mesmo no estoque.
        /// </summary>
        public int QuantidadeVendida
        {
            get { return _quantidadeVendida; }
            set { _quantidadeVendida = value; }
        }
        private float _valorCustoUnitario;
        /// <summary>
        /// Valor do custo unitário para compra do produto.
        /// </summary>
        public float ValorCustoUnitario
        {
            get { return _valorCustoUnitario; }
            set { _valorCustoUnitario = value; }
        }
        private float _valorVendaUnitario;
        /// <summary>
        /// Valor de venda unitário do produto.
        /// </summary>
        public float ValorVendaUnitario
        {
            get { return _valorVendaUnitario; }
            set { _valorVendaUnitario = value; }
        }

        private float _valorTotalCusto;
        /// <summary>
        /// Valor total de custo do produto no estoque.
        /// </summary>
        public float ValorTotalCusto
        {
            get { return _valorTotalCusto; }
            set { _valorTotalCusto = value; }
        }

        private float _valorTotalVenda;
        /// <summary>
        /// Valor total de venda do produto no estoque.
        /// </summary>
        public float ValorTotalVenda
        {
            get { return _valorTotalVenda; }
            set { _valorTotalVenda = value; }
        }
    }
}
