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
    public partial class Form2 : Form
    {
        string nombre;
        int numeroexis;
        int numeropag = new int();
        string tema;
        string autor;
        bool haynombre = false;
        bool haynumexis = false;
        bool haynumpag = false;
        bool haytema = false;
        bool hayautor = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void BTNRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea regresar al inicio sin guardar sus cambios?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 Inicio = new Form1();
                Inicio.Show();
            }
        }

        private void BtnGuardarLibro_Click(object sender, EventArgs e)
        {
            numeroexis = 0;
            if (!TBNombreLibro.Text.Equals("") || !TBNombreLibro.Text.Equals(" ") || !TBNombreLibro.Text.Equals(null))
            {
                nombre = TBNombreLibro.Text;
                haynombre = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre valido para el nombre", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (Int32.TryParse(TBNumero_existenciaslibros.Text, out numeroexis))
            {
                numeroexis = int.Parse(TBNumero_existenciaslibros.Text);
                haynumexis = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar un número en el campo del número de existencias", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Int32.TryParse(TBNumero_paginas.Text, out numeropag))
            {
                numeropag = int.Parse(TBNumero_paginas.Text);
                haynumpag = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar un número en el campo del número de páginas", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!TBTemaLibro.Text.Equals("") || !TBTemaLibro.Text.Equals(" ") || !TBTemaLibro.Text.Equals(null))
            {
                tema = TBTemaLibro.Text;
                haytema = true;
            }
            else
            {
                if (radioButton1.Checked && !CBTemaLibro.SelectedItem.Equals(null))
                {
                    tema = CBTemaLibro.SelectedText;
                    haytema = true;
                }
                else
                {
                    MessageBox.Show("Debe ingresar o seleccionar un tema para el libro que desea registrar", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (!TBAutorLibro.Text.Equals("") || !TBAutorLibro.Text.Equals(" ") || !TBAutorLibro.Text.Equals(null))
            {
                autor = TBAutorLibro.Text;
                hayautor = true;
            }
            else
            {
                if (radioButton2.Checked && !CBAutorLibro.SelectedItem.Equals(null))
                {
                    autor = CBAutorLibro.SelectedText;
                    hayautor = true;
                }
                else
                {
                    if (MessageBox.Show("Usted no asigno un autor para este libro, automaticamente el sistema le asignará Anónimo", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        autor = "Anónimo";
                        hayautor = true;
                    }
                }
            }

            /*Espacio para insertar en la base de datos*/

            nombre = "";
            numeroexis = 0;
            numeropag = 0;
            tema = "";
            autor = "";
            hayautor = false;
            haynombre = false;
            haynumexis = false;
            haynumpag = false;
            haytema = false;
            TBAutorLibro.Text = "";
            TBNombreLibro.Text = "";
            TBNumero_existenciaslibros.Text = "";
            TBNumero_paginas.Text = "";
            TBTemaLibro.Text = "";
            if (radioButton1.Checked)
            {
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked)
            {
                radioButton2.Checked = false;
            }
            CBAutorLibro.Visible = false;
            CBTemaLibro.Visible = false;
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desa borrar los cambios hechos en los campos?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                nombre = "";
                numeroexis = 0;
                numeropag = 0;
                tema = "";
                autor = "";
                hayautor = false;
                haynombre = false;
                haynumexis = false;
                haynumpag = false;
                haytema = false;
                TBAutorLibro.Text = "";
                TBNombreLibro.Text = "";
                TBNumero_existenciaslibros.Text = "";
                TBNumero_paginas.Text = "";
                TBTemaLibro.Text = "";
                if (radioButton1.Checked)
                {
                    radioButton1.Checked = false;
                }
                if (radioButton2.Checked)
                {
                    radioButton2.Checked = false;
                }
                CBAutorLibro.Visible = false;
                CBTemaLibro.Visible = false;
            }
        }
    }
}
