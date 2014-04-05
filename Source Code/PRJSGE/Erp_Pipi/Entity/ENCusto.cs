using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENCusto
    {
        private int _idCusto;
        /// <summary>
        /// Identificador do Custo.
        /// </summary>
        public int IdCusto
        {
            get { return _idCusto; }
            set { _idCusto = value; }
        }
        private int _idTipoCusto;
        /// <summary>
        /// Identificador do tipo de custo.
        /// </summary>
        public int IdTipoCusto
        {
            get { return _idTipoCusto; }
            set { _idTipoCusto = value; }
        }
        private string _strDescricao;
        /// <summary>
        /// Descrição do Custo.
        /// </summary>
        public string StrDescricao
        {
            get { return _strDescricao; }
            set { _strDescricao = value; }
        }
        private DateTime _dteDataCusto;
        /// <summary>
        /// Data de transação do custo.
        /// </summary>
        public DateTime DteDataCusto
        {
            get { return _dteDataCusto; }
            set { _dteDataCusto = value; }
        }
        private float _fltValorCusto;
        /// <summary>
        /// Valor do Custo.
        /// </summary>
        public float FltValorCusto
        {
            get { return _fltValorCusto; }
            set { _fltValorCusto = value; }
        }
    }
}
