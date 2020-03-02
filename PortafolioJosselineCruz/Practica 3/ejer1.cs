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
    public partial class ejer1 : Form
    {
        public ejer1()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
			int nt;
			if (int.TryParse(txtnumero.Text, out nt))
			{
				lstTabla.Items.Clear();
				for (int i = 1; i <= 10; i++)

				{
					lstTabla.Items.Add(nt + "*" + i + "=" + nt * 1);
				}
			}
			else
			{
				MessageBox.Show("Ingrese un numero");
			}
		}
    }
}
