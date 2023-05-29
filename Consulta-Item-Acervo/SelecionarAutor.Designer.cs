namespace Consulta_Item_Acervo
{
    partial class SelecionarAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcodAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAutor2 = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.Label();
            this.dadosGrid2 = new System.Windows.Forms.DataGridView();
            this.colcodigoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnomeDoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodAutor
            // 
            this.txtcodAutor.Location = new System.Drawing.Point(97, 9);
            this.txtcodAutor.Name = "txtcodAutor";
            this.txtcodAutor.Size = new System.Drawing.Size(63, 22);
            this.txtcodAutor.TabIndex = 30;
            this.txtcodAutor.TextChanged += new System.EventHandler(this.txtcodAutor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Codigo";
            // 
            // txtNomeAutor2
            // 
            this.txtNomeAutor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAutor2.Location = new System.Drawing.Point(97, 37);
            this.txtNomeAutor2.Name = "txtNomeAutor2";
            this.txtNomeAutor2.Size = new System.Drawing.Size(491, 22);
            this.txtNomeAutor2.TabIndex = 28;
            this.txtNomeAutor2.TextChanged += new System.EventHandler(this.txtNomeAutor2_TextChanged);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.AutoSize = true;
            this.txtNomeAutor.Location = new System.Drawing.Point(13, 40);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(78, 16);
            this.txtNomeAutor.TabIndex = 27;
            this.txtNomeAutor.Text = "Nome Autor";
            // 
            // dadosGrid2
            // 
            this.dadosGrid2.AllowUserToAddRows = false;
            this.dadosGrid2.AllowUserToDeleteRows = false;
            this.dadosGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcodigoAutor,
            this.colnomeDoAutor});
            this.dadosGrid2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid2.Location = new System.Drawing.Point(16, 65);
            this.dadosGrid2.Name = "dadosGrid2";
            this.dadosGrid2.ReadOnly = true;
            this.dadosGrid2.RowHeadersWidth = 51;
            this.dadosGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid2.Size = new System.Drawing.Size(572, 237);
            this.dadosGrid2.TabIndex = 26;
            this.dadosGrid2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid2_CellDoubleClick);
            // 
            // colcodigoAutor
            // 
            this.colcodigoAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colcodigoAutor.FillWeight = 152.2843F;
            this.colcodigoAutor.HeaderText = "Codigo";
            this.colcodigoAutor.MinimumWidth = 6;
            this.colcodigoAutor.Name = "colcodigoAutor";
            this.colcodigoAutor.ReadOnly = true;
            this.colcodigoAutor.Width = 80;
            // 
            // colnomeDoAutor
            // 
            this.colnomeDoAutor.FillWeight = 73.85786F;
            this.colnomeDoAutor.HeaderText = "Nome do Autor";
            this.colnomeDoAutor.MinimumWidth = 6;
            this.colnomeDoAutor.Name = "colnomeDoAutor";
            this.colnomeDoAutor.ReadOnly = true;
            // 
            // SelecionarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.txtcodAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeAutor2);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.dadosGrid2);
            this.Name = "SelecionarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar autor";
            this.Load += new System.EventHandler(this.SelecionarAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAutor2;
        private System.Windows.Forms.Label txtNomeAutor;
        private System.Windows.Forms.DataGridView dadosGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodigoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnomeDoAutor;
    }
}