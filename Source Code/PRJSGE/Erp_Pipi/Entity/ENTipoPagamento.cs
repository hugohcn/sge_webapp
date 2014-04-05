using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENTipoPagamento
    {
        private int _idTipoPagamento;
        /// <summary>
        /// Identificador do Tipo de Pagamento.
        /// </summary>
        public int IdTipoPagamento
        {
            get { return _idTipoPagamento; }
            set { _idTipoPagamento = value; }
        }
        private string _strNome;
        /// <summary>
        /// Nome do Tipo de Pagamento.
        /// </summary>
        public string StrNome
        {
            get { return _strNome; }
            set { _strNome = value; }
        }
    }
}
