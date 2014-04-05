using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Access;

namespace Business
{
    public class BUCarteira
    {
        /// <summary>
        /// Selecina todos as Carteiras de Todos os Clientes.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public List<ENCarteira> GetAllCarteiraClientes()
        {
            return (new DACarteira()).Read(2, 0, 0);
        }

        /// <summary>
        /// Seleciona uma Carteira pelo ID do Cliente.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public List<ENCarteira> GetCarteiraByIdCliente(int idCliente)
        {
            return (new DACarteira()).Read(3, 0, idCliente);
        }

        /// <summary>
        /// Seleciona uma Carteira pelo ID.
        /// </summary>
        /// <returns>ENCarteira</returns>
        public ENCarteira GetCarteiraById(int idCarteira)
        {
            List<ENCarteira> carteira = new List<ENCarteira>();
            carteira = (new DACarteira()).Read(1, idCarteira, 0);
            return carteira[0];
        }

        /// <summary>
        /// Dar Baixa em uma Carteira
        /// </summary>
        /// <param name="Obj">ENCliente Obj</param>
        public void BaixaCarteira(int idCarteira, float vlPago)
        {
            ENCarteira novaCarteira = new ENCarteira();
            novaCarteira = this.GetCarteiraById(idCarteira);

            //Cria a carteira para informar pagamento.
            ENSaldoCarteira saldoCarteiraNew = new ENSaldoCarteira();

            saldoCarteiraNew.IdSaldoCarteira = 0;
            saldoCarteiraNew.IdCarteira = novaCarteira.IdCarteira;
            saldoCarteiraNew.DteBaixa = DateTime.Now;

            //Atualiza o Status da Carteira do Cliente.

            float vlTransacao = 0;
            if (novaCarteira.FltValorTotal > vlPago)
            {
                vlTransacao = novaCarteira.FltValorTotal - vlPago;
            }
            else if (novaCarteira.FltValorTotal < vlPago)
            {
                vlTransacao = novaCarteira.FltValorTotal - vlPago;
            }
            
            saldoCarteiraNew.ValorPago = vlPago;

            (new BuSaldoCarteira()).CreateSaldoCarteira(saldoCarteiraNew);


            //Se existe Crédito
            if (vlTransacao >= 0)
            {
                novaCarteira.FltValorTotal = vlTransacao;
                novaCarteira.FltValorCredito = 0;
                novaCarteira.BitStatusCarteira = true;
            }
            else if (vlTransacao < 0)
            {
                novaCarteira.FltValorTotal = 0;
                novaCarteira.FltValorCredito = vlTransacao * -1;
                novaCarteira.BitStatusCarteira = false;
            }
            (new BUCarteira()).UpdateCarteira(novaCarteira);
        }

        /// <summary>
        /// Atualiza uma Carteira
        /// </summary>
        /// <param name="Obj">ENCliente Obj</param>
        public void UpdateCarteira(ENCarteira Obj)
        {
            (new DACarteira()).Update(Obj);
        }

        /// <summary>
        /// Cria uma nova Carteira
        /// </summary>
        /// <param name="Obj">ENCarteira Obj</param>
        public void CreateCarteira(ENCarteira Obj)
        {
            (new DACarteira()).Create(Obj);
        }

        /// <summary>
        /// Apaga uma Carteira
        /// </summary>
        /// <param name="Obj">ENCarteira Obj</param>
        public void DeleteCarteira(ENCarteira Obj)
        {
            ENCarteira carteira = (new BUCarteira()).GetCarteiraById(Obj.IdCarteira);
            if (carteira != null)
            {
                if (carteira.FltValorCredito > 0)
                {
                    throw new Exception("O usuário ainda obtem créditos.");
                }
                else
                {
                    (new DACarteira()).Delete(carteira);
                }
            }
            
        }
    }
}
