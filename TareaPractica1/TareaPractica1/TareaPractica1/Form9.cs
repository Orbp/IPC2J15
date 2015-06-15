using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaPractica1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void BTRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea regresar al inicio?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.Show();
            }
        }

        private void BTContinuar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos del cliente son los correctos?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                Form5 prest = new Form5();
                prest.Show();
            }    
        }
    }
}
