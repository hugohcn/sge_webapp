using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENCaixa
    {
        private DateTime _dataCaixa;
        /// <summary>
        /// Data do Caixa.
        /// </summary>
        public DateTime DataCaixa
        {
            get { return _dataCaixa; }
            set { _dataCaixa = value; }
        }
        private float _fltValorAbertura;
        /// <summary>
        /// Valor de Abertura do Caixa.
        /// </summary>
        public float FltValorAbertura
        {
            get { return _fltValorAbertura; }
            set { _fltValorAbertura = value; }
        }
        private float _fltValorFechamento;
        /// <summary>
        /// Valor de Fechamento do Caixa.
        /// </summary>
        public float FltValorFechamento
        {
            get { return _fltValorFechamento; }
            set { _fltValorFechamento = value; }
        }
        private float _fltValorTransicao;
        /// <summary>
        /// Valor de Transição(valor diário corrente sem fechamento).
        /// </summary>
        public float FltValorTransicao
        {
            get { return _fltValorTransicao; }
            set { _fltValorTransicao = value; }
        }

        private char _bitStatus;
        /// <summary>
        /// Status do Caixa. 1-ABERTO / 2-FECHADO
        /// </summary>
        public char BitStatus
        {
            get { return _bitStatus; }
            set { _bitStatus = value; }
        }
    }
}
