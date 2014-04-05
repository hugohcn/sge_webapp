using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BUTipoPagamento
    {
        /// <summary>
        /// Selecina todos os Tipos de Pagamento.
        /// </summary>
        /// <returns>ENTipoPagamento</returns>
        public List<ENTipoPagamento> GetAllTipoPagamento()
        {
            return (new DATipoPagamento()).Read(2, 0);
        }

        /// <summary>
        /// Seleciona um Tipo de Pagamento pelo ID.
        /// </summary>
        /// <param name="FaixaSalarial">int idTipoProduto</param>
        /// <returns>ENTipoPagamento</returns>
        public ENTipoPagamento GetTipoPagamentoById(int idTipoPagamento)
        {
            List<ENTipoPagamento> tpPagamento = new List<ENTipoPagamento>();
            tpPagamento = (new DATipoPagamento()).Read(1, idTipoPagamento);

            if (tpPagamento.Count == 0)
            {
                return null;
            }
            return tpPagamento[0];
        }

        /// <summary>
        /// Atualiza um Tipo de Pagamento.
        /// </summary>
        /// <param name="Obj">ENTipoPagamento Obj</param>
        public void UpdateTipoPagamento(ENTipoPagamento Obj)
        {
            (new DATipoPagamento()).Update(Obj);
        }

        /// <summary>
        /// Cria um novo Tipo de Pagamento.
        /// </summary>
        /// <param name="Obj">ENTipoPagamento Obj</param>
        public void CreateTipoPagamento(ENTipoPagamento Obj)
        {
            (new DATipoPagamento()).Create(Obj);
        }

        /// <summary>
        /// Apaga um Tipo de pagamento.
        /// </summary>
        /// <param name="Obj">ENTipoProduto Obj</param>
        public void DeleteTipoPagamento(ENTipoPagamento Obj)
        {
            if (Obj.StrNome == null)
            {
                Obj.StrNome = string.Empty;
            }
            (new DATipoPagamento()).Delete(Obj);
        }
    }
}
