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
    public partial class SolicitudMaterial : Form
    {
        public SolicitudMaterial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
            this.Close();
        }

        private void moduloDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SA = new SubAreas();
            SA.Show();
            this.Close();
        }

        private void moduloDeProduccionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form SA = new SubAreas();
            SA.Show();
            this.Close();
        }

        private void moduloDeProduccionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form SA = new SubAreas();
            SA.Show();
            this.Close();
        }

        private void moduloDeProduccionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form SA = new SubAreas();
            SA.Show();
            this.Close();
        }
    }
}
