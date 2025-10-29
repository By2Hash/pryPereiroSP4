using System.Windows.Forms;

namespace pryPereiroSP4
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        int[,] ventasGrilla = new int[5, 5];
        int valorGrilla;
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            //Julio, Esteban, Javier, Gonzalo y Alberto.
            dgvRegistro.Rows.Add("Julio");
            dgvRegistro.Rows[0].Cells[0].ReadOnly = true;
            dgvRegistro.Rows.Add("Esteban");
            dgvRegistro.Rows[1].Cells[0].ReadOnly = true;
            dgvRegistro.Rows.Add("Javier");
            dgvRegistro.Rows[2].Cells[0].ReadOnly = true;
            dgvRegistro.Rows.Add("Gonzalo");
            dgvRegistro.Rows[3].Cells[0].ReadOnly = true;
            dgvRegistro.Rows.Add("Alberto");
            dgvRegistro.Rows[4].Cells[0].ReadOnly = true;





        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int mayorVenta = 0;
            string categoria = "";
            string nombreVendedor = "";
            const int COLUMNA_INICIO_VENTAS = 1;
            const int COLUMNA_NOMBRE = 0;


            for (int fila = 0; fila < dgvRegistro.RowCount; fila++)
            {
                for (int columna = COLUMNA_INICIO_VENTAS; columna < dgvRegistro.ColumnCount; columna++)
                {

                    if (dgvRegistro.Rows[fila].Cells[columna].Value != null)
                    {

                        if (int.TryParse(dgvRegistro.Rows[fila].Cells[columna].Value.ToString(), out int ventaActual))
                        {

                            if (ventaActual > mayorVenta)
                            {

                                mayorVenta = ventaActual;


                                var nombreCelda = dgvRegistro.Rows[fila].Cells[COLUMNA_NOMBRE].Value;
                                if (nombreCelda != null)
                                {
                                    nombreVendedor = nombreCelda.ToString();

                                }
                                categoria = dgvRegistro.Columns[columna].HeaderText;
                            }
                        }
                    }

                }
            }


            if (mayorVenta > 0)
            {
                MessageBox.Show($"La mayor venta fue de ${mayorVenta} en la categoría: {categoria}, realizada por: {nombreVendedor}",
                        "Mayor Venta Encontrada");

            }
            else
            {
                MessageBox.Show("No se encontraron ventas válidas en la grilla.", "Atención");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            for(int fila = 0; fila < dgvRegistro.RowCount;fila++)
            {
                for(int columna = 1; columna < dgvRegistro.ColumnCount; columna++)
                {
                    dgvRegistro.Rows[fila].Cells[columna].Value = "";
                }
            }
        }
    }

}
