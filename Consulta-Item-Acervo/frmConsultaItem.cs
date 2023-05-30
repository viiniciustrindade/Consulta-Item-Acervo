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

        private void btnCarregarLocal_Click(object sender, EventArgs e)
        {
            AbrirSelecaoLocal();
        }

        private void btnCarregarAutor_Click(object sender, EventArgs e)
        {
            AbrirSelecaoAutor();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            string sql = "SELECT ITE.codItem, ITE.nome, ITE.nomeAutor, ITE.nomeEditora, ITE.tipoItem, ITE.nomeColecao, ITE.nomeLocal, ITE.secao, ITE.tipoStatus " +
            "FROM mvtBibItemAcervo ITE " +
            "WHERE 1 = 1";

            if (!string.IsNullOrEmpty(txtCodItem.Text.Trim()))
            {
                sql += $" AND ITE.codItem LIKE '%{txtCodItem.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(txtNomeItem.Text.Trim()))
            {
                sql += $" AND ITE.nome LIKE '%{txtNomeItem.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(txtLocal.Text.Trim()))
            {
                sql += $" AND ITE.nomeLocal LIKE '%{txtLocal.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(txtNomeAutor.Text.Trim()))
            {
                sql += $" AND ITE.nomeAutor LIKE '%{txtNomeAutor.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(cbxTipoItem.Text.Trim()))
            {
                sql += $" AND ITE.tipoItem LIKE '%{cbxTipoItem.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(txtColecao.Text.Trim()))
            {
                sql += $" AND ITE.nomeColecao LIKE '%{txtColecao.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(txtSecao.Text.Trim()))
            {
                sql += $" AND ITE.secao LIKE '%{txtSecao.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(cbxStatus.Text.Trim()))
            {
                sql += $" AND ITE.tipoStatus LIKE '%{cbxStatus.Text.Trim()}%'";
            }

            dadosGrid.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dadosGrid);
                        row.Cells[colCodItem.Index].Value = reader["codItem"].ToString();
                        row.Cells[colNomeItem.Index].Value = reader["nome"].ToString();
                        row.Cells[colColecao.Index].Value = reader["nomeColecao"].ToString();
                        row.Cells[colLocal.Index].Value = reader["nomeLocal"].ToString();
                        row.Cells[colEditora.Index].Value = reader["nomeEditora"].ToString();
                        row.Cells[colAutor.Index].Value = reader["nomeAutor"].ToString();
                        row.Cells[colStatus.Index].Value = reader["tipoStatus"].ToString();
                        row.Cells[colTipoItem.Index].Value = reader["tipoItem"].ToString();
                        row.Cells[colSecao.Index].Value = reader["secao"].ToString();

                        dadosGrid.Rows.Add(row);
                    }
                }
            }
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
            dadosGrid.Rows.Clear();
        }
        private void btnCarregarSecao_Click(object sender, EventArgs e)
        {
            AbrirSelecaoSecao();
        }

        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodItem.Index].Value + "";
            txtNomeItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
            cbxStatus.Text = dadosGrid.Rows[e.RowIndex].Cells[colStatus.Index].Value + "";
            txtColecao.Text = dadosGrid.Rows[e.RowIndex].Cells[colColecao.Index].Value + "";
            cbxTipoItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colTipoItem.Index].Value + "";
            txtLocal.Text = dadosGrid.Rows[e.RowIndex].Cells[colLocal.Index].Value + "";
            txtSecao.Text = dadosGrid.Rows[e.RowIndex].Cells[colSecao.Index].Value + "";
            txtNomeAutor.Text = dadosGrid.Rows[e.RowIndex].Cells[colAutor.Index].Value + "";
        }
    }
}
