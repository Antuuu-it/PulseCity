using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulseCity
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistrarReporte frm = new FormRegistrarReporte();

            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes();

            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            lblTrafico.Text = "Tráfico: " + r.Next(0, 101);

            lblContaminacion.Text = "Contaminación: " + r.Next(0, 101);

            lblBasura.Text = "Basura: " + r.Next(0, 101);

            lblAgua.Text = "Agua: " + r.Next(0, 101);

            lblSeguridad.Text = "Seguridad: " + r.Next(0, 101);

            lblRuido.Text = "Ruido: " + r.Next(0, 101);
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
