using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Consulta_Item_Acervo { }

   /*  public class ConsultaDAO
     {
         private SqlConnection Connection { get; }
         public ConsultaDAO(SqlConnection connection)
         {
             Connection = connection;
         }
    public void Consultar(ConsultaModelcs consulta)
     {
         using (SqlCommand command = Connection.CreateCommand())
         {
             SqlTransaction t = Connection.BeginTransaction();
             try
             {
                 //Excluir(codAutor, t);

                 StringBuilder sql = new StringBuilder();
                 sql.AppendLine($"SELECT  FROM mvtBibItemAcervo(codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, tipoItem, nomeColecao, nomeLocal, volume, anoEdição, localização, secao, codSecao, tipoStatus ) VALUES(@codLocal, @exemplar, @nome, @codAutor, @nomeAutor, @codEditora, @nomeEditora, @tipoItem, @colecao, @local, @volume, @edicao, @localizacao, @secao, @codSecao, @status)");
                 command.CommandText = sql.ToString();
                 command.Parameters.Add(new SqlParameter("@codLocal", consulta.codLocal));
                 command.Parameters.Add(new SqlParameter("@exemplar", item.numExemplar));
                 command.Parameters.Add(new SqlParameter("@nome", item.nomeItem));
                 command.Parameters.Add(new SqlParameter("@codAutor", autor.codAutor));
                 command.Parameters.Add(new SqlParameter("@nomeAutor", autor.nomeAutor));
                 command.Parameters.Add(new SqlParameter("@codEditora", editora.codEditora));
                 command.Parameters.Add(new SqlParameter("@nomeEditora", editora.nomeEditora));
                 command.Parameters.Add(new SqlParameter("@tipoItem", item.tipoItem));
                 command.Parameters.Add(new SqlParameter("@colecao", item.nomeColecao));
                 command.Parameters.Add(new SqlParameter("@local", local.nomeLocal));
                 command.Parameters.Add(new SqlParameter("@volume", item.volume));
                 command.Parameters.Add(new SqlParameter("@edicao", item.anoEdicao));
                 command.Parameters.Add(new SqlParameter("@localizacao", item.localizacao));
                 command.Parameters.Add(new SqlParameter("@secao", secao.descSecao));
                 command.Parameters.Add(new SqlParameter("@codSecao", secao.codSecao));
                 command.Parameters.Add(new SqlParameter("@status", item.status));
                 command.Transaction = t;
                 command.ExecuteNonQuery();
                 t.Commit();
             }

             catch (Exception ex)
             {
                 t.Rollback();
                 throw ex;
             }
         }
     }

    public List<ConsultaModelcs> GetConsulta(ConsultaModelcs consulta)
     {
         List<ConsultaModelcs> itens = new List<ConsultaModelcs>();
         using (SqlCommand command = Connection.CreateCommand())
         {
             StringBuilder sql = new StringBuilder();
             sql.AppendLine("SELECT ITE.codItem, ITE.nome, ITE.nomeAutor, ITE.nomeEditora, ITE.tipoItem, ITE.nomeColecao, ITE.nomeLocal, ITE.secao, ITE.tipoStatus FROM mvtBibItemAcervo ITE");
             command.CommandText = sql.ToString();
             command.Parameters.Add(new SqlParameter("@codItem", consulta.codItem));
             using (SqlDataReader dr = command.ExecuteReader())
             {
                 while (dr.Read())
                 {
                     itens.Add(PopulateDr(dr));
                 }
             }
         }
        return itens;
    
     public List<ConsultaModelcs> GetConsulta(ConsultaModelcs consulta) 
     {
         List<ConsultaModelcs> itens = new List<ConsultaModelcs>();
         using (SqlCommand command = Connection.CreateCommand())
         {
             StringBuilder sql = new StringBuilder();
             sql.AppendLine("SELECT ITE.codItem, ITE.nome, ITE.nomeAutor, ITE.nomeEditora, ITE.tipoItem, ITE.nomeColecao, ITE.nomeLocal, ITE.secao, ITE.tipoStatus");
             sql.AppendLine("FROM mvtBibItemAcervo ITE");
             sql.AppendLine("WHERE 1 = 1");

             if (!string.IsNullOrEmpty(consulta.codItem))
             {
                 sql.AppendLine("AND ITE.codItem = @codItem");
                 command.Parameters.Add(new SqlParameter("@codItem", consulta.codItem));
             }
             if (!string.IsNullOrEmpty(consulta.localItem))
             {
                 sql.AppendLine("AND ITE.nomeLocal = @nomeLocal");
                 command.Parameters.Add(new SqlParameter("@nomeLocal", consulta.localItem));
             }
             if (!string.IsNullOrEmpty(consulta.autorItem))
             {
                 sql.AppendLine("AND ITE.nomeAutor = @nomeAutor");
                 command.Parameters.Add(new SqlParameter("@nomeAutor", consulta.autorItem));
             }
             if (!string.IsNullOrEmpty(consulta.tipoItem))
             {
                 sql.AppendLine("AND ITE.tipoItem = @tipoItem");
                 command.Parameters.Add(new SqlParameter("@tipoItem", consulta.tipoItem));
             }
             if (!string.IsNullOrEmpty(consulta.tipoItem))
             {
                 sql.AppendLine("AND ITE.nomeColecao = @colecao");
                 command.Parameters.Add(new SqlParameter("@colecao", consulta.colecaoItem));
             }
             if (!string.IsNullOrEmpty(consulta.tipoItem))
             {
                 sql.AppendLine("AND ITE.secao = @secao");
                 command.Parameters.Add(new SqlParameter("@secao", consulta.secaoItem));
             }
             if (!string.IsNullOrEmpty(consulta.tipoItem))
             {
                 sql.AppendLine("AND ITE.tipoStatus = @status");
                 command.Parameters.Add(new SqlParameter("@status", consulta.statusItem));
             }
             command.CommandText = sql.ToString();

             using (SqlDataReader dr = command.ExecuteReader())
             {
                 while (dr.Read())
                 {
                     itens.Add(PopulateDr(dr));
                 }
             }
         }
         return itens;
     }
     public ConsultaModelcs PopulateDr(SqlDataReader dr)
     {
         string codItem = "";
         string nomeItem = "";
         string localItem = "";
         string statusItem = "";
         string tipoItem = "";
         string nomeColecao = "";
         string nomeEditora = "";
         string autorItem = "";
         string secaoItem = "";

         if (DBNull.Value != dr["codItem"])
         {
             codItem = dr["codItem"] + "";
         }
         if (DBNull.Value != dr["nomeEditora"])
         {
             nomeEditora = dr["nomeEditora"] + "";
         }
         if (DBNull.Value != dr["nome"])
         {
             nomeItem = dr["nome"] + "";
         }
         if (DBNull.Value != dr["nomeLocal"])
         {
             localItem = dr["nomeLocal"] + "";
         }
         if (DBNull.Value != dr["tipoStatus"])
         {
             statusItem = dr["tipoStatus"] + "";
         }
         if (DBNull.Value != dr["nomeAutor"])
         {
             autorItem = dr["nomeAutor"] + "";
         }
         if (DBNull.Value != dr["secao"])
         {
             secaoItem = dr["secao"] + "";
         }
         if (DBNull.Value != dr["tipoItem"])
         {
             tipoItem = dr["tipoItem"] + "";
         }
         if (DBNull.Value != dr["nomeColecao"])
         {
             nomeColecao = dr["nomeColecao"] + "";
         }

         return new ConsultaModelcs()
         {
         codItem = codItem,
         nomeEditora = nomeEditora,
         nomeItem = nomeItem,
         localItem = localItem,
         statusItem = statusItem,
         tipoItem = tipoItem,
         colecaoItem = nomeColecao,
         autorItem = autorItem,
         secaoItem = secaoItem,
         };
   }
 }
}*/
