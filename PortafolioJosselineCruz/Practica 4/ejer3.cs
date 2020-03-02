using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class ejer3 : Form
    {
        public ejer3()
        {
            InitializeComponent();
        }
        public static int Fi(int numero)
        {
            int a, b, c, tem;
            tem = numero;
            a = 0;
            b = 1;
            for (int i = 0; i < tem; i++)
            {
                c = a;
                a = b;
                b = c + a;
            }
            return a;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero, fi;
            numero = Convert.ToInt32(txtnum.Text);
            fi = Fi(numero);
            txtFibonacci.Text = string.Format("{0}", fi);
        }
    }
}
