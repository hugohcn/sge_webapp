using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;
using System.Data;

namespace Business
{
    public class BUCaixa
    {
        /// <summary>
        /// Retorna todos os registros de caixa existentes.
        /// </summary>
        /// <returns>ENCaixa</returns>
        public List<ENCaixa> GetAllCaixa()
        {
            return (new DACaixa()).Read(2, DateTime.Now);
        }

        /// <summary>
        /// Retorna caixa pela data(ID).
        /// </summary>
        /// <returns>ENCarteira</returns>
        public ENCaixa GetCaixaByDate(DateTime dtCaixa)
        {
            List<ENCaixa> lstCaixa = (new DACaixa()).Read(1, dtCaixa);
            if (lstCaixa.Count > 0)
            {
                return lstCaixa[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Retorna o último valor de transição ativo.
        /// </summary>
        /// <returns></returns>
        public ENCaixa GetLastestTransitionValue()
        {
            List<ENCaixa> lstCaixa = (new DACaixa()).GetLastestTransitionValue(3, '1');
            
            if (lstCaixa.Count > 0)
	        {
                return lstCaixa[0];
	        }
            return null;
        }

        /// <summary>
        /// Retorna o último valor de transição sem o status.
        /// </summary>
        /// <returns></returns>
        public ENCaixa GetLastestTransitionValueWithoutStatus()
        {

            List<ENCaixa> lstCaixa = (new DACaixa()).GetLastestTransitionValue(5, '1');

            if (lstCaixa.Count > 0)
            {
                return lstCaixa[0];
            }
            return null;
            
        }

        /// <summary>
        /// Efetuar baixa no caixa.
        /// </summary>
        /// <param name="idCarteira"></param>
        /// <param name="vlPago"></param>
        public void EfetuarBaixa()
        {
            ENCaixa cx = this.GetLastestTransitionValue();

            if (cx != null)
            {
                cx.BitStatus = '0';

                this.UpdateCaixa(cx);
            }
            else
            {
                throw new Exception("O Caixa ainda não foi aberto para a data: " + DateTime.Now.ToString("dd/MM/yyyy") + ".");
            }
        }

        /// <summary>
        /// Atualiza um caixa.
        /// </summary>
        /// <param name="Obj"></param>
        public void UpdateCaixa(ENCaixa Obj)
        {
            (new DACaixa()).Update(Obj);
        }

        /// <summary>
        /// Efetua criação de um novo registro de caixa.
        /// </summary>
        /// <param name="Obj"></param>
        public void CriarCaixa(ENCaixa Obj)
        {
            (new DACaixa()).Create(Obj);
        }

        /// <summary>
        /// Deletar um registro de carteira.
        /// </summary>
        /// <param name="Obj"></param>
        public void DeletarCaixa(ENCaixa Obj)
        {
            (new DACaixa()).Delete(Obj);
        }

        /// <summary>
        /// Retorna um DataTable.
        /// Caso seja sem data, os dados de vendas serão dos dias atuais.
        /// </summary>
        /// <param name="Obj">ENVenda Obj</param>
        public DataTable RetornaRelatorio(DateTime dtInicial, DateTime dtFinal)
        {
            try
            {
                return (new DACaixa()).RetornaRelatorio(dtInicial, dtFinal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
