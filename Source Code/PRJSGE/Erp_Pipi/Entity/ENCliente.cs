using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENCliente : Pessoa
    {
        private int _idCliente;
        /// <summary>
        /// Identificador do Cliente.
        /// </summary>
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
    }
}
