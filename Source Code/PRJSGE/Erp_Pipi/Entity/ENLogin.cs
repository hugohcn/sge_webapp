using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENLogin
    {
        private int _idLogin;
        /// <summary>
        /// Identificador do Login.
        /// </summary>
        public int IdLogin
        {
            get { return _idLogin; }
            set { _idLogin = value; }
        }
        private int _idFuncionario;
        /// <summary>
        /// Identificador do Funcionário Responsável.
        /// </summary>
        public int IdFuncionario
        {
            get { return _idFuncionario; }
            set { _idFuncionario = value; }
        }
        private bool _IsAdmin;
        /// <summary>
        /// Identificador Booleano do Tipo de Usuário do Sistema.
        /// </summary>
        public bool IsAdmin
        {
            get { return _IsAdmin; }
            set { _IsAdmin = value; }
        }
        private DateTime _dteDataCadastro;
        /// <summary>
        /// Data de Cadastro do Funcionário no Sistema.
        /// </summary>
        public DateTime DteDataCadastro
        {
            get { return _dteDataCadastro; }
            set { _dteDataCadastro = value; }
        }
        private string _strLogin;
        /// <summary>
        /// Login do Funcionário.
        /// </summary>
        public string StrLogin
        {
            get { return _strLogin; }
            set { _strLogin = value; }
        }
        private string _strSenha;
        /// <summary>
        /// Senha do Login do Funcionário.
        /// </summary>
        public string StrSenha
        {
            get { return _strSenha; }
            set { _strSenha = value; }
        }
    }
}
