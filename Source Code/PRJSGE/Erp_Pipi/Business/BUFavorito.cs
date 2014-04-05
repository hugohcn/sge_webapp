using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BUFavorito
    {
        /// <summary>
        /// Selecina todos os Favoritos
        /// </summary>
        /// <returns>ENFavorito</returns>
        public List<ENFavorito> GetAllFavoritos()
        {
            return (new DAFavorito()).Read(2, 0, 0);
        }

        /// <summary>
        /// Seleciona um favorito pelo ID.
        /// </summary>
        /// <param name="FaixaSalarial">int idFavorito</param>
        /// <returns>ENFavorito</returns>
        public List<ENFavorito> GetFavoritoById(int idFavorito)
        {
            return (new DAFavorito()).Read(1, idFavorito, 0);
        }

        /// <summary>
        /// Seleciona um favorito pelo ID do funcionário.
        /// </summary>
        /// <param name="FaixaSalarial">int idFuncionario</param>
        /// <returns>ENFavorito</returns>
        public List<ENFavorito> GetFavoritoByFuncionarioId(int idFuncionario)
        {
            return (new DAFavorito()).Read(3, 0, idFuncionario);
        }

        /// <summary>
        /// Atualiza um Favorito
        /// </summary>
        /// <param name="Obj">ENFavorito Obj</param>
        public void UpdateFavorito(ENFavorito Obj)
        {
            (new DAFavorito()).Update(Obj);
        }

        /// <summary>
        /// Cria um novo Favorito
        /// </summary>
        /// <param name="Obj">ENFavorito Obj</param>
        public void CreateFavorito(ENFavorito Obj)
        {
            (new DAFavorito()).Create(Obj);
        }

        /// <summary>
        /// Apaga um Favorito
        /// </summary>
        /// <param name="Obj">ENFavorito Obj</param>
        public void DeleteFavorito(ENFavorito Obj)
        {
            (new DAFavorito()).Delete(Obj);
        }
    }
}
