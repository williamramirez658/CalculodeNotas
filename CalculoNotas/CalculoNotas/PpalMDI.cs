using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoNotas
{
    public partial class PpalMDI : Form
    {
        public PpalMDI()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Cargar el formulario correspodiente 
            frmcalculonotas VentanaEstudiantes = new frmcalculonotas();
            VentanaEstudiantes.MdiParent = this;
            VentanaEstudiantes.Show();

        }

        private void estudiantesEliminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cargar el formulario correspodiente 
            Trash VentanaEstudiantes = new Trash();
            VentanaEstudiantes.MdiParent = this;
            VentanaEstudiantes.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cargar el formulario correspodiente 
            Acercade VentanaEstudiantes = new Acercade();
            VentanaEstudiantes.MdiParent = this;
            VentanaEstudiantes.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void PpalMDI_Load(object sender, EventArgs e)
        {

        }
    }
}
