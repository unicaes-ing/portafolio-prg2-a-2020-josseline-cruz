using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class ejer2 : Form
    {
        public ejer2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int cant = 0;
                double precio, descuento = 0, sub, total = 0;
                cant = Convert.ToInt32(txtcant.Text);
                precio = Convert.ToDouble(txtprecio.Text);

                if (rdodesc1.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.0;
                    total = sub - descuento;
                }
                else if (rdodesc2.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.05;
                    total = sub - descuento;
                }
                else if (rdodesc3.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.10;
                    total = sub - descuento;
                }
                else if (rdodesc3.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.15;
                    total = sub - descuento;
                }
                else if (rdodesc5.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.20;
                    total = sub - descuento;
                }
                txtdesc.Text = string.Format("{0:C2}", descuento);
                txttotal.Text = string.Format("{0:C2}", total);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcant.Clear();
            txtprecio.Clear();
            txtdesc.Clear();
            txttotal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
