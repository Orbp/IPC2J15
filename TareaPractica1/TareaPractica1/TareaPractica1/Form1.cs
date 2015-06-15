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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegistrarLibro_Click(object sender, EventArgs e)
        {
            Form2 registar = new Form2();
            registar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegistrarMiembro_Click(object sender, EventArgs e)
        {
            Form3 registrar = new Form3();
            registrar.Show();
            this.Hide();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Form4 consulta = new Form4();
            consulta.Show();
            this.Hide();
        }

        private void BtnPrestamo_Click(object sender, EventArgs e)
        {
            Form9 prestamo = new Form9();
            prestamo.Show();
            this.Hide();
        }

        private void BTLibrosprestados_Click(object sender, EventArgs e)
        {
            Form10 lprestados = new Form10();
            lprestados.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WSTareaPractica1.Service1SoapClient wsconexion = new WSTareaPractica1.Service1SoapClient();

            string error = "";

            bool conectado = wsconexion.ProbarConexion(ref error );

            if (conectado)
            {
                MessageBox.Show("Conectado con la base de datos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(error, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
