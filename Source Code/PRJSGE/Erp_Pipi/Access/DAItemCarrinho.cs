using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Access
{
    public class DAItemCarrinho
    {
        /// <summary>
        /// Seleciona uma lista de Itens de Compra de acordo com os parâmetros.
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Produtos para Compra</returns>
        public List<ENItemCarrinho> Read(int EspecificoR, int idItemCarrinho, int idProduto, int idVenda)
        {
            List<ENItemCarrinho> _objs = new List<ENItemCarrinho>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprItemCarrinhoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdItemCarrinho", idItemCarrinho);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", idProduto);
            _cmd.Parameters.AddWithValue("@sprintQuantidade", 0);
            _cmd.Parameters.AddWithValue("@sprintIdVenda", idVenda);

            _con.Open();

            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENItemCarrinho NewObj = new ENItemCarrinho();
                    NewObj.IdItemCarrinho = Convert.ToInt32(rd[0]);
                    NewObj.IdProduto = rd[1].ToString();
                    NewObj.IntQuatidade = Convert.ToInt32(rd[2].ToString());
                    NewObj.IdVenda = Convert.ToInt32(rd[3].ToString());
                    _objs.Add(NewObj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                rd.Close();
            }
            return _objs;
        }

        /// <summary>
        /// Atualiza um registro do Item para Compra.
        /// </summary>
        /// <param name="Obj">Entidade ItemCarrinho</param>
        public void Update(ENItemCarrinho Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprItemCarrinhoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdItemCarrinho", Obj.IdItemCarrinho);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", Obj.IdProduto);
            _cmd.Parameters.AddWithValue("@sprintQuantidade", Obj.IntQuatidade);
            _cmd.Parameters.AddWithValue("@sprintIdVenda", Obj.IdVenda);
            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }
        }

        /// <summary>
        /// Cria um registro de Item para Compra.
        /// </summary>
        /// <param name="Obj">Objeto ItemCarrinho</param>
        public void Create(ENItemCarrinho Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprItemCarrinhoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdItemCarrinho", Obj.IdItemCarrinho);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", Obj.IdProduto);
            _cmd.Parameters.AddWithValue("@sprintQuantidade", Obj.IntQuatidade);
            _cmd.Parameters.AddWithValue("@sprintIdVenda", Obj.IdVenda);
            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }
        }

        /// <summary>
        /// Apaga um produto do carrinho.
        /// </summary>
        /// <param name="Obj">Objeto ItemCarrinho</param>
        public void Delete(ENItemCarrinho Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprItemCarrinhoCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdItemCarrinho", Obj.IdItemCarrinho);
            _cmd.Parameters.AddWithValue("@sprintIdProduto", 0);
            _cmd.Parameters.AddWithValue("@sprintQuantidade", 0);
            _cmd.Parameters.AddWithValue("@sprintIdVenda", 0);

            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }
        }
    }
}
