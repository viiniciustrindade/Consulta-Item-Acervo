using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Item_Acervo
{
    public class SecaoDAO
    {
        private SqlConnection Connection { get; }
        public SecaoDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public List<SecaoModel> GetSecoes()
        {
            List<SecaoModel> secoes = new List<SecaoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT SEC.codSecao, SEC.descSecao FROM mvtBibSecao SEC");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        secoes.Add(PopulateDr(dr));
                    }
                }
            }
            return secoes;
        }
        private SecaoModel PopulateDr(SqlDataReader dr)
        {
            string codSecao = "";
            string descSecao = "";

            if (DBNull.Value != dr["codSecao"])
            {
                codSecao = dr["codSecao"] + "";
            }
            if (DBNull.Value != dr["descSecao"])
            {
                descSecao = dr["descSecao"] + "";
            }

            return new SecaoModel()
            {
                codSecao = codSecao,
                descSecao = descSecao,

            };
        }
    }
}
