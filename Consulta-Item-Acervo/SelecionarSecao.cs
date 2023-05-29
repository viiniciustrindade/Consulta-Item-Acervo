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
    public partial class SelecionarSecao : Form
    {
        public SelecionarSecao()
        {
            InitializeComponent();
        }
        public string nomeSecao { get; private set; }
        public void FecharFormulario()
        {
            nomeSecao = txtNomeSecao2.Text;

            this.Close();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid5.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SecaoDAO dao = new SecaoDAO(connection);
                List<SecaoModel> secoes = dao.GetSecoes();
                foreach (SecaoModel secao in secoes)
                {
                    DataGridViewRow row = dadosGrid5.Rows[dadosGrid5.Rows.Add()];
                    row.Cells[colCodSecao.Index].Value = secao.codSecao;
                    row.Cells[colSecao.Index].Value = secao.descSecao;
                }
            }
        }

        private void dadosGrid5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtcodSecao2.Text = dadosGrid5.Rows[e.RowIndex].Cells[colCodSecao.Index].Value + "";
                txtNomeSecao2.Text = dadosGrid5.Rows[e.RowIndex].Cells[colSecao.Index].Value + "";

                FecharFormulario();
            }
        }

        private void SelecionarSecao_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
        }

        private void txtcodSecao2_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtcodSecao2.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid5.Rows)
            {
                string nomeAutor = row.Cells[colCodSecao.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtNomeSecao2_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeSecao2.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid5.Rows)
            {
                string nomeAutor = row.Cells[colSecao.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    }
}
