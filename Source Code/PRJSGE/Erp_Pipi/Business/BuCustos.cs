using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BuCustos
    {
        /// <summary>
        /// Selecina todos os Custos
        /// </summary>
        /// <returns>Entity.genFaixaSalarial</returns>
        public List<ENCusto> GetAllCustos()
        {
            return (new DACustos()).Read(2, 0, 0, DateTime.Now, 0);
        }

        /// <summary>
        /// Seleciona um Custo pelo Id.
        /// </summary>
        /// <param name="FaixaSalarial">int FaixaSalarial</param>
        /// <returns>Entity.genFaixaSalarial</returns>
        public List<ENCusto> getCustoById(int idCusto)
        {
            return (new DACustos()).Read(1, idCusto , 0, DateTime.Now, 0);
        }

        /// <summary>
        /// Atualiza um Custo
        /// </summary>
        /// <param name="Obj">ENCusto Obj</param>
        public void UpdateCusto(ENCusto Obj)
        {
            (new DACustos()).UpdateCusto(Obj);
        }

        /// <summary>
        /// Cria um novo Custo
        /// </summary>
        /// <param name="Obj">ENCusto Obj</param>
        public void CreateCusto(ENCusto Obj)
        {
            (new DACustos()).CreateCusto(Obj);
        }

        /// <summary>
        /// Apaga um Custo
        /// </summary>
        /// <param name="Obj">ENCusto Obj</param>
        public void DeleteCusto(ENCusto Obj)
        {
            if (Obj.StrDescricao == null)
            {
                Obj.StrDescricao = string.Empty;
            }

            if (Obj.DteDataCusto == DateTime.MinValue)
            {
                Obj.DteDataCusto = DateTime.Now;
            }
            (new DACustos()).DeleteCusto(Obj);
        }
    }
}
