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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void BTRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.Show();
        }

        private void BTPrestar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 prestar = new Form6();
            prestar.Show();
        }

        private void BTDevolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 Devolver = new Form7();
            Devolver.Show();
        }

        private void BTReservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 Reservar = new Form8();
            Reservar.Show();
        }
    }
}
