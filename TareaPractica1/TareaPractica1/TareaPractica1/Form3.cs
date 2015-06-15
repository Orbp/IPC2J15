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
    public partial class Form3 : Form
    {
        string nombre = "";
        int dpi = 0;
        string direccion = "";
        int telefono = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void BTNRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea regresar a la ventana de inicio sin guardar los cambios?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();
                Form1 inicio = new Form1();
                inicio.Show();
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea limpiar los campos sin guardar los cambios?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                nombre = "";
                direccion = "";
                telefono = 0;
                dpi = 0;
                TBDireccion.Text = "";
                TBDpi.Text = "";
                TBNombreCliente.Text = "";
                TBTelefono.Text = "";
            }
        }

        private void BtnGuardarLibro_Click(object sender, EventArgs e)
        {
            if (!TBNombreCliente.Text.Equals("") || !TBNombreCliente.Text.Equals(" ") || !TBNombreCliente.Text.Equals(null))
            {
                nombre = TBNombreCliente.Text;
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre en el campo de nombre", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!TBDireccion.Text.Equals("") || !TBDireccion.Text.Equals(" ") || !TBDireccion.Text.Equals(null))
            {
                direccion = TBDireccion.Text;
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre en el campo de dirección", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Int32.TryParse(TBDpi.Text, out dpi))
            {
                dpi = int.Parse(TBDpi.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar un dato númerico en el campo del DPI", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Int32.TryParse(TBTelefono.Text, out telefono))
            {
                telefono = int.Parse(TBTelefono.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar un dato númerico en el campo del teléfono", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*Espacio para insertar en la base de datos*/

            nombre = "";
            direccion = "";
            dpi = 0;
            telefono = 0;
            TBDireccion.Text = "";
            TBDpi.Text = "";
            TBNombreCliente.Text = "";
            TBTelefono.Text = "";
        }
    }
}
