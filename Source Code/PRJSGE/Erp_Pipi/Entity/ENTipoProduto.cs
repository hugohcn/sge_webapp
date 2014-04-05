using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENTipoProduto
    {
        private int _idTipoProduto;
        /// <summary>
        /// Identificador do Tipo de Produto.
        /// </summary>
        public int IdTipoProduto
        {
            get { return _idTipoProduto; }
            set { _idTipoProduto = value; }
        }
        private string _strNome;
        /// <summary>
        /// Nome do Tipo de Produto.
        /// </summary>
        public string StrNome
        {
            get { return _strNome; }
            set { _strNome = value; }
        }
    }
}
