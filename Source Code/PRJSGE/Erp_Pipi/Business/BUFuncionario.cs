using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace BusinessLayer
{
    public class BUFuncionario
    {
        /// <summary>
        /// Selecina todos os Funcionários
        /// </summary>
        /// <returns>List(ENFuncionario)</returns>
        public List<ENFuncionario> GetAllFuncionarios()
        {
            return (new DAFuncionario()).Read(2, 0);
        }

        /// <summary>
        /// Seleciona um Funcionário pelo Id
        /// </summary>
        /// <param name="FaixaSalarial">int FaixaSalarial</param>
        /// <returns>Entity.genFaixaSalarial</returns>
        public ENFuncionario GetFuncionarioById(int idFuncionario)
        {
            List<ENFuncionario> listaFuncionario = (new DAFuncionario()).Read(1, idFuncionario);
            return listaFuncionario[0];
        }

        /// <summary>
        /// Atualiza um Funcionário
        /// </summary>
        /// <param name="Obj">ENFuncionario Obj</param>
        public void UpdateFuncionario(ENFuncionario Obj)
        {
            (new DAFuncionario()).Update(Obj);
        }

        /// <summary>
        /// Cria um novo Funcionário
        /// </summary>
        /// <param name="Obj">ENfuncionario Obj</param>
        public void CreateFuncionario(ENFuncionario Obj)
        {
            (new DAFuncionario()).Create(Obj);
        }

        /// <summary>
        /// Apaga um Funcionário
        /// </summary>
        /// <param name="Obj">ENfuncionario Obj</param>
        public void DeleteFuncionario(ENFuncionario Obj)
        {
            (new DAFuncionario()).Delete(Obj);
        }
    }
}
