using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BUTipoCusto
    {
        /// <summary>
        /// Selecina todos os Tipos de Custo.
        /// </summary>
        /// <returns>ENCliente</returns>
        public List<ENTipoCusto> GetAllTipoCusto()
        {
            return (new DATipoCusto()).Read(2, 0, string.Empty);
        }

        /// <summary>
        /// Seleciona um Tipo de Custo pelo ID.
        /// </summary>
        /// <param name="FaixaSalarial">int idCliente</param>
        /// <returns>ENTipoCusto</returns>
        public List<ENTipoCusto> GetTipoCustoById(int idTipoCusto)
        {
            return (new DATipoCusto()).Read(1, idTipoCusto, string.Empty);
        }

        /// <summary>
        /// Atualiza um Tipo Custo.
        /// </summary>
        /// <param name="Obj">ENTipoCusto Obj</param>
        public void UpdateTipoCusto(ENTipoCusto Obj)
        {
            (new DATipoCusto()).UpdateTipoCusto(Obj);
        }

        /// <summary>
        /// Cria um novo Tipo de Custo.
        /// </summary>
        /// <param name="Obj">ENTipoCusto Obj</param>
        public void CreateTipoCusto(ENTipoCusto Obj)
        {
            (new DATipoCusto()).CreateTipoCusto(Obj);
        }

        /// <summary>
        /// Apaga um Tipo de Custo.
        /// </summary>
        /// <param name="Obj">ENCliente Obj</param>
        public void Delete(ENTipoCusto Obj)
        {
            if (Obj.StrNome == null)
            {
                Obj.StrNome = string.Empty;
            }
            (new DATipoCusto()).DeleteTipoCusto(Obj);
        }
    }
}
