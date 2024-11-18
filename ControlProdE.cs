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
    public partial class ControlProdE : Form
    {
        public ControlProdE()
        {
            InitializeComponent();
        }

        private void registrarNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NI = new NotaIngreso();
            NI.Show();
            this.Close();
        }

        private void anularNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AnularNI = new AnularNotaIngreso();
            AnularNI.Show();
            this.Close();
        }

        private void historialNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HistoryNI = new HistorialNotaIngreso();
            HistoryNI.Show();
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

        private void historialDeNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HNS = new HistorialNotaSalida();
            HNS.Show();
            this.Close();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GESTION = new GestionMateriales();
            GESTION.Show();
            this.Close();
        }

        private void visualizarInventaioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form VI = new Inventario();
            VI.Show();
            this.Close();
        }

        private void historialDeConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HConsumo = new HistorialConsumo();
            HConsumo.Show();
            this.Close();
        }

        private void consultarEstadoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ESTADO = new Inventario();
            ESTADO.Show();
            this.Close();
        }

        private void nuevoReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NREPORTE = new ReporteMaterial();
            NREPORTE.Show();
            this.Close();
        }

        private void historialDeReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HREPORTE = new HistorialReporteMaterial();
            HREPORTE.Show();
            this.Close();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form REGISTRAR = new RegistroOP();
            REGISTRAR.Show();
            this.Close();
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ANULAR = new AnularOP();
            ANULAR.Show();
            this.Close();
        }

        private void visualizarOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VISUALIZAR = new ViewOP();
            VISUALIZAR.Show();
            this.Close();
        }

        private void programaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PROGRAMACION = new Programacion();
            PROGRAMACION.Show();
            this.Close();
        }

        private void cronogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CRONOGRAMA = new Cronograma();
            CRONOGRAMA.Show();
            this.Close();
        }

        private void pEstructuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PESTRUCTURA = new ControlProdE();
            PESTRUCTURA.Show();
            this.Close();
        }

        private void pFibraDeVidrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PFIBRA = new ControlProdF();
            PFIBRA.Show();
            this.Close();
        }

        private void pPintadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PPINTADO = new ControlProdP();
            PPINTADO.Show();
            this.Close();
        }

        private void pAcabadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PACABADO = new ControlProdA();
            PACABADO.Show();
            this.Close();
        }

        private void verificaciónDeCalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VERIFICACION = new VerificacionCalidad();
            VERIFICACION.Show();
            this.Close();
        }

        private void incidenciaDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form IPRODUCCION = new IncidenciasProd();
            IPRODUCCION.Show();
            this.Close();
        }

        private void incidenciaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ICALIDAD = new IncidenciaCalidad();
            ICALIDAD.Show();
            this.Close();
        }

        private void pedidoDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PEDIDOMATERIAL = new SubAreas();
            PEDIDOMATERIAL.Show();
            this.Close();
        }

        private void centralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
            this.Close();
        }

        private void centralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Central central = new Central();
            central.Show();
            this.Close();
        }
    }
}
