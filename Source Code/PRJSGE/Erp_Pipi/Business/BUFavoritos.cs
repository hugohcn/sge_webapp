using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BUFavoritos
    {
        /// <summary>
        /// Selecina todos os Favoritos
        /// </summary>
        /// <returns>List(ENFavorito)</returns>
        public List<ENFavorito> GetAllFavoritos()
        {
            return (new DAFavorito()).Read(2, 0, 0);
        }

        /// <summary>
        /// Seleciona um favorito pelo Id
        /// </summary>
        /// <param name="FaixaSalarial">int FaixaSalarial</param>
        /// <returns>Entity.genFaixaSalarial</returns>
        public ENFavorito GetFavoritoById(int idFavorito)
        {
            List<ENFavorito> listaFavorito = (new DAFavorito()).Read(1, idFavorito, 0);
            return listaFavorito[0];
        }


        /// <summary>
        /// Seleciona um favorito pelo Id do funcionário
        /// </summary>
        /// <param name="FaixaSalarial">int idFuncionario</param>
        /// <returns>Favoritos</returns>
        public ENFavorito GetFavoritoByFuncionario(int idFuncionario)
        {
            List<ENFavorito> listaFavorito = (new DAFavorito()).Read(3, 0, idFuncionario);
            return listaFavorito[0];
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
        /// Cria um novo Funcionário
        /// </summary>
        /// <param name="Obj">ENFavorito Obj</param>
        public void CreateFavorito(ENFavorito Obj)
        {
            (new DAFavorito()).Create(Obj);
        }

        /// <summary>
        /// Apaga um Funcionário
        /// </summary>
        /// <param name="Obj">ENfuncionario Obj</param>
        public void DeleteFavorito(ENFavorito Obj)
        {
            (new DAFavorito()).Delete(Obj);
        }
    }
}
