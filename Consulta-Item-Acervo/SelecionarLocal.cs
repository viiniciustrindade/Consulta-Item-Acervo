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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string nomeLocal { get; private set; }
        public void FecharFormulario()
        {
            nomeLocal = txtNomeLocal2.Text; // Valor a ser enviado de volta

            this.Close();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid4.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LocalDAO dao = new LocalDAO(connection);
                List<LocalModel> locais = dao.GetLocais();
                foreach (LocalModel local in locais)
                {
                    DataGridViewRow row = dadosGrid4.Rows[dadosGrid4.Rows.Add()];
                    row.Cells[colcodigoLocal.Index].Value = local.codLocal;
                    row.Cells[colNomeLocal.Index].Value = local.nomeLocal;
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
        }

        private void txtNomeLocal2_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeLocal2.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid4.Rows)
            {
                string nomeAutor = row.Cells[colNomeLocal.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void dadosGrid4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtcodLocal2.Text = dadosGrid4.Rows[e.RowIndex].Cells[colcodigoLocal.Index].Value + "";
                txtNomeLocal2.Text = dadosGrid4.Rows[e.RowIndex].Cells[colNomeLocal.Index].Value + "";

                FecharFormulario();

            }
        }

        private void txtcodLocal2_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtcodLocal2.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid4.Rows)
            {
                string nomeAutor = row.Cells[colcodigoLocal.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    }
}
