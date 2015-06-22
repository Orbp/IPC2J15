using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Aplicacion.Administrador
{
    public partial class Carga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool carga()
        {
            bool archivo = false;
            if (IsPostBack)
            {
                string direccion = Server.MapPath("~/ArchivosCSV/");
                if (FileUpload1.HasFile)
                {
                    string extension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                    string[] extensiones = { ".csv", ".CSV" };
                    for (int i = 0; i < extensiones.Length; i++)
                    {
                        if (extension == extensiones[i])
                        {
                            archivo = true;
                        }
                    }
                }
                if (archivo)
                {
                    try
                    {
                        FileUpload1.PostedFile.SaveAs(direccion + FileUpload1.FileName);
                    }
                    catch(Exception e)
                    {

                    }
                }
                else
                {

                }
            }
            return archivo;
        }
        protected void BotonCargar_Click(object sender, EventArgs e)
        {
            
        }
        
        protected void cargarDatos()
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
            if (FileUpload1.HasFile)
            {
                
                string direccion = Server.MapPath(FileUpload1.FileName);
                
                Array datos;
                datos = sr.ParseoCSV(direccion);
                if (FileUpload1.FileName=="IMPUESTOS.CSV"){
                    for (int i = 0; i < datos.Length-1; i += 2)
                    {
                        if (datos.GetValue(i).ToString() != "CATEGORIA")
                        {
                            string impu = datos.GetValue(i + 1).ToString();
                            string aux = "";
                            for(int j=0; j< impu.Length-1 ; j++)
                            {
                                if (impu.Substring(j) != "%")
                                {
                                    aux += impu.Substring(j);
                                }
                            }
                            float impuesto = Convert.ToSingle(aux);
                            string categoria = datos.GetValue(i).ToString();
                            if (sr.AgregarCategoria(categoria, impuesto))
                            {
                                string script = @"<script type = 'text/javascript'> alert('Ingresado'); </script>";
                                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                            }
                            else
                            {
                                string script = @"<script type = 'text/javascript'> alert('NO Ingresado'); </script>";
                                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                            }
                        }
                    }
                }
            }
        }
    }
}