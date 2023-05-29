using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Item_Acervo
{
    public class AutorDAO
    {
        private SqlConnection Connection { get; }
        public AutorDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public List<AutorModel> GetAutores()
        {
            List<AutorModel> autores = new List<AutorModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT AUT.codAutor, AUT.nomeAutor FROM mvtBibAutor AUT");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        autores.Add(PopulateDr(dr));
                    }
                }
            }
            return autores;
        }
        private AutorModel PopulateDr(SqlDataReader dr)
        {
            string codAutor = "";
            string nomeAutor = "";

            if (DBNull.Value != dr["codAutor"])
            {
                codAutor = dr["codAutor"] + "";
            }
            if (DBNull.Value != dr["nomeAutor"])
            {
                nomeAutor = dr["nomeAutor"] + "";
            }

            return new AutorModel()
            {
                codAutor = codAutor,
                nomeAutor = nomeAutor,

            };
        }
    }
}

