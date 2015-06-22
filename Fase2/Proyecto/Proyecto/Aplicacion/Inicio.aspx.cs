using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Aplicacion
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["Tipo"]) == 1)
            {
                PEmpleado.Visible = true;
                PCliente.Visible = false;
                pDirector.Visible = false;
                pAdmin.Visible = false;
            }
            else
            {
                if (Convert.ToInt32(Session["Tipo"]) == 2)
                {
                    PEmpleado.Visible = false;
                    PCliente.Visible = true;
                    pDirector.Visible = false;
                    pAdmin.Visible = false;
                }
                else
                {
                    if (Convert.ToInt32(Session["Tipo"]) == 3)
                    {
                        PEmpleado.Visible = false;
                        PCliente.Visible = false;
                        pDirector.Visible = true;
                        pAdmin.Visible = false;
                    }
                    else
                    {
                        if (Convert.ToInt32(Session["Tipo"]) == 4)
                        {
                            PEmpleado.Visible = false;
                            PCliente.Visible = false;
                            pDirector.Visible = false;
                            pAdmin.Visible = true;
                        }
                    }
                }
            }
        }
    }
}