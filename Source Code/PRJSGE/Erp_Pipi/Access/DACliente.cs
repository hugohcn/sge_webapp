using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Access
{
    public class DACliente
    {
        /// <summary>
        /// Seleciona uma lista de Clientes de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Clientes</returns>
        public List<ENCliente> Read(int EspecificoR, int idCliente)
        {
            List<ENCliente> _objs = new List<ENCliente>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprClienteCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdCliente", idCliente);
            _cmd.Parameters.AddWithValue("@sprstrNome", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", string.Empty);
            _cmd.Parameters.AddWithValue("@sprintNumero", 0);
            _cmd.Parameters.AddWithValue("@sprstrBairro", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCidade", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEstado", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCep", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrTelefone", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCelular", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrFax", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEmail", string.Empty);
            _con.Open();
            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENCliente NewObj = new ENCliente();

                    NewObj.IdCliente = Convert.ToInt32(rd[0].ToString());
                    NewObj.StrNome = rd[1].ToString();
                    NewObj.StrEndereco = rd[2].ToString();
                    NewObj.IntNumero = Convert.ToInt32(rd[3].ToString());
                    NewObj.StrBairro = rd[4].ToString();
                    NewObj.StrCidade = rd[5].ToString();
                    NewObj.StrEstado = rd[6].ToString();
                    NewObj.StrCep = rd[7].ToString();
                    NewObj.StrEmail = rd[8].ToString();
                    NewObj.StrTelefone = rd[9].ToString();
                    NewObj.StrCelular = rd[10].ToString();
                    NewObj.StrFax = rd[11].ToString();
                    
                    _objs.Add(NewObj);
                }
            }
            finally
            {
                rd.Close();
            }
            return _objs;
        }

        /// <summary>
        /// Atualiza um registro do Cliente.
        /// </summary>
        /// <param name="Obj">Entidade Carteira</param>
        public void Update(ENCliente Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprClienteCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCliente", Obj.IdCliente);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", Obj.StrEndereco);
            _cmd.Parameters.AddWithValue("@sprintNumero", Obj.IntNumero);
            _cmd.Parameters.AddWithValue("@sprstrBairro", Obj.StrBairro);
            _cmd.Parameters.AddWithValue("@sprstrCidade", Obj.StrCidade);
            _cmd.Parameters.AddWithValue("@sprstrEstado", Obj.StrEstado);
            if (Obj.StrCep == null)
            {
                Obj.StrCep = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrCep", Obj.StrCep);
            if (Obj.StrTelefone == null)
            {
                Obj.StrTelefone = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrTelefone", Obj.StrTelefone);
            if (Obj.StrCelular == null)
            {
                Obj.StrCelular = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrCelular", Obj.StrCelular);
            if (Obj.StrFax == null)
            {
                Obj.StrFax = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrFax", Obj.StrFax);
            if (Obj.StrEmail == null)
            {
                Obj.StrEmail = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrEmail", Obj.StrEmail);
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
        /// Cria um registro na tabela Clientes(tblClientes).
        /// </summary>
        /// <param name="Obj">Objeto Cliente</param>
        public void Create(ENCliente Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprClienteCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCliente", Obj.IdCliente);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", Obj.StrEndereco);
            _cmd.Parameters.AddWithValue("@sprintNumero", Obj.IntNumero);
            _cmd.Parameters.AddWithValue("@sprstrBairro", Obj.StrBairro);
            _cmd.Parameters.AddWithValue("@sprstrCidade", Obj.StrCidade);
            _cmd.Parameters.AddWithValue("@sprstrEstado", Obj.StrEstado);
            if (Obj.StrCep == null)
            {
                Obj.StrCep = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrCep", Obj.StrCep);
            if (Obj.StrTelefone == null)
            {
                Obj.StrTelefone = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrTelefone", Obj.StrTelefone);
            if (Obj.StrCelular == null)
            {
                Obj.StrCelular = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrCelular", Obj.StrCelular);
            if (Obj.StrFax == null)
            {
                Obj.StrFax = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrFax", Obj.StrFax);
            if (Obj.StrEmail == null)
            {
                Obj.StrEmail = string.Empty;
            }
            _cmd.Parameters.AddWithValue("@sprstrEmail", Obj.StrEmail);
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
        /// Deleta um cliente da tabela tblClientes.
        /// </summary>
        /// <param name="Obj">Objeto Cliente</param>
        public void Delete(ENCliente Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprClienteCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdCliente", Obj.IdCliente);
            _cmd.Parameters.AddWithValue("@sprstrNome", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", string.Empty);
            _cmd.Parameters.AddWithValue("@sprintNumero", 0);
            _cmd.Parameters.AddWithValue("@sprstrBairro", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCidade", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEstado", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCep", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrTelefone", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrCelular", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrFax", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrEmail", string.Empty);
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
