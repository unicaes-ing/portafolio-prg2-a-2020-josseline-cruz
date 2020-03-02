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
    public partial class ejer3 : Form
    {
        public ejer3()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int C = 0;
            lstNumero.Items.Clear();
            for (int i = 1; i < 50000; i++)
            {
                int num = r.Next(1, 7);
                lstNumero.Items.Add(num);
                if (num == 6) C++;

            }
            MessageBox.Show("Se obtuvo" + C + "veces el 6");
        }
    }
}
