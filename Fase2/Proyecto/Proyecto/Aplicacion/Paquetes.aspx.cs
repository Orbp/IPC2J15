using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Aplicacion
{
    public partial class Paquetes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
            LabelNombre.Text = LabelNombre.Text + sr.DevolverNombreCliente(Convert.ToInt32(Session["Onl"]));
            LabelCasilla.Text= Convert.ToString(sr.DevolverCasillaCliente(Convert.ToInt32(Session["Onl"])));

        }
    }
}