using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENFuncionario : Pessoa
    {
        private int _intIdFuncionario;
        /// <summary>
        /// Identificador do Funcionário.
        /// </summary>
        public int IntIdFuncionario
        {
            get { return _intIdFuncionario; }
            set { _intIdFuncionario = value; }
        }

        private string _strCarteiraTrabalho;
        /// <summary>
        /// Carteira de Trabalho do Funcionário
        /// </summary>
        public string StrCarteiraTrabalho
        {
            get { return _strCarteiraTrabalho; }
            set { _strCarteiraTrabalho = value; }
        }
        private string _strSerieCarteiraTrabalho;
        /// <summary>
        /// Série da Carteira de Trabalho do Funcionário.
        /// </summary>
        public string StrSerieCarteiraTrabalho
        {
            get { return _strSerieCarteiraTrabalho; }
            set { _strSerieCarteiraTrabalho = value; }
        }
        private string _strUfCarteiraTrabalho;
        /// <summary>
        /// Estado da Carteira de Trabalho.
        /// </summary>
        public string StrUfCarteiraTrabalho
        {
            get { return _strUfCarteiraTrabalho; }
            set { _strUfCarteiraTrabalho = value; }
        }
    }
}
