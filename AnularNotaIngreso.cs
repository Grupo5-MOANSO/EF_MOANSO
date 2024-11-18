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
    public partial class AnularNotaIngreso : Form
    {
        public AnularNotaIngreso()
        {
            InitializeComponent();
        }

        private void registrarNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RegistrarNI = new NotaIngreso();
            RegistrarNI.Show();
            this.Close();
        }

        private void historialNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HistoryNI = new HistorialNotaIngreso();
            HistoryNI.Show();
            this.Close();
        }

        private void centralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
            this.Close();
        }

        private void registrarNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form REGISTRARNS= new RegistrarNotaSalida();
            REGISTRARNS.Show();
            this.Close();
        }

        private void historialNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HISTORIAL =new HistorialNotaSalida();
            HISTORIAL.Show();
            this.Close();
        }

        private void anularNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ANULARI = new AnularNotaIngreso();
            ANULARI.Show();
            this.Close();
        }

        private void anularNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ANULARS = new AnularNotaSalida();
            ANULARS.Show();
            this.Close();
        }

        private void visualizarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form REGISTRARNS= new RegistrarNotaSalida();
            REGISTRARNS.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form REGISTRAR = new NotaIngreso();
            REGISTRAR.Show(); 
            this.Close();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form ANULAR = new AnularNotaIngreso();
            ANULAR.Show();
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form HISTORIAL = new HistorialNotaIngreso();
            HISTORIAL.Show();
            this.Close();
                
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form ANULARNS = new AnularNotaSalida();
            ANULARNS.Show();
            this.Close();
        }

        private void historialDeNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HISTORIAL = new HistorialNotaSalida();
            HISTORIAL.Show();
            this.Close();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GESTIONAR = new GestionMateriales();
            GESTIONAR.Show();
            this.Close();
        }

        private void visualizarInventaioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VISUALIZAR = new Inventario();
            VISUALIZAR.Show();
            this.Close();
        }

        private void historialDeConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CONSUMO = new HistorialConsumo();
            CONSUMO.Show();
            this.Close();
        }

        private void consultarEstadoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ESTADO = new Inventario();
            ESTADO.Show();
            this.Close();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Form REPORTE = new ReporteMaterial();
            REPORTE.Show();
            this.Close();
        }

        private void historialDeReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HISTORIALREPORTE = new HistorialReporteMaterial(); 
            HISTORIALREPORTE.Show();
            this.Close();
        }

        private void centralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
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

        private void centralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Central central = new Central();
            central.Show();
            this.Close();
        }
    }
}
