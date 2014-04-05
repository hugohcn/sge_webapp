using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Pessoa
    {
        private string _strNome;
        /// <summary>
        /// Nome da Pessoa.
        /// </summary>
        public string StrNome
        {
            get { return _strNome; }
            set { _strNome = value; }
        }
        private string _strEndereco;
        /// <summary>
        /// Endereço da Pessoa.
        /// </summary>
        public string StrEndereco
        {
            get { return _strEndereco; }
            set { _strEndereco = value; }
        }
        private int _intNumero;
        /// <summary>
        /// Número do local do endereço.
        /// </summary>
        public int IntNumero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }
        private string _strBairro;
        /// <summary>
        /// Bairro do Endereço.
        /// </summary>
        public string StrBairro
        {
            get { return _strBairro; }
            set { _strBairro = value; }
        }
        private string _strCidade;
        /// <summary>
        /// Cidade do Enredeço.
        /// </summary>
        public string StrCidade
        {
            get { return _strCidade; }
            set { _strCidade = value; }
        }
        private string _strEstado;
        /// <summary>
        /// Estado do Endereço.
        /// </summary>
        public string StrEstado
        {
            get { return _strEstado; }
            set { _strEstado = value; }
        }
        private string _strCep;
        /// <summary>
        /// Código Postal do Endereço.
        /// </summary>
        public string StrCep
        {
            get { return _strCep; }
            set { _strCep = value; }
        }
        private string _strEmail;
        /// <summary>
        /// E-mail da Pessoa.
        /// </summary>
        public string StrEmail
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }

        private string _strTelefone;
        /// <summary>
        /// Telefone da Pessoa.
        /// </summary>
        public string StrTelefone
        {
            get { return _strTelefone; }
            set { _strTelefone = value; }
        }
        private string _strCelular;
        /// <summary>
        /// Celular da Pessoa.
        /// </summary>
        public string StrCelular
        {
            get { return _strCelular; }
            set { _strCelular = value; }
        }
        private string _strFax;
        /// <summary>
        /// Fax da Pessoa.
        /// </summary>
        public string StrFax
        {
            get { return _strFax; }
            set { _strFax = value; }
        }
    }
}
