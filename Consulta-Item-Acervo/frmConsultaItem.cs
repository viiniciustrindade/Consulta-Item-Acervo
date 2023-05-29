using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Item_Acervo
{
    public partial class frmConsultaItem : Form
    {
        public frmConsultaItem()
        {
            InitializeComponent();
        }
        public void AbrirSelecaoSecao()
        {
            SelecionarSecao secao = new SelecionarSecao();
            secao.ShowDialog();
            txtSecao.Text = secao.nomeSecao;
        }
        public void AbrirSelecaoLocal()
        {
            Form2 local = new Form2();
            local.ShowDialog();
            txtLocal.Text = local.nomeLocal;
        }
        public void AbrirSelecaoAutor()
        {
            SelecionarAutor autor = new SelecionarAutor();
            autor.ShowDialog();

            txtNomeAutor.Text = autor.nomeAutor;

        }
        private void CarregarUsuariosGrid()
        {
  
               
            
        }

        private void frmConsultaItem_Load(object sender, EventArgs e)
        {
        }

        private void btnCarregarLocal_Click(object sender, EventArgs e)
        {
            AbrirSelecaoLocal();
        }

        private void btnCarregarAutor_Click(object sender, EventArgs e)
        {
            AbrirSelecaoAutor();
        }
        private SqlConnection Connection { get; }
        public frmConsultaItem(SqlConnection connection)
        {
            Connection = connection;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT ITE.codItem, ITE.nome, ITE.nomeAutor, ITE.nomeEditora, ITE.tipoItem, ITE.nomeColecao, ITE.nomeLocal, ITE.secao, ITE.tipoStatus");
                sql.AppendLine("FROM mvtBibItemAcervo ITE");
                sql.AppendLine("WHERE 1 = 1");

                if (!string.IsNullOrEmpty(txtCodItem.Text))
                {
                    sql.AppendLine("AND ITE.codItem LIKE '%@codItem%'");
                    command.Parameters.Add(new SqlParameter("@codItem", txtCodItem.Text));
                }
                if (!string.IsNullOrEmpty(txtNomeItem.Text))
                {
                    sql.AppendLine("AND ITE.nome LIKE '%@nome%'");
                    command.Parameters.Add(new SqlParameter("@nome", txtNomeItem.Text));
                }
                if (!string.IsNullOrEmpty(txtLocal.Text))
                {
                    sql.AppendLine("AND ITE.nomeLocal LIKE '%@nomeLocal%'");
                    command.Parameters.Add(new SqlParameter("@nomeLocal", txtLocal.Text));
                }
                if (!string.IsNullOrEmpty(txtNomeAutor.Text))
                {
                    sql.AppendLine("AND ITE.nomeAutor LIKE '%@nomeAutor%'");
                    command.Parameters.Add(new SqlParameter("@nomeAutor", txtNomeAutor.Text));
                }
                if (!string.IsNullOrEmpty(cbxTipoItem.Text))
                {
                    sql.AppendLine("AND ITE.tipoItem LIKE '%@tipoItem%'");
                    command.Parameters.Add(new SqlParameter("@tipoItem", cbxTipoItem.Text));
                }
                if (!string.IsNullOrEmpty(txtColecao.Text))
                {
                    sql.AppendLine("AND ITE.nomeColecao LIKE '%@colecao%'");
                    command.Parameters.Add(new SqlParameter("@colecao", txtColecao.Text));
                }
                if (!string.IsNullOrEmpty(txtSecao.Text))
                {
                    sql.AppendLine("AND ITE.secao LIKE '%@secao%'");
                    command.Parameters.Add(new SqlParameter("@secao", txtSecao.Text));
                }
                if (!string.IsNullOrEmpty(cbxStatus.Text))
                {
                    sql.AppendLine("AND ITE.tipoStatus LIKE '%@status%'");
                    command.Parameters.Add(new SqlParameter("@status", cbxStatus.Text));
                }
                command.CommandText = sql.ToString();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                        row.Cells[colCodItem.Index].Value = reader["codItem"].ToString();
                        row.Cells[colNomeItem.Index].Value = reader["nome"].ToString();
                        row.Cells[colColecao.Index].Value = reader["nomeColecao"].ToString();
                        row.Cells[colLocal.Index].Value = reader["nomeLocal"].ToString();
                        row.Cells[colEditora.Index].Value = reader["nomeEditora"].ToString();
                        row.Cells[colAutor.Index].Value = reader["nomeAutor"].ToString();
                        row.Cells[colStatus.Index].Value = reader["tipoStatus"].ToString();
                        row.Cells[colTipoItem.Index].Value = reader["tipoItem"].ToString();
                        row.Cells[colSecao.Index].Value = reader["secao"].ToString();
                    }
                }
            }

        }

        private void txtCodItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeItem_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeItem.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string filtro1 = row.Cells[colNomeItem.Index].Value.ToString().Trim();
                bool exibir = filtro1.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void cbxTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColecao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
 
            txtCodItem.Enabled = true;
            txtNomeItem.Enabled = true;
            txtNomeItem.Enabled = true;
            txtLocal.Enabled = true;
            txtLocal.Enabled = true;
            txtNomeAutor.Enabled = true;
            cbxTipoItem.Enabled = true;
            txtColecao.Enabled = true;
            txtSecao.Enabled = true;
            cbxStatus.Enabled = true;
            txtCodItem.Text = "";
            txtNomeItem.Text = "";
            txtLocal.Text = "";
            txtColecao.Text = "";
            txtNomeAutor.Text = "";
            cbxStatus.SelectedIndex = -1;
            cbxTipoItem.SelectedIndex = -1;
            txtSecao.Text = "";
            btnCarregarAutor.Enabled = true;
            btnCarregarLocal.Enabled = true;
            btnCarregarSecao.Enabled = true;

        }
        private void btnCarregarSecao_Click(object sender, EventArgs e)
        {
            AbrirSelecaoSecao();
        }
    }
}
