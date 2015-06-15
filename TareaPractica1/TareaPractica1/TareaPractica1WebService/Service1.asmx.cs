using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TareaPractica1WebService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        string CadenaConexion = "Data Source=OSCARROLANDO;Initial Catalog=TareaPractica1;Integrated Security=True";

        SqlConnection conexioSql = null;

        [WebMethod]
        public bool ProbarConexion(ref string error)
        {
            conexioSql = new SqlConnection(CadenaConexion);

            try
            {
                conexioSql.Open();
                return true;
            }
            catch (SqlException e)
            {
                error = "No se pudo establecer la conexion " + e.Message.ToString();
                return false;
            }

            finally
            {
                if (conexioSql != null)
                {
                    conexioSql.Close();
                }
            }
        }


        [WebMethod]
        public bool AgregarLibro(string pnombre, int pnumex, int pnumpag, string pautor, string ptema)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "INSERT Libro (Nombre_libro, Num_Existencias, Num_Paginas, Autor_libro, Tema_libro) VALUES ('" + pnombre + "'," + pnumex +
                "," + pnumpag + ",'" + pautor + "','" + ptema + "')";

            conexioSql = new SqlConnection(CadenaConexion);
            comando.Connection = conexioSql;

            conexioSql.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            conexioSql.Close();
        }

        [WebMethod]
        public bool AgregarCliente()
        {

            return true;
        }
    }
}