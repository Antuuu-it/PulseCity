using System.Windows.Forms;

namespace PulseCity
{
    public partial class FormRegistrarReporte : Form
    {
        public FormRegistrarReporte()
        {
            InitializeComponent();

            cmbTipo.Items.Add("Tráfico");
            cmbTipo.Items.Add("Contaminación");
            cmbTipo.Items.Add("Basura");
            cmbTipo.Items.Add("Agua");
            cmbTipo.Items.Add("Seguridad");
            cmbTipo.Items.Add("Ruido");

            cmbNivel.Items.Add("Bajo");
            cmbNivel.Items.Add("Medio");
            cmbNivel.Items.Add("Alto");
        }

        private void FormRegistrarReporte_Load(object sender, System.EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (cmbTipo.Text == "" || txtZona.Text == "" || cmbNivel.Text == "")
            {
                MessageBox.Show("Complete todos los campos");

                return;
            }

            Reporte r = new Reporte();

            r.Tipo = cmbTipo.Text;

            r.Zona = txtZona.Text;

            r.Nivel = cmbNivel.Text;

            Datos.ListaReportes.Add(r);

            MessageBox.Show("Reporte guardado correctamente");

            this.Close();
        }
    }
}
