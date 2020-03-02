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
    public partial class ejer2 : Form
    {
        public ejer2()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            lstletras.ForeColor = Color.Blue;
            lstletras.Font = new Font("Arial", 18, FontStyle.Bold);
            lstletras.Items.Clear();
            for (char letras = 'A'; letras <= 'Z'; letras++)
            {
                lstletras.Items.Add(letras);
            }
            lstletras.Items.Insert(14, 'Ñ');
        }
    }
}
