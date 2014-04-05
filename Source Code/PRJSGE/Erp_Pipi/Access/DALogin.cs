using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Entity;

namespace Access
{
    public class DALogin
    {
        /// <summary>
        /// Seleciona uma lista de Logins de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Logins</returns>
        public List<ENLogin> Read(int EspecificoR, int idLogin, int idFuncionario, string strLogin, string strSenha)
        {
            List<ENLogin> _objs = new List<ENLogin>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprLoginCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdLogin", idLogin);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", idFuncionario);
            _cmd.Parameters.AddWithValue("@sprbitIsAdmin", 0);
            _cmd.Parameters.AddWithValue("@sprdteDataCadastro", DateTime.Now);
            _cmd.Parameters.AddWithValue("@sprstrLogin", strLogin);
            _cmd.Parameters.AddWithValue("@sprstrSenha", strSenha);
            
            _con.Open();
            
            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
                {
                    while (rd.Read())
                {
                    ENLogin NewObj = new ENLogin();
                    NewObj.IdLogin = Convert.ToInt32(rd[0].ToString());
                    NewObj.IdFuncionario = Convert.ToInt32(rd[1].ToString());
                    NewObj.IsAdmin = bool.Parse(rd[2].ToString());
                    NewObj.DteDataCadastro = Convert.ToDateTime(rd[3].ToString());
                    NewObj.StrLogin = rd[4].ToString();
                    NewObj.StrSenha = rd[5].ToString();
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
        /// Atualiza um registro do login
        /// </summary>
        /// <param name="Obj">Entidade Login</param>
        public void Update(ENLogin Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprLoginCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", string.Empty);
            _cmd.Parameters.AddWithValue("@sprintIdLogin", Obj.IdLogin);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", Obj.IdFuncionario);
            _cmd.Parameters.AddWithValue("@sprbitIsAdmin", Obj.IsAdmin);
            _cmd.Parameters.AddWithValue("@sprdteDataCadastro", Obj.DteDataCadastro);
            _cmd.Parameters.AddWithValue("@sprstrLogin", Obj.StrLogin);
            _cmd.Parameters.AddWithValue("@sprstrSenha", Obj.StrSenha);
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
        /// Cria um registro de Login
        /// </summary>
        /// <param name="Obj">Objeto Login</param>
        public void Create(ENLogin Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprLoginCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdLogin", Obj.IdLogin);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", Obj.IdFuncionario);
            _cmd.Parameters.AddWithValue("@sprbitIsAdmin", Obj.IsAdmin);
            _cmd.Parameters.AddWithValue("@sprdteDataCadastro", Obj.DteDataCadastro);
            _cmd.Parameters.AddWithValue("@sprstrLogin", Obj.StrLogin);
            _cmd.Parameters.AddWithValue("@sprstrSenha", Obj.StrSenha);
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
        /// Apaga um registro de Login
        /// </summary>
        /// <param name="Obj">Objeto Login</param>
        public void Delete(ENLogin Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprLoginCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdLogin", Obj.IdLogin);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", Obj.IdFuncionario);
            _cmd.Parameters.AddWithValue("@sprbitIsAdmin", Obj.IsAdmin);
            _cmd.Parameters.AddWithValue("@sprdteDataCadastro", Obj.DteDataCadastro);
            _cmd.Parameters.AddWithValue("@sprstrLogin", Obj.StrLogin);
            _cmd.Parameters.AddWithValue("@sprstrSenha", Obj.StrSenha);
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
