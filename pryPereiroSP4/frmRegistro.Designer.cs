namespace pryPereiroSP4
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            dgvResistro = new DataGridView();
            colMozos = new DataGridViewTextBoxColumn();
            colComidas = new DataGridViewTextBoxColumn();
            colBebidasSinAlcohol = new DataGridViewTextBoxColumn();
            colBebidasConAlcohol = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvResistro).BeginInit();
            SuspendLayout();
            // 
            // dgvResistro
            // 
            dgvResistro.AccessibleDescription = "";
            dgvResistro.AllowUserToAddRows = false;
            dgvResistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResistro.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComidas, colBebidasSinAlcohol, colBebidasConAlcohol, colPostres });
            dgvResistro.Location = new Point(12, 12);
            dgvResistro.Name = "dgvResistro";
            dgvResistro.RowHeadersVisible = false;
            dgvResistro.Size = new Size(506, 269);
            dgvResistro.TabIndex = 0;
            dgvResistro.CellContentClick += dgvResistro_CellContentClick;
            // 
            // colMozos
            // 
            colMozos.HeaderText = "Mozos";
            colMozos.Name = "colMozos";
            // 
            // colComidas
            // 
            colComidas.HeaderText = "comidas";
            colComidas.Name = "colComidas";
            // 
            // colBebidasSinAlcohol
            // 
            colBebidasSinAlcohol.HeaderText = "Bebidas sin alchol";
            colBebidasSinAlcohol.Name = "colBebidasSinAlcohol";
            // 
            // colBebidasConAlcohol
            // 
            colBebidasConAlcohol.HeaderText = "Bebidas con alcohol";
            colBebidasConAlcohol.Name = "colBebidasConAlcohol";
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 392);
            Controls.Add(dgvResistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "La Turca - Registro de venta";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResistro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResistro;
        private DataGridViewTextBoxColumn colMozos;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn colBebidasSinAlcohol;
        private DataGridViewTextBoxColumn colBebidasConAlcohol;
        private DataGridViewTextBoxColumn colPostres;
    }
}
