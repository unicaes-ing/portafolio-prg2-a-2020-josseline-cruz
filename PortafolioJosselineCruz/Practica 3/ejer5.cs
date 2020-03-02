using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class ejer5 : Form
    {
        public ejer5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtnombre.Text;
                int horas;
                double valorhora, subtotal, impuesto, total;
                horas = Convert.ToInt32(txthoras.Text);
                valorhora = Convert.ToDouble(txtvalor.Text);
                subtotal = horas * valorhora;
                impuesto = subtotal * 0.13;
                total = subtotal - impuesto;
                dgvplanilla.Rows.Add(nombre, horas, valorhora, subtotal, impuesto, total);
                dgvplanilla.ClearSelection();
                lblsubtotal.HeaderText = "Subtotal=$" + subtotal.ToString("N2");
                lblimpuesto.HeaderText = "Impuesto=$" + impuesto.ToString("N2");
                lbltotal.HeaderText = "Total=$" + total.ToString("N2");

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los datos,Todos los campos son obligatorios");

            }

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtvalor.Clear();
            txthoras.Clear();
        }
    }
}
