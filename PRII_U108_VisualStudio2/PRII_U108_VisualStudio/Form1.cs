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
        Estudiante e1;
        public Form1()
        {
            InitializeComponent();
            e1 = new Estudiante();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapturarCali_Click(object sender, EventArgs e)
        {
            e1.setMatematicas(int.Parse(nudMate.Text));
            e1.setProgramacion(int.Parse(nudProg.Text));
            e1.setRed(int.Parse(nudRed.Text));
            e1.setSW(int.Parse(nudSW.Text));
            e1.setBD(int.Parse(nudBD.Text));
        }

        private void btnMaximaCal_Click(object sender, EventArgs e)
        {
            rtbDescripcion.Text = "La calificacion máxima es: \n" + e1.calMayor();
        }

        private void btnMinimaCal_Click(object sender, EventArgs e)
        {
            rtbDescripcion.Text = "La calificacion mínima es: \n" + e1.calMin();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            rtbDescripcion.Text = "El promedio del estudiante es: \n" + e1.promedio();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
