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
    public partial class ejer1 : Form
    {
        public ejer1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Promedio;
            Promedio = ((Convert.ToDouble(txtExamen1.Text) + Convert.ToDouble(txtExamen2.Text) + Convert.ToDouble(txtExamen3.Text)) / 3.0);
            txtPromedio.Text = string.Format("{0:N2}", Promedio);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExamen1.Text = "";
            txtExamen2.Text = "";
            txtExamen3.Text = "";
            txtPromedio.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
