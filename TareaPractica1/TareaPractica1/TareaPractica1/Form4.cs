﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void BTConsultar_Click(object sender, EventArgs e)
        {
            WSTareaPractica1.Service1SoapClient ws = new WSTareaPractica1.Service1SoapClient();
            ws.busqueda(textBox1.Text);
        }
    }
}
