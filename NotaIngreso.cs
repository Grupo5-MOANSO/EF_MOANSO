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
    public partial class NotaIngreso : Form
    {
        public NotaIngreso()
        {
            InitializeComponent();
        }

        private void centralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
            this.Close();
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
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;

            TextBox textBoxPrecioU = new TextBox();
            textBoxPrecioU.Width = 220;
            textBoxPrecioU.Height = 50;
            textBoxPrecioU.TextChanged += textBoxPrecioU_TextChanged;

            TextBox textBoxPrecioT = new TextBox();
            textBoxPrecioT.Width = 220;
            textBoxPrecioT.Height = 50;
            textBoxPrecioT.ReadOnly = true;

            Button buttonEngranaje = new Button();
            buttonEngranaje.Text = "⚙"; 
            buttonEngranaje.Width = 180;
            buttonEngranaje.Height = 50;
            buttonEngranaje.Click += (s, ev) =>
            {
                
                ShowEngranajeMenu(s);
            };

            
            tableLayoutPanel1.RowCount += 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            
            tableLayoutPanel1.Controls.Add(comboBoxProducto, 0, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(textBoxCantidad, 1, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(textBoxPrecioU, 2, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(textBoxPrecioT, 3, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(buttonEngranaje, 4, tableLayoutPanel1.RowCount - 1);

            
            if (!tableLayoutPanel1.Visible)
            {
                tableLayoutPanel1.Visible = true;
            }
        }

        private void ShowEngranajeMenu(object sender)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Transferencia Gratuita", null, (s, ev) => { /* Código para Transferencia Gratuita */ });
            contextMenu.Items.Add("Descuento", null, (s, ev) => { /* Código para Descuento */ });
            contextMenu.Items.Add("Eliminar", null, (s, ev) => { EliminarFila(sender); });

            
            Button btn = sender as Button;
            contextMenu.Show(btn, new Point(0, btn.Height));
        }


        private void EliminarFila(object sender)
        {
            Button btn = sender as Button;
            int rowIndex = tableLayoutPanel1.GetRow(btn);

            
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                Control control = tableLayoutPanel1.GetControlFromPosition(i, rowIndex);
                tableLayoutPanel1.Controls.Remove(control);
            }

            
        }


        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            RecalcularPrecioTotal(sender);
        }

        private void textBoxPrecioU_TextChanged(object sender, EventArgs e)
        {
            RecalcularPrecioTotal(sender);
        }

        private void RecalcularPrecioTotal(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int rowIndex = tableLayoutPanel1.GetRow(textBox);

                TextBox textBoxCantidad = tableLayoutPanel1.GetControlFromPosition(1, rowIndex) as TextBox;
                TextBox textBoxPrecioU = tableLayoutPanel1.GetControlFromPosition(2, rowIndex) as TextBox;
                TextBox textBoxPrecioT = tableLayoutPanel1.GetControlFromPosition(3, rowIndex) as TextBox;

                if (int.TryParse(textBoxCantidad?.Text, out int cantidad) &&
                    decimal.TryParse(textBoxPrecioU?.Text, out decimal precioU))
                {
                    textBoxPrecioT.Text = (cantidad * precioU).ToString("0.00");
                }
                else
                {
                    textBoxPrecioT.Text = "0.00"; // Valor por defecto si algo no es válido
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Central C = new Central();
            C.Show();
            this.Close();
        }
    }
}
