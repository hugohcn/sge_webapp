using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ENFavorito
    {
        private int _idFavorito;
        /// <summary>
        /// Identificador do Favorito.
        /// </summary>
        public int IdFavorito
        {
            get { return _idFavorito; }
            set { _idFavorito = value; }
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
        private string _nomeFavorito;
        /// <summary>
        /// Nome do Favorito.
        /// </summary>
        public string NomeFavorito
        {
            get { return _nomeFavorito; }
            set { _nomeFavorito = value; }
        }
        private string _urlFavorito;
        /// <summary>
        /// Endereço Url para redirecionamento.
        /// </summary>
        public string UrlFavorito
        {
            get { return _urlFavorito; }
            set { _urlFavorito = value; }
        }
    }
}
