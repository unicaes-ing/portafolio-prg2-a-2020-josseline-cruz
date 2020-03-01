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
    public partial class ejer2 : Form
    {
        public ejer2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            long n = Convert.ToInt32(txtdecimal.Text);
            if (n < 0)
            {
                MessageBox.Show("ERROR! estimado usuario la conversion solo se puede hacer con numeros positivos", "Valores no validos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdecimal.Text = " ";
                txtbinario.Text = " ";
                txtoctal.Text = " ";
                txthexadecimal.Text = " ";
            }
            else
            {
                txtbinario.Text = Convert.ToString(n, 2);
                txtoctal.Text = Convert.ToString(n, 8);
                txthexadecimal.Text = Convert.ToString(n, 16);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdecimal.Clear();
            txtbinario.Clear();
            txtoctal.Clear();
            txthexadecimal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
