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
    public partial class RegistrarNotaSalida : Form
    {
        public RegistrarNotaSalida()
        {
            InitializeComponent();
        }

        private void linkLabelAgregarItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ComboBox comboBoxProducto = new ComboBox();
            comboBoxProducto.Width = 500;
            comboBoxProducto.Height = 50;
            comboBoxProducto.Items.AddRange(new string[] { "Faros 2024", "Parabrisa Urbano", "Fibra de Vidrio" }); // AGREGAR DESDE SQL - FALTAAAAAA
            comboBoxProducto.DropDownStyle = ComboBoxStyle.DropDownList;

            TextBox textBoxCantidad = new TextBox();
            textBoxCantidad.Width = 220;
            textBoxCantidad.Height = 50;

            
            Button buttonEngranaje = new Button();
            buttonEngranaje.Text = "⚙";
            buttonEngranaje.Width = 180;
            buttonEngranaje.Height = 50;
            buttonEngranaje.Click += (s, ev) =>
            {

                ShowEngranajeMenu(s);
            };


            tableLayoutPanelNotaSalida.RowCount += 1;
            tableLayoutPanelNotaSalida.RowStyles.Add(new RowStyle(SizeType.AutoSize));


            tableLayoutPanelNotaSalida.Controls.Add(comboBoxProducto, 0, tableLayoutPanelNotaSalida.RowCount - 1);
            tableLayoutPanelNotaSalida.Controls.Add(textBoxCantidad, 1, tableLayoutPanelNotaSalida.RowCount - 1);
            tableLayoutPanelNotaSalida.Controls.Add(buttonEngranaje, 3, tableLayoutPanelNotaSalida.RowCount - 1);


            if (!tableLayoutPanelNotaSalida.Visible)
            {
                tableLayoutPanelNotaSalida.Visible = true;
            }
        }

        private void ShowEngranajeMenu(object sender)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Eliminar", null, (s, ev) => { EliminarFila(sender); });


            Button btn = sender as Button;
            contextMenu.Show(btn, new Point(0, btn.Height));
        }

        private void EliminarFila(object sender)
        {
            Button btn = sender as Button;
            int rowIndex = tableLayoutPanelNotaSalida.GetRow(btn);


            for (int i = 0; i < tableLayoutPanelNotaSalida.ColumnCount; i++)
            {
                Control control = tableLayoutPanelNotaSalida.GetControlFromPosition(i, rowIndex);
                tableLayoutPanelNotaSalida.Controls.Remove(control);
            }


        }

     
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form ANI = new AnularNotaIngreso();
            ANI.Show();
            this.Close();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form HNI = new HistorialNotaIngreso();
            HNI.Show();
            this.Close();
        }

        private void centralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
            this.Close();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Form NS = new RegistrarNotaSalida();
            NS.Show();
            this.Close();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Form ANI = new AnularNotaSalida();
            ANI.Show();
            this.Close();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Form VI = new Inventario();
            VI.Show();
            this.Close();
        }

        private void historialDeConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HC = new HistorialConsumo();
            HC.Show();
            this.Close();
        }

        private void consultarEstadoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VI = new Inventario();
            VI.Show();
            this.Close();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Form NR = new ReporteMaterial();
            NR.Show();
            this.Close();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Form HNR = new HistorialReporteMaterial();
            HNR.Show();
            this.Close();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form NI = new NotaIngreso();
            NI.Show();
            this.Close();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form OP = new RegistroOP();
            OP.Show();
            this.Close();
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AOP = new AnularOP();
            AOP.Show();
            this.Close();
        }

        private void visualizarOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VOP = new ViewOP();
            VOP.Show();
            this.Close();
        }

        private void programaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Prog = new Programacion();
            Prog.Show();
            this.Close();
        }

        private void cronogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cron = new Cronograma();
            Cron.Show();
            this.Close();
        }

        private void pEstructuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PE = new ControlProdE();
            PE.Show();
            this.Close();
        }

        private void pFibraDeVidrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PI = new ControlProdF();
            PI.Show();
            this.Close();
        }

        private void pPintadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PP = new ControlProdP();
            PP.Show();
            this.Close();
        }

        private void pAcabadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PA = new ControlProdA();
            PA.Show();
            this.Close();
        }

        private void verificaciónDeCalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CAL = new VerificacionCalidad();
            CAL.Show();
            this.Close();
        }

        private void incidenciaDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form IPRO = new IncidenciasProd();
            IPRO.Show();
            this.Close();
        }

        private void incidenciaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ICAL = new IncidenciaCalidad();
            ICAL.Show();
            this.Close();
        }

        private void pedidoDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SA = new SubAreas();
            SA.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Central central = new Central();
            central.Show();
            this.Close();
        }
    }
}
