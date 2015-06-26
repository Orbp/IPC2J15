using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Aplicacion
{
    public partial class Cotizar : System.Web.UI.Page
    {
        List<string> lista = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient sr = new ServiceReference1.Service1SoapClient();
            lista = sr.Categorias();
            foreach (string categoria in lista)
            {
                DDLCategoria.Items.Add(categoria);
            }
        }

        protected void BTCotizar_Click(object sender, EventArgs e)
        {
            float precio = 0;
            int peso = 0;
            float preciototal = 0;
            float cat = 0;

            if (Single.TryParse(TBPrecio.Text, out precio))
            {
                precio = Single.Parse(TBPrecio.Text);
            }
            if (Int32.TryParse(TBPeso.Text, out peso))
            {
                peso = int.Parse(TBPeso.Text);
            }
            string impuesto = DDLCategoria.SelectedItem.ToString();
            string[] aux = impuesto.Split('-');
            float imp = float.Parse(aux[1]);
            float auxprecio = (precio * imp) / 100;
            preciototal = precio + (peso * 5) + auxprecio;
            LblPrecio.Text = preciototal.ToString();
        }
    }
}