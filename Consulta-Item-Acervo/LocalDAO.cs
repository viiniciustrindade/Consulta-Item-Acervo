using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Item_Acervo
{
    public class LocalDAO
    {
        private SqlConnection Connection { get; }
        public LocalDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public List<LocalModel> GetLocais()
        {
            List<LocalModel> locais = new List<LocalModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT LOC.codLocal, LOC.descLocal FROM mvtBibLocal LOC");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        locais.Add(PopulateDr(dr));
                    }
                }
            }
            return locais;
        }
        private LocalModel PopulateDr(SqlDataReader dr)
        {
            string codLocal = "";
            string descLocal = "";

            if (DBNull.Value != dr["codLocal"])
            {
                codLocal = dr["codLocal"] + "";
            }
            if (DBNull.Value != dr["descLocal"])
            {
                descLocal = dr["descLocal"] + "";
            }

            return new LocalModel()
            {
                codLocal = codLocal,
                nomeLocal = descLocal,
            };
        }
    }
}

