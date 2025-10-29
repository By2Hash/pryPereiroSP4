using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace pryPereiroSP4
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        float[,] vecVentas = new float[5, 4];

        private void frmRegistro_Load(object sender, EventArgs e)
        {





            dgvResistro.Rows.Add("Julio");
            dgvResistro.Rows[0].Cells[0].ReadOnly = true;
            dgvResistro.Rows.Add("Esteban");
            dgvResistro.Rows[1].Cells[0].ReadOnly = true;
            dgvResistro.Rows.Add("Javier");
            dgvResistro.Rows[2].Cells[0].ReadOnly = true;
            dgvResistro.Rows.Add("Gonzalo");
            dgvResistro.Rows[3].Cells[0].ReadOnly = true;
            dgvResistro.Rows.Add("Alberto");
            dgvResistro.Rows[4].Cells[0].ReadOnly = true;



            dgvResistro.Rows[0].Cells[0].Style.BackColor = Color.LightGray;
            dgvResistro.Rows[1].Cells[0].Style.BackColor = Color.LightGray;
            dgvResistro.Rows[2].Cells[0].Style.BackColor = Color.LightGray;
            dgvResistro.Rows[3].Cells[0].Style.BackColor = Color.LightGray;
            dgvResistro.Rows[4].Cells[0].Style.BackColor = Color.LightGray;

            dgvResistro.Rows[0].Cells[0].Selected = true;
            dgvResistro.Rows[0].Cells[1].Selected = false;

        }

        private void dgvResistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            for (int indiceFila = 0; indiceFila < dgvResistro.Rows.Count; indiceFila++)
            {
                for (int indiceColumna = 1; indiceColumna < dgvResistro.Rows.Count; indiceColumna++)
                {
                    var valorCelda = dgvResistro.Rows[indiceFila].Cells[indiceColumna].Value;

                    if (valorCelda == null || string.IsNullOrWhiteSpace(valorCelda.ToString()))
                    {
                        dgvResistro.Rows[indiceFila].Cells[indiceColumna].Value = "no";
                    }
                    else
                    {
                        if (float.TryParse(valorCelda.ToString(), out float contenidoCelda))
                        {

                            dgvResistro.Rows[indiceFila].Cells[indiceColumna].Value = "si";
                        }
                        else
                        {
                            dgvResistro.Rows[indiceFila].Cells[indiceColumna].Value = "no";

                        }

                    }

                }
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            for (int indiceFila = 0; indiceFila < dgvResistro.Rows.Count; indiceFila++)
            {
                for (int indiceColumna = 1; indiceColumna < dgvResistro.Rows.Count; indiceColumna++)
                {
                    var valorCelda = dgvResistro.Rows[indiceFila].Cells[indiceColumna].Value;

                    if (valorCelda == null || string.IsNullOrWhiteSpace(valorCelda.ToString()))
                    {
                        dgvResistro.Rows[indiceFila].Cells[indiceColumna].Value = "";
                    }
                    else
                    {
                        if (float.TryParse(valorCelda.ToString(), out float contenidoCelda))
                        {

                            dgvResistro.Rows[indiceFila].Cells[indiceColumna].Value = "";
                        }
                        else
                        {
                            dgvResistro.Rows[indiceFila].Cells[indiceColumna].Value = "";

                        }

                    }

                }
            }
        }

        string mozo = "";
        string categoria = "";

        int mayorVenta = 0;


        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
            const int COLUMNA_INICIO_VENTAS = 1;
            const int COLUMNA_NOMBRE = 0;

            for (int fila = 0; fila < dgvResistro.RowCount; fila++)
            {
                for(int columna = COLUMNA_INICIO_VENTAS; columna < dgvResistro.ColumnCount; columna++)
                {
                    if (dgvResistro.Rows[fila].Cells[columna].Value != null)
                    {
                        if(int.TryParse(dgvResistro.Rows[fila].Cells[columna].Value.ToString(), out int ventaActual))
                        {
                            if(ventaActual > mayorVenta)
                            { 
                                mayorVenta = ventaActual;
                            }
                            var nombreCelda = dgvResistro.Rows[fila].Cells[COLUMNA_NOMBRE].Value;
                            if(nombreCelda != null)
                            {
                                    mozo = nombreCelda.ToString();
                                    categoria = dgvResistro.Columns[columna].HeaderText;
                            }
                        }
                    }

                }
            }
        }
        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {

            lblRespuestaMozos.Text = "";
            lblRespuestaMozos.Text = ($"Mozo del dia:¨{mozo}");
            lblRespuestaMozos.Text = ($"Mayor venta:¨{mayorVenta}");

        }
    }

    

}
