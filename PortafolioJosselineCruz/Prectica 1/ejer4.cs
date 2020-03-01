using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prectica_1
{
    public partial class ejer4 : Form
    {
        public ejer4()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int cant;
            double precio, subtotal, impuesto, total;
            cant = int.Parse(txtcantidad.Text);
            precio = int.Parse(txtprecio.Text);

            subtotal = cant * precio;
            impuesto = subtotal * 0.13;
            total = subtotal + impuesto;

            this.txtsubtotal.Text = subtotal.ToString();
            this.txtimpuesto.Text = impuesto.ToString();
            this.txttotal.Text = total.ToString();

        }

        private void btnnueva_Click(object sender, EventArgs e)
        {
            txtcantidad.Clear();
            txtimpuesto.Clear();
            txtprecio.Clear();
            txtsubtotal.Clear();
            txttotal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
