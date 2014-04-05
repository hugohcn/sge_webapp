using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENSaldoCarteira
    {
        private int _idSaldoCarteira;
        /// <summary>
        /// Identificador da Baixa da Carteira.
        /// </summary>
        public int IdSaldoCarteira
        {
            get { return _idSaldoCarteira; }
            set { _idSaldoCarteira = value; }
        }
        private int _idCarteira;
        /// <summary>
        /// Identificador da Carteira que Recebeu Baixa.
        /// </summary>
        public int IdCarteira
        {
            get { return _idCarteira; }
            set { _idCarteira = value; }
        }
        private DateTime _dteBaixa;
        /// <summary>
        /// Data de Baixa.
        /// </summary>
        public DateTime DteBaixa
        {
            get { return _dteBaixa; }
            set { _dteBaixa = value; }
        }

        private float _valorPago;
        /// <summary>
        /// Valor pago pelo cliente.
        /// </summary>
        public float ValorPago
        {
            get { return _valorPago; }
            set { _valorPago = value; }
        }

    }
}
