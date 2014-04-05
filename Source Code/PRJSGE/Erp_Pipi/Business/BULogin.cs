using System;
using System.Collections.Generic;
using System.Text;
using Access;
using Entity;

namespace BusinessLayer
{
    public class BULogin
    {
        /// <summary>
        /// Selecina todos os Usuários
        /// </summary>
        /// <returns>Entity.genFaixaSalarial</returns>
        public List<ENLogin> GetAllusuarios()
        {
            return (new DALogin()).Read(2, 0, 0, string.Empty, string.Empty);
        }

        /// <summary>
        /// Seleciona um Usuário
        /// </summary>
        /// <param name="FaixaSalarial">int FaixaSalarial</param>
        /// <returns>Entity.genFaixaSalarial</returns>
        public List<ENLogin> GetUsuarioById(int idLogin, int idFuncionario)
        {
            return (new DALogin()).Read(1, idLogin, idFuncionario, string.Empty, string.Empty);
        }

        /// <summary>
        /// Selecina todos os Usuários Administradores
        /// </summary>
        /// <returns>ENLogin</returns>
        public List<ENLogin> GetAllAdministradores()
        {
            List<ENLogin> listaAdmin = (new DALogin()).Read(4, 0, 0, string.Empty, string.Empty);
            return listaAdmin;
        }

        /// <summary>
        /// Seleciona um Login de acordo com login e senha.
        /// </summary>
        /// <param name="FaixaSalarial">int idUsuario</param>
        /// /// <param name="FaixaSalarial">string strLogin</param>
        /// /// <param name="FaixaSalarial">int FaixaSalarial</param>
        /// <returns>Entity.genFaixaSalarial</returns>
        public List<ENLogin> GetUsuarioByLogin(string strLogin, string strSenha)
        {
            return (new DALogin()).Read(3, 0, 0, strLogin, strSenha);
        }

        /// <summary>
        /// Atualiza um Usuário
        /// </summary>
        /// <param name="Obj">ENUsuario Obj</param>
        public void UpdateUsuario(ENLogin Obj)
        {
            (new DALogin()).Update(Obj);
        }

        /// <summary>
        /// Cria um novo Usuário
        /// </summary>
        /// <param name="Obj">ENUsuario Obj</param>
        public void CreateUsuario(ENLogin Obj)
        {
            (new DALogin()).Create(Obj);
        }

        /// <summary>
        /// Apaga um Usuário
        /// </summary>
        /// <param name="Obj">ENUsuario Obj</param>
        public void Delete(ENLogin Obj)
        {
            (new DALogin()).Delete(Obj);
        }
    }
}
