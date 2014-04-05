using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BuSaldoCarteira
    {
        /// <summary>
        /// Selecina todas as Carteiras.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public List<ENSaldoCarteira> GetAllSaldoCarteira()
        {
            return (new DASaldoCarteira()).ReadSaldoCarteira(2, 0, 0, DateTime.Now);
        }

        /// <summary>
        /// Seleciona um Saldo da Carteira pelo Id da Carteira.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public List<ENSaldoCarteira> GetSaldoCarteiraByIdCarteira(int idCarteira)
        {
            return (new DASaldoCarteira()).ReadSaldoCarteira(3, 0, idCarteira, DateTime.Now);
        }

        /// <summary>
        /// Seleciona um Saldo da Carteira Pela Data de Baixa.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public List<ENSaldoCarteira> GetSaldoCarteiraByDate(DateTime dteBaixa)
        {
            return (new DASaldoCarteira()).ReadSaldoCarteira(4, 0, 0, dteBaixa);
        }

        /// <summary>
        /// Seleciona um Saldo da Carteira pelo ID.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public ENSaldoCarteira GetSaldoCarteiraById(int idSaldoCarteira)
        {
            List<ENSaldoCarteira> lstSaldoCarteira = (new DASaldoCarteira()).ReadSaldoCarteira(1, idSaldoCarteira, 0, DateTime.Now);

            if (lstSaldoCarteira.Count == 0)
	        {
        		 return null;
	        }
            return lstSaldoCarteira[0];
        }

        /// <summary>
        /// Seleciona um Saldo da Carteira pelo ID do Saldo e Id da Carteira.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public List<ENSaldoCarteira> GetSaldoCarteiraByIdSaldoAndIdCarteira(int idSaldoCarteira, int idCarteira)
        {
            return  (new DASaldoCarteira()).ReadSaldoCarteira(5, idSaldoCarteira, idCarteira, DateTime.Now); 
        }

        /// <summary>
        /// Seleciona um Saldo da Carteira pelo Id da Carteira e Data.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public List<ENSaldoCarteira> GetSaldoCarteiraByIdCarteiraAndDate(int idCarteira, DateTime dteBaixa)
        {
            return (new DASaldoCarteira()).ReadSaldoCarteira(6, 0, idCarteira, dteBaixa);
        }

        /// <summary>
        /// Atualiza um Saldo de Carteira.
        /// </summary>
        /// <param name="Obj">ENCliente Obj</param>
        public void UpdateSaldoCarteira(ENSaldoCarteira Obj)
        {
            (new DASaldoCarteira()).UpdateSaldoCarteira(Obj);
        }

        /// <summary>
        /// Cria um novo Saldo da Carteira
        /// </summary>
        /// <param name="Obj">ENCarteira Obj</param>
        public void CreateSaldoCarteira(ENSaldoCarteira Obj)
        {
            (new DASaldoCarteira()).CreateSaldoCarteira(Obj);
        }

        /// <summary>
        /// Apaga um Saldo de Carteira
        /// </summary>
        /// <param name="Obj">ENSaldoCarteira Obj</param>
        public void DeleteCarteira(ENSaldoCarteira Obj)
        {
            (new DASaldoCarteira()).DeleteSaldoCarteira(Obj);
        }
    }
}
