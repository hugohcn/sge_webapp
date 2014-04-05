using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BURevendedor
    {
        /// <summary>
        /// Selecina todos os Revendedores
        /// </summary>
        /// <returns>List(ENRevendedor)</returns>
        public List<ENRevendedor> GetAllRevendedores()
        {
            return (new DARevendedor()).ReadAllRevendedor(2, 0);
        }

        /// <summary>
        /// Seleciona um Revendedor pelo Id
        /// </summary>
        /// <param name="FaixaSalarial">int idRevendedor</param>
        /// <returns>ENRevendedor</returns>
        public ENRevendedor GetRevendedorById(int idRevendedor)
        {
            List<ENRevendedor> listaRevendedor = (new DARevendedor()).ReadAllRevendedor(1, idRevendedor);
            return listaRevendedor[0];
        }

        /// <summary>
        /// Atualiza um Revendedor
        /// </summary>
        /// <param name="Obj">ENRevendedor Obj</param>
        public void UpdateRevendedor(ENRevendedor Obj)
        {
            if (Obj.StrTelefone == null)
            {
                Obj.StrTelefone = string.Empty;
            }
            if (Obj.StrCelular == null)
            {
                Obj.StrCelular = string.Empty;
            }
            if (Obj.StrFax == null)
            {
                Obj.StrFax = string.Empty;
            }
            if (Obj.StrEmail == null)
            {
                Obj.StrEmail = string.Empty;
            } 
            (new DARevendedor()).UpdateRevendedor(Obj);
        }

        /// <summary>
        /// Cria um novo Revendedor
        /// </summary>
        /// <param name="Obj">ENRevendedor Obj</param>
        public void CreateRevendedor(ENRevendedor Obj)
        {
            if (Obj.StrTelefone == null)
            {
                Obj.StrTelefone = string.Empty;
            }
            if (Obj.StrCelular == null)
            {
                Obj.StrCelular = string.Empty;
            }
            if (Obj.StrFax == null)
            {
                Obj.StrFax = string.Empty;
            }
            if (Obj.StrEmail == null)
            {
                Obj.StrEmail = string.Empty;
            } 
            (new DARevendedor()).CreateRevendedor(Obj);
        }

        /// <summary>
        /// Apaga um Revendedor
        /// </summary>
        /// <param name="Obj">ENRevendedor Obj</param>
        public void DeleteRevendedor(ENRevendedor Obj)
        {
            (new DARevendedor()).DeleteRevendedor(Obj);
        }
    }
}
