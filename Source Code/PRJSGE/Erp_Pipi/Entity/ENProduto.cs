using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENProduto
    {
        /// <summary>
        /// Região de Propriedades Públicas.
        /// </summary>
        #region Public Properties of Entity.
        private string _idProduto;
        /// <summary>
        /// Identificador do Produto.
        /// </summary>
        public string IdProduto
        {
            get { return _idProduto; }
            set { _idProduto = value; }
        }
        private int _idTipoProduto;
        /// <summary>
        /// Identificador do Tipo de Produto.
        /// </summary>
        public int IdTipoProduto
        {
            get { return _idTipoProduto; }
            set { _idTipoProduto = value; }
        }
        private int _idRevendedor;
        /// <summary>
        /// Identificador do Revendedor.
        /// </summary>
        public int IdRevendedor
        {
            get { return _idRevendedor; }
            set { _idRevendedor = value; }
        }
        private string _strNome;
        /// <summary>
        /// Nome do Produto.
        /// </summary>
        public string StrNome
        {
            get { return _strNome; }
            set { _strNome = value; }
        }
        
        private DateTime _dteDataCadastro;
        /// <summary>
        /// Data de Cadastro do Produto no Sistema.
        /// </summary>
        public DateTime DteDataCadastro
        {
            get { return _dteDataCadastro; }
            set { _dteDataCadastro = value; }
        }

        private float fltValor;
        /// <summary>
        /// Valor do Produto.
        /// </summary>
        public float FltValor
        {
            get { return fltValor; }
            set { fltValor = value; }
        }
        #endregion

    }
}
