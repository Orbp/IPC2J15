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
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<string> datos = new List<string>();
            datos = sr.DevolverDatosCliente(Convert.ToInt32(Session["Onl"]));
            TBNombre.Text = datos[0];
            TBApellido.Text = datos[1];
            TBNit.Text = datos[2];
            TBTelefono.Text = datos[3];
            TBDireccion.Text = datos[4];
            TBNume.Text = datos[5];
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
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