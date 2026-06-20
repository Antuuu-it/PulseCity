using System.Windows.Forms;

namespace PulseCity
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();

            dgvReportes.Rows.Clear();

            foreach (Reporte r in Datos.ListaReportes)
            {
                dgvReportes.Rows.Add(
                    r.Tipo,
                    r.Zona,
                    r.Nivel
                );
            }

        }

        private void dgvReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
