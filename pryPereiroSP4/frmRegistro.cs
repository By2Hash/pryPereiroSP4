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
            dgvResistro.Rows.Add("Esteban");
            dgvResistro.Rows.Add("Javier");
            dgvResistro.Rows.Add("Gonzalo");
            dgvResistro.Rows.Add("Alberto");



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
            MessageBox.Show("Algunos datos ingresados, son incorrectos");
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

        private void lblMozoDelDia_Click(object sender, EventArgs e)
        {
            int majorventa = 0;
            string mozo;

            for(int iFila = 0; iFila < dgvResistro.Rows.Count; iFila++)
            {
                for(int iColumna = 0; iColumna < dgvResistro.Rows.Count; iColumna++)
                {
                    majorventa = dgvResistro.Rows.Count;
                }
            }
            
        }
    }

}
