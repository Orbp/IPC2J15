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
                                                dpi = int.Parse(TBDpi.Text);
                                                telefono = long.Parse(TBTelefono.Text);
                                                nit = long.Parse(TBNit.Text);
                                                tarjeta = long.Parse(TBNume.Text);

                                                if (sr.RegistrarCliente(dpi, TbNombre.Text, TBApellido.Text, nit, telefono, TBDomicilio.Text, tarjeta, TBUsuario.Text, TBContraseña.Text, DDL1.SelectedItem.ToString()));
                                                {
                                                    TBApellido.Text=null;
                                                    TBContraseña.Text=null;
                                                    TBDomicilio.Text=null;
                                                    TBDpi.Text=null;
                                                    TBNit=null;
                                                    TbNombre = null;
                                                    TBNume= null;
                                                    TBTelefono= null;
                                                    TBUsuario= null;
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
}