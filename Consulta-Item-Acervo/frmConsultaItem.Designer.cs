namespace Consulta_Item_Acervo
{
    partial class frmConsultaItem
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCarregarLocal = new System.Windows.Forms.Button();
            this.btnCarregarAutor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColecao = new System.Windows.Forms.TextBox();
            this.txtSecao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnCarregarSecao = new System.Windows.Forms.Button();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // txtCodItem
            // 
            this.txtCodItem.Location = new System.Drawing.Point(90, 9);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.Size = new System.Drawing.Size(56, 22);
            this.txtCodItem.TabIndex = 1;
            this.txtCodItem.TextChanged += new System.EventHandler(this.txtCodItem_TextChanged);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(90, 37);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(269, 22);
            this.txtNomeItem.TabIndex = 2;
            this.txtNomeItem.TextChanged += new System.EventHandler(this.txtNomeItem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome item";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(90, 65);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(240, 22);
            this.txtLocal.TabIndex = 4;
            this.txtLocal.TextChanged += new System.EventHandler(this.txtLocal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Autor";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(90, 93);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.ReadOnly = true;
            this.txtNomeAutor.Size = new System.Drawing.Size(240, 22);
            this.txtNomeAutor.TabIndex = 7;
            this.txtNomeAutor.TextChanged += new System.EventHandler(this.txtNomeAutor_TextChanged);
            // 
            // cbxTipoItem
            // 
            this.cbxTipoItem.FormattingEnabled = true;
            this.cbxTipoItem.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
            this.cbxTipoItem.Location = new System.Drawing.Point(443, 7);
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(340, 24);
            this.cbxTipoItem.TabIndex = 8;
            this.cbxTipoItem.SelectedIndexChanged += new System.EventHandler(this.cbxTipoItem_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo item";
            // 
            // btnCarregarLocal
            // 
            this.btnCarregarLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregarLocal.FlatAppearance.BorderSize = 0;
            this.btnCarregarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarLocal.Image = global::Consulta_Item_Acervo.Properties.Resources.magnifying_glass_icon;
            this.btnCarregarLocal.Location = new System.Drawing.Point(336, 65);
            this.btnCarregarLocal.Name = "btnCarregarLocal";
            this.btnCarregarLocal.Size = new System.Drawing.Size(23, 22);
            this.btnCarregarLocal.TabIndex = 10;
            this.btnCarregarLocal.UseVisualStyleBackColor = true;
            this.btnCarregarLocal.Click += new System.EventHandler(this.btnCarregarLocal_Click);
            // 
            // btnCarregarAutor
            // 
            this.btnCarregarAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregarAutor.FlatAppearance.BorderSize = 0;
            this.btnCarregarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarAutor.Image = global::Consulta_Item_Acervo.Properties.Resources.magnifying_glass_icon;
            this.btnCarregarAutor.Location = new System.Drawing.Point(336, 93);
            this.btnCarregarAutor.Name = "btnCarregarAutor";
            this.btnCarregarAutor.Size = new System.Drawing.Size(23, 22);
            this.btnCarregarAutor.TabIndex = 11;
            this.btnCarregarAutor.UseVisualStyleBackColor = true;
            this.btnCarregarAutor.Click += new System.EventHandler(this.btnCarregarAutor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Coleção";
            // 
            // txtColecao
            // 
            this.txtColecao.Location = new System.Drawing.Point(443, 37);
            this.txtColecao.Name = "txtColecao";
            this.txtColecao.Size = new System.Drawing.Size(340, 22);
            this.txtColecao.TabIndex = 13;
            this.txtColecao.TextChanged += new System.EventHandler(this.txtColecao_TextChanged);
            // 
            // txtSecao
            // 
            this.txtSecao.Location = new System.Drawing.Point(443, 65);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.ReadOnly = true;
            this.txtSecao.Size = new System.Drawing.Size(311, 22);
            this.txtSecao.TabIndex = 14;
            this.txtSecao.TextChanged += new System.EventHandler(this.txtSecao_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Seção";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Disponivel",
            "Reservado",
            "Emprestado\t"});
            this.cbxStatus.Location = new System.Drawing.Point(443, 93);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(340, 24);
            this.cbxStatus.TabIndex = 17;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // btnCarregarSecao
            // 
            this.btnCarregarSecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregarSecao.FlatAppearance.BorderSize = 0;
            this.btnCarregarSecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarSecao.Image = global::Consulta_Item_Acervo.Properties.Resources.magnifying_glass_icon;
            this.btnCarregarSecao.Location = new System.Drawing.Point(760, 65);
            this.btnCarregarSecao.Name = "btnCarregarSecao";
            this.btnCarregarSecao.Size = new System.Drawing.Size(23, 22);
            this.btnCarregarSecao.TabIndex = 18;
            this.btnCarregarSecao.UseVisualStyleBackColor = true;
            this.btnCarregarSecao.Click += new System.EventHandler(this.btnCarregarSecao_Click);
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItem,
            this.colNomeItem,
            this.colEditora,
            this.colColecao,
            this.colLocal,
            this.colAutor,
            this.colTipoItem,
            this.colSecao,
            this.colStatus});
            this.dadosGrid.Location = new System.Drawing.Point(15, 157);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(768, 280);
            this.dadosGrid.TabIndex = 21;
            // 
            // colCodItem
            // 
            this.colCodItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodItem.FillWeight = 152.2843F;
            this.colCodItem.HeaderText = "Item";
            this.colCodItem.MinimumWidth = 6;
            this.colCodItem.Name = "colCodItem";
            this.colCodItem.ReadOnly = true;
            this.colCodItem.Width = 61;
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Nome Item";
            this.colNomeItem.MinimumWidth = 6;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colEditora
            // 
            this.colEditora.HeaderText = "Editora";
            this.colEditora.MinimumWidth = 6;
            this.colEditora.Name = "colEditora";
            this.colEditora.ReadOnly = true;
            // 
            // colColecao
            // 
            this.colColecao.HeaderText = "Coleção";
            this.colColecao.MinimumWidth = 6;
            this.colColecao.Name = "colColecao";
            this.colColecao.ReadOnly = true;
            // 
            // colLocal
            // 
            this.colLocal.HeaderText = "Local";
            this.colLocal.MinimumWidth = 6;
            this.colLocal.Name = "colLocal";
            this.colLocal.ReadOnly = true;
            this.colLocal.Visible = false;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 6;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            this.colAutor.Visible = false;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo Item";
            this.colTipoItem.MinimumWidth = 6;
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            // 
            // colSecao
            // 
            this.colSecao.HeaderText = "Seção";
            this.colSecao.MinimumWidth = 6;
            this.colSecao.Name = "colSecao";
            this.colSecao.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(533, 123);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(122, 27);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.Location = new System.Drawing.Point(661, 123);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(122, 27);
            this.btnNovaConsulta.TabIndex = 24;
            this.btnNovaConsulta.Text = "Nova Consulta";
            this.btnNovaConsulta.UseVisualStyleBackColor = true;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // frmConsultaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.btnCarregarSecao);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSecao);
            this.Controls.Add(this.txtColecao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCarregarAutor);
            this.Controls.Add(this.btnCarregarLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTipoItem);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.txtCodItem);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaItem";
            this.Text = "Consulta Item";
            this.Load += new System.EventHandler(this.frmConsultaItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.ComboBox cbxTipoItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCarregarLocal;
        private System.Windows.Forms.Button btnCarregarAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColecao;
        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnCarregarSecao;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button btnNovaConsulta;
    }
}

