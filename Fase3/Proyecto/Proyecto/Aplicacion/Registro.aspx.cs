using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Aplicacion
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
            List<string> lista = new List<string>();
            lista = sr.Sucursales();
            foreach (string sucursal in lista)
            {
                DDL1.Items.Add(sucursal);
            }
        }

        protected void BTNRegistrar_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
            int dpi;
            long telefono;
            long nit;
            long tarjeta;
            if (TbNombre.Text != null)
            {
                if (TBApellido.Text != null)
                {
                    if (TBNit.Text != null && long.TryParse(TBNit.Text,out nit))
                    {
                        if (TBContraseña.Text != null)
                        {
                            if (TBDomicilio.Text != null)
                            {
                                if (TBNume.Text != null && long.TryParse(TBNume.Text, out tarjeta))
                                {
                                    if (TBTelefono.Text != null && long.TryParse(TBTelefono.Text, out telefono))
                                    {
                                        if (TBUsuario.Text != null)
                                        {
                                            if (TBDpi.Text != null && int.TryParse(TBDpi.Text, out dpi))
                                            {
                                                int sucursal = sr.Cat(DDL1.SelectedItem.ToString());
                                                if (sr.AgregarCliente(Convert.ToInt32(TBDpi.Text), TbNombre.Text, TBApellido.Text, Convert.ToInt64(TBNit.Text), Convert.ToInt64(TBTelefono.Text), TBDomicilio.Text, Convert.ToInt64(TBNume.Text), sucursal, TBUsuario.Text, TBContraseña.Text))
                                                {
                                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertlns", "alert('Datos enviados a verificacion');", true);
                                                    Response.Redirect("Default.aspx");
                                                }
                                                else
                                                {
                                                    Response.Write("ERROR");
                                                }
                                                Response.Write(TbNombre.Text + ", " + TBApellido.Text + ", " + TBContraseña.Text + ", " + TBDomicilio.Text + "," + TBDpi.Text + "," + TBNit.Text + "," + TBNume.Text  + "," + TBTelefono.Text  + "," + TBUsuario.Text +"," + sucursal );
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}