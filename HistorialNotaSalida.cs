using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_Semana_02___Moanso
{
    public partial class HistorialNotaSalida : Form
    {
        public HistorialNotaSalida()
        {
            InitializeComponent();
        }

        private void centralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form C = new Central();
            C.Show();
            this.Close();
        }

        private void registrarNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NI = new NotaIngreso();
            NI.Show();
            this.Close();
        }

        private void anularNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ANI = new AnularNotaIngreso();
            ANI.Show();
            this.Close();
        }

        private void historialNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HNI = new HistorialNotaIngreso();
            HNI.Show();
            this.Close();
        }

        private void registrarNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NS = new RegistrarNotaSalida();
            NS.Show();
            this.Close();
        }

        private void anularNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ANS = new AnularNotaSalida();
            ANS.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
            this.Close();
        }
    }
}
