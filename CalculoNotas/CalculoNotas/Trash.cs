using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CalculoNotas
{
    public partial class Trash : Form
    {


        public Trash()
        {
            InitializeComponent();
        }

        Validation validation = new Validation();
        Alumno alumno = new Alumno();

        public void deleteAlumno(Alumno alumno)
        {
            frmcalculonotas.listaAlumnosBorrados.Add(alumno);
            dgvAlumnosBorrados.DataSource = null;
            dgvAlumnosBorrados.DataSource = frmcalculonotas.listaAlumnosBorrados;
        }
        public void loadAlumnosBorrados()
        {
            Console.WriteLine("loadAlumnosBorrados");


            dgvAlumnosBorrados.DataSource = null;
            dgvAlumnosBorrados.DataSource = frmcalculonotas.listaAlumnosBorrados;
        }

        private void Trash_Load(object sender, EventArgs e)
        {
            dgvAlumnosBorrados.DataSource = null;
            dgvAlumnosBorrados.DataSource = frmcalculonotas.listaAlumnosBorrados;
            loadAlumnosBorrados();
        }

        private Alumno obtenerAlumnoBorrado(int code)
        {
            foreach (Alumno alumno in frmcalculonotas.listaAlumnosBorrados)
            {
                if (alumno.Codigo == code)
                {
                    return alumno;
                }
            }
            return null;
        }


        private bool verifyTheCodeExists(int code)
        {

            foreach (Alumno alumno in frmcalculonotas.listaAlumnos)
            {
                if (alumno.Codigo == code)
                {
                    return true;
                }
            }

            return false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            recoverStudent();
        }

        public void recoverStudent()
        {
            errorProvider1.Clear();
            if (validation.isNumber(txtCode, errorProvider1, "Debe ser un numero"))
            {
                alumno = obtenerAlumnoBorrado(int.Parse(txtCode.Text));

                if (verifyTheCodeExists(alumno.Codigo) == true)
                {
                    MessageBox.Show("Este codigo ya existe asigna un nuevo codigo", "Codigo existente");
                    label1.Text = "Nuevo codigo";
                    tbsNuevoCodigo.Enabled = true;
                    tbsRecuperarAlumno.Enabled = false;
                }
                else
                {
                   
                    frmcalculonotas.listaAlumnos.Add(alumno);
                    frmcalculonotas.listaAlumnosBorrados.Remove(alumno);
                    dgvAlumnosBorrados.DataSource = null;
                    dgvAlumnosBorrados.DataSource = frmcalculonotas.listaAlumnosBorrados;
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Alumno>));
                    using (TextWriter textWriter = new StreamWriter("listaAlumnos.xml"))
                    {
                        xmlSerializer.Serialize(textWriter, frmcalculonotas.listaAlumnos);
                    }
                    frmcalculonotas.listaAlumnosBorrados.Remove(alumno);






                    // saveAlumnosBorrados();
                    txtCode.Clear();
                }

            }
        }

        private void tbsNuevoCodigo_Click(object sender, EventArgs e)
        {
            if (validation.isNumber(txtCode, errorProvider1, "Debe ser un numero"))
            {
                alumno.Codigo = int.Parse(txtCode.Text);
                label1.Text = "Buscar por codigo";
                tbsNuevoCodigo.Enabled = false;
                tbsRecuperarAlumno.Enabled = true;
                txtCode.Clear();
                dgvAlumnosBorrados.DataSource = null;
                dgvAlumnosBorrados.DataSource = frmcalculonotas.listaAlumnosBorrados;
                MessageBox.Show("El codigo se cambio correctamente, intenta recuperar de nuevo", "Codigo cambiado");
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Trash_Activated(object sender, EventArgs e)
        {
        }

    }
}
