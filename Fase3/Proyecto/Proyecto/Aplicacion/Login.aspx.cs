using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Aplicacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool autenticado = false;
            autenticado = Aprobado(Login1.UserName, Login1.Password);
            e.Authenticated = autenticado;
            if (autenticado)
            {
                Response.Redirect("Inicio.aspx");
                Response.Write(Session["Onl"]);
            }
        }

        private bool Aprobado(string pnombre, string pcontraseña)
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
            int Empleado = sr.DevolverEmpleado(pnombre, pcontraseña);
            int Cliente = sr.DevolverCliente(pnombre, pcontraseña);
            int Director = sr.DevolverDirector(pnombre, pcontraseña);
            int Admin = sr.DevolverAdministrador(pnombre, pcontraseña);
            if (Empleado > 0)
            {
                Session["Onl"] = Empleado;
                Session["Tipo"] = 1;
                return true;
            }
            else
            {
                if (Cliente > 0)
                {
                    Session["Onl"] = Cliente;
                    Session["Tipo"] = 2;
                    return true;
                }
                else
                {
                    if (Director > 0)
                    {
                        Session["Onl"] = Director;
                        Session["Tipo"] = 3;
                        return true;
                    }
                    else
                    {
                        if (Admin > 0)
                        {
                            Session["Onl"] = Admin;
                            Session["Tipo"] = 4;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
            
        }
    }
}