using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENRevendedor : Pessoa
    {
        private int _idRevendedor;
        /// <summary>
        /// Identificador do Revendedor.
        /// </summary>
        public int IdRevendedor
        {
            get { return _idRevendedor; }
            set { _idRevendedor = value; }
        }
    }
}
