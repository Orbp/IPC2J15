using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Aplicacion
{
    public partial class Perfil : System.Web.UI.Page
    {
        ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
        bool actual = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            TBNombre.Text = TBNombre.Text;
            TBApellido.Text = TBApellido.Text;
            TBNit.Text = TBNit.Text;
            TBTelefono.Text = TBTelefono.Text;
            TBDireccion.Text = TBDireccion.Text;
            TBNume.Text = TBNume.Text;
            List<string> datos = new List<string>();
            datos = sr.DevolverDatosCliente(Convert.ToInt32(Session["Onl"]));
            LBLNombre.Text = datos[0];
            LBLApellido.Text = datos[1];
            LBLNit.Text = datos[2];
            LBLTelefono.Text = datos[3];
            LBLDireccion.Text = datos[4];
            LBLNume.Text = datos[5];
        }

        protected void cargar()
        {
            
        }
        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            actual = true;
            Page_Load(this, e);
            string n = TBNombre.Text;
            Response.Write(n);
            if (sr.actualizarCliente(Convert.ToInt32(Session["Onl"]), n, TBApellido.Text, TBNit.Text, TBTelefono.Text, TBDireccion.Text, TBNume.Text) == 1)
            {

            }
            else
            {
                Response.Write("ERROR");
            }
            
        }
    }
}