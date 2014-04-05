using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENTipoCusto
    {
        private int _idTipoCusto;
        /// <summary>
        /// Identificador do Tipo de Custo.
        /// </summary>
        public int IdTipoCusto
        {
            get { return _idTipoCusto; }
            set { _idTipoCusto = value; }
        }
        private string _strNome;
        /// <summary>
        /// Nome do Tipo de Custo.
        /// </summary>
        public string StrNome
        {
            get { return _strNome; }
            set { _strNome = value; }
        }
    }
}
