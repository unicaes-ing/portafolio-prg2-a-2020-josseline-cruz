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
    public partial class ejer3 : Form
    {
        public ejer3()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double inversion1;
            double inversion2;
            double inversion3;
            double total;
            inversion1 = Convert.ToDouble(txtinversion1.Text);
            inversion2 = Convert.ToDouble(txtinversion2.Text);
            inversion3 = Convert.ToDouble(txtinversion3.Text);
            total = inversion1 + inversion2 + inversion3;
            txttotal.Text = total.ToString("N2");
            double porcentaje1;
            double porcentaje2;
            double porcentaje3;
            porcentaje1 = ((inversion1 / total) * 100);
            porcentaje2 = ((inversion2 / total) * 100);
            porcentaje3 = ((inversion3 / total) * 100);
            txtporcentaje1.Text = porcentaje1.ToString("N2") + "%";
            txtporcentaje2.Text = porcentaje2.ToString("N2") + "%";
            txtporcentaje3.Text = porcentaje3.ToString("N2") + "%";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtinversion1.Clear();
            txtinversion2.Clear();
            txtinversion3.Clear();
            txtporcentaje1.Clear();
            txtporcentaje2.Clear();
            txtporcentaje3.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
