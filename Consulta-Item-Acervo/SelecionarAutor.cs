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
    public partial class SelecionarAutor : Form
    {
        public SelecionarAutor()
        {
            InitializeComponent();
        }
        public string nomeAutor { get; private set; }
        public void FecharFormulario()
        {
            nomeAutor = txtNomeAutor2.Text;

            this.Close();
        }
        private void SelecionarAutor_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid2.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                AutorDAO dao = new AutorDAO(connection);
                List<AutorModel> autores = dao.GetAutores();
                foreach (AutorModel autor in autores)
                {
                    DataGridViewRow row = dadosGrid2.Rows[dadosGrid2.Rows.Add()];
                    row.Cells[colcodigoAutor.Index].Value = autor.codAutor;
                    row.Cells[colnomeDoAutor.Index].Value = autor.nomeAutor;
                }
            }
        }

        private void txtNomeAutor2_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeAutor2.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid2.Rows)
            {
                string nomeAutor = row.Cells[colnomeDoAutor.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtcodAutor_TextChanged(object sender, EventArgs e)
        {

            string filtro = txtcodAutor.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid2.Rows)
            {
                string nomeAutor = row.Cells[colcodigoAutor.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void dadosGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtcodAutor.Text = dadosGrid2.Rows[e.RowIndex].Cells[colcodigoAutor.Index].Value + "";
                txtNomeAutor2.Text = dadosGrid2.Rows[e.RowIndex].Cells[colnomeDoAutor.Index].Value + "";

                FecharFormulario();

            }
        }
    }
}
