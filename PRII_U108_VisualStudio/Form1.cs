using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRII_U108_VisualStudio
{
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes;
        Estudiante seleccionado;

        public Form1()
        {
            InitializeComponent();
            estudiantes = new List<Estudiante>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var c = GetAll(this, typeof(Label));
            //MessageBox.Show("Total Controls: " + c.Count());
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Label))
                    c.Left = 25;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c.GetType() == typeof(TextBox))
                {
                    
                }
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (tbEstudiante.Text == "" || tbEstudiante.Text == " ")
            {
                MessageBox.Show("Ingrese un nombre!");
                return;
            } else {
                Estudiante e1 = new Estudiante(tbEstudiante.Text);
                estudiantes.Add(e1);
                cbEstudiante.Items.Add(e1.nombre);
                
            }
        }

        private void cbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionado = estudiantes[cbEstudiante.SelectedIndex];
            if (seleccionado == null)
            {
                MessageBox.Show("No se selecciono un alumno!");
            }
            else
            {
                tbCalcular.Text = "";
                for (int i = 0; i < seleccionado.materias.Count; i++)
                {
                    tbCalcular.Text = seleccionado.materias.ElementAt(i) + ":" + seleccionado.calificaciones.ElementAt(i) + "\n";
                }
            }
        }

        private void btnAñadirMaterias_Click(object sender, EventArgs e)
        {
            if (seleccionado == null)
            {
                MessageBox.Show("No se selecciono un alumno!");
            }
            else
            {
                seleccionado.materias.Add(tbMaterias.Text);
                cbMaterias.Items.Add(seleccionado.materias.ElementAt(cbEstudiante.SelectedIndex));
            }
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (estudiantes.Count == 0)
            {
                MessageBox.Show("No hay elementos en la lista");
            }
            else
            {

                estudiantes.RemoveAt(cbEstudiante.SelectedIndex); 
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            seleccionado.calificaciones[cbMaterias.SelectedIndex] = float.Parse(tbCalificaciones.Text);
        }
    }
}
