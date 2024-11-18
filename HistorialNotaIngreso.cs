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
    public partial class HistorialNotaIngreso : Form
    {
        public HistorialNotaIngreso()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form NI = new NotaIngreso();
            NI.Show();
            this.Close(); 
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form ANI = new AnularNotaIngreso();
            ANI.Show();
            this.Hide();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form HNI = new HistorialNotaIngreso();
            HNI.Show();
            this.Close();
        }

        private void centralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Central central = new Central();
            central.Show();
            this.Close();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form RNS = new RegistrarNotaSalida();
            RNS.Show();
            this.Close();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form ANS = new AnularNotaSalida();
            ANS.Show();
            this.Close();
        }

        private void historialDeNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HNS = new HistorialNotaSalida();
            HNS.Show();
            this.Close();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GMAT = new GestionMateriales();
            GMAT.Show();
            this.Close();
        }
    }
}
