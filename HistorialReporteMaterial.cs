﻿using System;
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
    public partial class HistorialReporteMaterial : Form
    {
        public HistorialReporteMaterial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
            this.Close();
        }
    }
}
