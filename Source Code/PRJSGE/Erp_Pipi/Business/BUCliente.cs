using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BUCliente
    {
        /// <summary>
        /// Selecina todos os Clientes
        /// </summary>
        /// <returns>ENCliente</returns>
        public List<ENCliente> GetAllClientes()
        {
            return (new DACliente()).Read(2, 0);
        }

        /// <summary>
        /// Seleciona um Cliente pelo ID.
        /// </summary>
        /// <param name="FaixaSalarial">int idCliente</param>
        /// <returns>ENCliente</returns>
        public List<ENCliente> GetClienteById(int idCliente)
        {
            return (new DACliente()).Read(1, idCliente);
        }

        /// <summary>
        /// Atualiza um Cliente
        /// </summary>
        /// <param name="Obj">ENCliente Obj</param>
        public void UpdateCliente(ENCliente Obj)
        {
            (new DACliente()).Update(Obj);
        }

        /// <summary>
        /// Cria um novo Cliente
        /// </summary>
        /// <param name="Obj">ENCliente Obj</param>
        public void CreateUsuario(ENCliente Obj)
        {
            (new DACliente()).Create(Obj);
        }

        /// <summary>
        /// Apaga um Cliente
        /// </summary>
        /// <param name="Obj">ENCliente Obj</param>
        public void Delete(ENCliente Obj)
        {
            (new DACliente()).Delete(Obj);
        }
    }
}
