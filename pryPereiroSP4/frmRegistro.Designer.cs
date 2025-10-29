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
            dgvRegistro = new DataGridView();
            colMozos = new DataGridViewTextBoxColumn();
            colComidas = new DataGridViewTextBoxColumn();
            colBebidasAlcohol = new DataGridViewTextBoxColumn();
            colBebidasSinAlcohol = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistro
            // 
            dgvRegistro.AllowUserToAddRows = false;
            dgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistro.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComidas, colBebidasAlcohol, colBebidasSinAlcohol, colPostres });
            dgvRegistro.Location = new Point(12, 12);
            dgvRegistro.Name = "dgvRegistro";
            dgvRegistro.RowHeadersWidth = 62;
            dgvRegistro.Size = new Size(817, 295);
            dgvRegistro.TabIndex = 0;
            dgvRegistro.CellContentClick += dgvRegistro_CellContentClick;
            // 
            // colMozos
            // 
            colMozos.HeaderText = "Mozos";
            colMozos.MinimumWidth = 8;
            colMozos.Name = "colMozos";
            colMozos.Width = 150;
            // 
            // colComidas
            // 
            colComidas.HeaderText = "Comidas";
            colComidas.MinimumWidth = 8;
            colComidas.Name = "colComidas";
            colComidas.Width = 150;
            // 
            // colBebidasAlcohol
            // 
            colBebidasAlcohol.HeaderText = "Bebidas con alcohool";
            colBebidasAlcohol.MinimumWidth = 8;
            colBebidasAlcohol.Name = "colBebidasAlcohol";
            colBebidasAlcohol.Width = 150;
            // 
            // colBebidasSinAlcohol
            // 
            colBebidasSinAlcohol.HeaderText = "Bebidas sin alcohol";
            colBebidasSinAlcohol.MinimumWidth = 8;
            colBebidasSinAlcohol.Name = "colBebidasSinAlcohol";
            colBebidasSinAlcohol.Width = 150;
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.MinimumWidth = 8;
            colPostres.Name = "colPostres";
            colPostres.Width = 150;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(588, 326);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(717, 326);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(841, 387);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvRegistro);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "La Turca - Registro de venta";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRegistro;
        private DataGridViewTextBoxColumn colMozos;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn colBebidasAlcohol;
        private DataGridViewTextBoxColumn colBebidasSinAlcohol;
        private DataGridViewTextBoxColumn colPostres;
        private Button btnGuardar;
        private Button btnLimpiar;
    }
}
