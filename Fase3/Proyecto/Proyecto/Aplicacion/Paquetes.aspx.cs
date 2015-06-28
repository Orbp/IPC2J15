using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.ServiceReference1;

namespace Proyecto.Aplicacion
{
    public partial class Paquetes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
            Response.Write(Convert.ToInt32(Session["Onl"]));
            int num = Convert.ToInt32(Session["Onl"]);
            LabelNombre.Text += sr.DevolverNombreCliente(num);

            
        }
    }
}