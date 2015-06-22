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
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
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

        }
    }
}