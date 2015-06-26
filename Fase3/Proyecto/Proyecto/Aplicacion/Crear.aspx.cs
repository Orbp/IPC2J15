using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Aplicacion
{
    public partial class Crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
            List<string> cate = sr.Categorias();
            List<string> sucur = sr.Sucursales();
            foreach (string categoria in cate)
            {
                DDLCategoria.Items.Add(categoria);
            }
            foreach (string sucursal in sucur)
            {
                DDLSucursal.Items.Add(sucursal);
            }
        }

        protected void BTNAceptar_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
            double precio = 0;
            int libraje = 0;
            string comision = "";
            double com = 0;
            double precionimpu = 0;
            double preciototal = 0;
            float impuesto = 0;

            if (TBPrecio.Text != null || double.TryParse(TBPrecio.Text,out precio))
            {
                if (TBLibraje.Text != null || int.TryParse(TBLibraje.Text, out libraje))
                {
                    if (!DDLCategoria.SelectedItem.ToString().Equals("No Seleccionado"))
                    {
                        if (!DDLSucursal.SelectedItem.ToString().Equals("No Seleccionado"))
                        {
                            if (!DDLMoneda.SelectedItem.ToString().Equals("Moneda"))
                            {
                                int sede = sr.ObtenerSede(DDLSucursal.SelectedItem.ToString());
                                comision = sr.ObtenerComision(sede);
                                Response.Write(comision);
                                com = Convert.ToDouble(comision);
                                string[] auximpu = DDLCategoria.SelectedItem.ToString().Split('-');
                                impuesto=float.Parse(auximpu[1]);
                                precio = Convert.ToDouble(TBPrecio.Text);
                                libraje = Int32.Parse(TBLibraje.Text);
                                if (TBNombre.Text != null)
                                {
                                    if (TBDescripcion.Text != null)
                                    {
                                        if (DDLMoneda.SelectedItem.ToString().Equals("$"))
                                        {

                                            precio = precio * 7.9;
                                            libraje = libraje * 5;
                                            precionimpu = (precio * impuesto) + precio;
                                            preciototal = libraje + precionimpu;
                                            Label7.Text = Convert.ToString(preciototal);
                                            Random r = new Random();
                                            int lote = r.Next(100);
                                            int categoria = sr.ObtenerCategoria(auximpu[0], impuesto);
                                            int sucursal = sr.Cat(DDLSucursal.SelectedItem.ToString());
                                            precio = preciototal * com;
                                            preciototal = precio + preciototal;
                                            if (sr.AgregarPaquete(TBNombre.Text, TBDescripcion.Text, categoria, Convert.ToInt32(Session["Onl"]), Convert.ToSingle(preciototal), libraje, sucursal, lote))
                                            {
                                               Response.Redirect("Inicio.aspx");
                                            }
                                            else
                                            {
                                                Response.Write("ERROR");
                                            }
                                        }
                                        else
                                        {
                                            libraje = libraje * 5;
                                            precionimpu = (precio * impuesto) + precio;
                                            preciototal = libraje + precionimpu;
                                            Label7.Text = Convert.ToString(preciototal);
                                            Random r = new Random();
                                            int lote = r.Next(100);
                                            int categoria = sr.ObtenerCategoria(auximpu[0], impuesto);
                                            int sucursal = sr.Cat(DDLSucursal.SelectedItem.ToString());
                                            precio = preciototal * com;
                                            preciototal = precio + preciototal;
                                            if (sr.AgregarPaquete(TBNombre.Text, TBDescripcion.Text, categoria, Convert.ToInt32(Session["Onl"]), Convert.ToSingle(preciototal), libraje, sucursal, lote))
                                            {
                                                Response.Redirect("Inicio.aspx");
                                            }
                                            else
                                            {
                                                Response.Write("ERROR");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Response.Write("No hay descripcion");
                                    }
                                }
                                else
                                {
                                    Response.Write("No hay nombre");
                                }
                            }
                            else
                            {
                                Response.Write("Debe seleccionar un tipo de moneda");
                            }
                        }
                        else
                        {
                            Response.Write("Debe seleccionar una sucursal");
                        }
                    }
                    else
                    {
                        Response.Write("Debe seleccionar una categoria");
                    }
                }
                else
                {
                    Response.Write("Debe escribir un libraje");
                }
            }
            else
            {
                Response.Write("Debe escribir un precio");
            }
        }
    }
}