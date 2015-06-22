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
            if (FileUpload1.HasFile)
            {
                string direccion = Server.MapPath("~/ArchivosCSV/");
                
            }
        }
    }
}