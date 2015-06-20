using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Aplicacion
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Onl"] == null){

            }
        }

        protected void btn_cerrar_Click(object sender, EventArgs e)
        {
            Session["Onl"] = null;
            Response.Redirect("~/Default.aspx");
        }
    }
}