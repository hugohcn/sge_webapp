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
    public class DAFavorito
    {
        /// <summary>
        /// Seleciona uma lista de favoritos de acordo com os parâmetros
        /// </summary>
        /// <param name="EspecificoR">int EspecificoR</param>
        /// <returns>Lista de Favoritos</returns>
        public List<ENFavorito> Read(int EspecificoR, int idFavorito, int idFuncionario)
        {
            List<ENFavorito> _objs = new List<ENFavorito>();
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprFavoritosCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "R");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", EspecificoR);
            _cmd.Parameters.AddWithValue("@sprintIdFavorito", idFavorito);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", idFuncionario);
            _cmd.Parameters.AddWithValue("@sprstrNomeFavorito", string.Empty);
            _cmd.Parameters.AddWithValue("@sprstrUrlFavorito", string.Empty);

            _con.Open();
            SqlDataReader rd = _cmd.ExecuteReader(CommandBehavior.CloseConnection);

            try
            {
                while (rd.Read())
                {
                    ENFavorito NewObj = new ENFavorito();
                    NewObj.IdFavorito = Convert.ToInt32(rd[0].ToString());
                    NewObj.IdFuncionario = Convert.ToInt32(rd[1].ToString());
                    NewObj.NomeFavorito = rd[2].ToString();
                    NewObj.UrlFavorito = rd[3].ToString();
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
        /// Atualiza um Favorito
        /// </summary>
        /// <param name="Obj">Entidade Favorito</param>
        public void Update(ENFavorito Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprFavoritosCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "U");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdFavorito", Obj.IdFavorito);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", Obj.IdFuncionario);
            _cmd.Parameters.AddWithValue("@sprstrNomeFavorito", Obj.NomeFavorito);
            _cmd.Parameters.AddWithValue("@sprstrUrlFavorito", Obj.UrlFavorito);
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
        /// Cria um registro de Favorito
        /// </summary>
        /// <param name="Obj">Objeto Favorito</param>
        public void Create(ENFavorito Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprFavoritosCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "C");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdFavorito", Obj.IdFavorito);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", Obj.IdFuncionario);
            _cmd.Parameters.AddWithValue("@sprstrNomeFavorito", Obj.NomeFavorito);
            _cmd.Parameters.AddWithValue("@sprstrUrlFavorito", Obj.UrlFavorito);
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
        /// Apaga um Favorito.
        /// </summary>
        /// <param name="Obj">Objeto Favorito</param>
        public void Delete(ENFavorito Obj)
        {
            SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["PipiConnection"].ConnectionString);
            SqlCommand _cmd = new SqlCommand("sprFavoritosCRUD", _con);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@sprstrOperacao", "D");
            _cmd.Parameters.AddWithValue("@sprintEspecificoR", 0);
            _cmd.Parameters.AddWithValue("@sprintIdFavorito", Obj.IdFavorito);
            _cmd.Parameters.AddWithValue("@sprintIdFuncionario", Obj.IdFuncionario);
            _cmd.Parameters.AddWithValue("@sprstrNomeFavorito", Obj.NomeFavorito);
            _cmd.Parameters.AddWithValue("@sprstrUrlFavorito", Obj.UrlFavorito);
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
