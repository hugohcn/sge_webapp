using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENCarteira
    {
        private int _idCarteira;
        /// <summary>
        /// Identificador da Carteira.
        /// </summary>
        public int IdCarteira
        {
            get { return _idCarteira; }
            set { _idCarteira = value; }
        }
        private int _idCliente;
        /// <summary>
        /// Identificador do Cliente Responsável.
        /// </summary>
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        private float _fltValorTotal;
        /// <summary>
        /// Valor Total Devido.
        /// </summary>
        public float FltValorTotal
        {
            get { return _fltValorTotal; }
            set { _fltValorTotal = value; }
        }
        private DateTime _dteDataPagamento;
        /// <summary>
        /// Data de Pagamento.
        /// </summary>
        public DateTime DteDataPagamento
        {
            get { return _dteDataPagamento; }
            set { _dteDataPagamento = value; }
        }
        private float _fltValorCredito;
        /// <summary>
        /// Valor de Crédito da Carteira.
        /// </summary>
        public float FltValorCredito
        {
            get { return _fltValorCredito; }
            set { _fltValorCredito = value; }
        }
        private bool _bitStatusCarteira;
        /// <summary>
        /// Status da Carteira.
        /// 0(false) - carteira em Débito.
        /// 1(true) - Carteira Paga.
        /// </summary>
        public bool BitStatusCarteira
        {
            get { return _bitStatusCarteira; }
            set { _bitStatusCarteira = value; }
        }
    }
}
