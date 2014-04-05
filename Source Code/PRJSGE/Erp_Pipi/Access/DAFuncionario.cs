using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Access
{
    public class DAFuncionario
    {
        /// <summary>
        /// Seleciona uma lista de Funcionários de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de funcionários</returns>
        public List<ENFuncionario> Read(int EspecificoR, int idUsuario)
        {
            List<ENFuncionario> _objs = new List<ENFuncionario>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprFuncionarioCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", idUsuario);
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
            _cmd.Parameters.AddWithValue("@sprstrCarteiraTrabalho", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrSerieCt", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrUfCt", string.Empty);
            
            _con.Open();

            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENFuncionario NewObj = new ENFuncionario();
                    NewObj.IntIdFuncionario = Convert.ToInt32(rd[0].ToString());
                    NewObj.StrNome = rd[1].ToString();
                    NewObj.StrEndereco = rd[2].ToString();
                    NewObj.IntNumero = Convert.ToInt32(rd[3].ToString());
                    NewObj.StrBairro = rd[4].ToString();
                    NewObj.StrCidade = rd[5].ToString();
                    NewObj.StrEstado = rd[6].ToString(); 
                    NewObj.StrCep = rd[7].ToString();
                    NewObj.StrTelefone = rd[8].ToString();
                    NewObj.StrCelular = rd[9].ToString();
                    NewObj.StrFax = rd[10].ToString();
                    NewObj.StrEmail = rd[11].ToString();
                    NewObj.StrCarteiraTrabalho = rd[12].ToString();
                    NewObj.StrSerieCarteiraTrabalho = rd[13].ToString();
                    NewObj.StrUfCarteiraTrabalho = rd[14].ToString();
                    
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
        /// Atualiza um registro do Funcionário
        /// </summary>
        /// <param name="Obj">Entidade Funcionário</param>
        public void Update(ENFuncionario Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprFuncionarioCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", Obj.IntIdFuncionario);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", Obj.StrEndereco);
            _cmd.Parameters.AddWithValue("@sprintNumero", Obj.IntNumero);
            _cmd.Parameters.AddWithValue("@sprstrBairro", Obj.StrBairro);
            _cmd.Parameters.AddWithValue("@sprstrCidade", Obj.StrCidade);
            _cmd.Parameters.AddWithValue("@sprstrEstado", Obj.StrEstado);
            _cmd.Parameters.AddWithValue("@sprstrCep", Obj.StrCep);
            _cmd.Parameters.AddWithValue("@sprstrTelefone", Obj.StrTelefone);
            _cmd.Parameters.AddWithValue("@sprstrCelular", Obj.StrCelular);
            _cmd.Parameters.AddWithValue("@sprstrFax", Obj.StrFax);
            _cmd.Parameters.AddWithValue("@sprstrEmail", Obj.StrEmail);
            _cmd.Parameters.AddWithValue("@sprstrCarteiraTrabalho", Obj.StrCarteiraTrabalho);
            _cmd.Parameters.AddWithValue("@sprstrSerieCt", Obj.StrSerieCarteiraTrabalho);
            _cmd.Parameters.AddWithValue("@sprstrUfCt", Obj.StrUfCarteiraTrabalho);

            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            finally
            {
                _con.Close();
            }
        }

        /// <summary>
        /// Cria um registro na tabela tblFuncionario.
        /// </summary>
        /// <param name="Obj">Objeto Funcionario</param>
        public void Create(ENFuncionario Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprFuncionarioCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", Obj.IntIdFuncionario);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", Obj.StrEndereco);
            _cmd.Parameters.AddWithValue("@sprintNumero", Obj.IntNumero);
            _cmd.Parameters.AddWithValue("@sprstrBairro", Obj.StrBairro);
            _cmd.Parameters.AddWithValue("@sprstrCidade", Obj.StrCidade);
            _cmd.Parameters.AddWithValue("@sprstrEstado", Obj.StrEstado);
            _cmd.Parameters.AddWithValue("@sprstrCep", Obj.StrCep);
            _cmd.Parameters.AddWithValue("@sprstrTelefone", Obj.StrTelefone);
            _cmd.Parameters.AddWithValue("@sprstrCelular", Obj.StrCelular);
            _cmd.Parameters.AddWithValue("@sprstrFax", Obj.StrFax);
            _cmd.Parameters.AddWithValue("@sprstrEmail", Obj.StrEmail);
            _cmd.Parameters.AddWithValue("@sprstrCarteiraTrabalho", Obj.StrCarteiraTrabalho);
            _cmd.Parameters.AddWithValue("@sprstrSerieCt", Obj.StrSerieCarteiraTrabalho);
            _cmd.Parameters.AddWithValue("@sprstrUfCt", Obj.StrUfCarteiraTrabalho);
            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            finally
            {
                _con.Close();
            }
        }

        /// <summary>
        /// Apaga um registro da tabela tblFuncionario.
        /// </summary>
        /// <param name="Obj">Objeto ENFuncionario</param>
        public void Delete(ENFuncionario Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprFuncionarioCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", Obj.IntIdFuncionario);
            _cmd.Parameters.AddWithValue("@sprstrNome", Obj.StrNome);
            _cmd.Parameters.AddWithValue("@sprstrEndereco", Obj.StrEndereco);
            _cmd.Parameters.AddWithValue("@sprintNumero", Obj.IntNumero);
            _cmd.Parameters.AddWithValue("@sprstrBairro", Obj.StrBairro);
            _cmd.Parameters.AddWithValue("@sprstrCidade", Obj.StrCidade);
            _cmd.Parameters.AddWithValue("@sprstrEstado", Obj.StrEstado);
            _cmd.Parameters.AddWithValue("@sprstrCep", Obj.StrCep);
            _cmd.Parameters.AddWithValue("@sprstrTelefone", Obj.StrTelefone);
            _cmd.Parameters.AddWithValue("@sprstrCelular", Obj.StrCelular);
            _cmd.Parameters.AddWithValue("@sprstrFax", Obj.StrFax);
            _cmd.Parameters.AddWithValue("@sprstrEmail", Obj.StrEmail);
            _cmd.Parameters.AddWithValue("@sprstrCarteiraTrabalho", Obj.StrCarteiraTrabalho);
            _cmd.Parameters.AddWithValue("@sprstrSerieCt", Obj.StrSerieCarteiraTrabalho);
            _cmd.Parameters.AddWithValue("@sprstrUfCt", Obj.StrUfCarteiraTrabalho);
            try
            {
                _con.Open();
                _cmd.ExecuteNonQuery();
            }
            finally
            {
                _con.Close();
            }
        }

    }
}
