using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha pulsado el primer/ultimo boton");
        }

        private void ocultarBarraDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStrip1.Hide();
        }

        private void verBarraDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStrip1.Show();
        }
    }
}
