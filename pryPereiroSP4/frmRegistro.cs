namespace pryPereiroSP4
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

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
        }

        private void dgvResistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
