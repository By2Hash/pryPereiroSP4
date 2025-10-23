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
            btnValidar = new Button();
            btnLimpiar = new Button();
            lblConsulta = new Label();
            button1 = new Button();
            lblMozoDelDia = new Button();
            lblRespuestaMozos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResistro).BeginInit();
            SuspendLayout();
            // 
            // dgvResistro
            // 
            dgvResistro.AccessibleDescription = "";
            dgvResistro.AllowUserToAddRows = false;
            dgvResistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResistro.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComidas, colBebidasSinAlcohol, colBebidasConAlcohol, colPostres });
            dgvResistro.Location = new Point(17, 20);
            dgvResistro.Margin = new Padding(4, 5, 4, 5);
            dgvResistro.Name = "dgvResistro";
            dgvResistro.RowHeadersVisible = false;
            dgvResistro.RowHeadersWidth = 62;
            dgvResistro.Size = new Size(720, 350);
            dgvResistro.TabIndex = 0;
            dgvResistro.CellContentClick += dgvResistro_CellContentClick;
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
            colComidas.HeaderText = "comidas";
            colComidas.MinimumWidth = 8;
            colComidas.Name = "colComidas";
            colComidas.Width = 150;
            // 
            // colBebidasSinAlcohol
            // 
            colBebidasSinAlcohol.HeaderText = "Bebidas sin alchol";
            colBebidasSinAlcohol.MinimumWidth = 8;
            colBebidasSinAlcohol.Name = "colBebidasSinAlcohol";
            colBebidasSinAlcohol.Width = 150;
            // 
            // colBebidasConAlcohol
            // 
            colBebidasConAlcohol.HeaderText = "Bebidas con alcohol";
            colBebidasConAlcohol.MinimumWidth = 8;
            colBebidasConAlcohol.Name = "colBebidasConAlcohol";
            colBebidasConAlcohol.Width = 150;
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.MinimumWidth = 8;
            colPostres.Name = "colPostres";
            colPostres.Width = 150;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(594, 380);
            btnValidar.Margin = new Padding(4, 5, 4, 5);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(143, 45);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(452, 380);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 45);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Location = new Point(10, 433);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(734, 25);
            lblConsulta.TabIndex = 4;
            lblConsulta.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - Consulta - - - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // button1
            // 
            button1.Location = new Point(594, 533);
            button1.Name = "button1";
            button1.Size = new Size(143, 45);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblMozoDelDia
            // 
            lblMozoDelDia.Location = new Point(452, 533);
            lblMozoDelDia.Name = "lblMozoDelDia";
            lblMozoDelDia.Size = new Size(126, 45);
            lblMozoDelDia.TabIndex = 6;
            lblMozoDelDia.Text = "Mozo del día";
            lblMozoDelDia.UseVisualStyleBackColor = true;
            lblMozoDelDia.Click += lblMozoDelDia_Click;
            // 
            // lblRespuestaMozos
            // 
            lblRespuestaMozos.Location = new Point(17, 476);
            lblRespuestaMozos.Name = "lblRespuestaMozos";
            lblRespuestaMozos.Size = new Size(720, 54);
            lblRespuestaMozos.TabIndex = 7;
            // 
            // frmRegistro
            // 
            AcceptButton = btnValidar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(756, 616);
            Controls.Add(lblRespuestaMozos);
            Controls.Add(lblMozoDelDia);
            Controls.Add(button1);
            Controls.Add(lblConsulta);
            Controls.Add(btnLimpiar);
            Controls.Add(btnValidar);
            Controls.Add(dgvResistro);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "La Turca - Registro de venta";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResistro;
        private DataGridViewTextBoxColumn colMozos;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn colBebidasSinAlcohol;
        private DataGridViewTextBoxColumn colBebidasConAlcohol;
        private DataGridViewTextBoxColumn colPostres;
        private Button btnValidar;
        private Button btnLimpiar;
        private Label lblConsulta;
        private Button button1;
        private Button lblMozoDelDia;
        private Label lblRespuestaMozos;
    }
}
