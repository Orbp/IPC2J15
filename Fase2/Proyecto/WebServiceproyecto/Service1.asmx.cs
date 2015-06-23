using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.IO;

namespace WebServiceproyecto
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
        string CadenaConexion = "Data Source=OSCARROLANDO;Initial Catalog=PROYECTOIPC2J2015;Integrated Security=True";
        SqlConnection conexion = null;

        [WebMethod]
        public int DevolverEmpleado(string usuario, string contraseña)
        {
            int us = -1;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT Numero_de_identificacion FROM Empleado WHERE Usuario = '" + usuario + "' AND Contraseña = '" + contraseña + "' AND Rol = 'Empleado'";
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    us = lector.GetInt32(0);
                }
            }
            lector.Close();
            conexion.Close();
            return us;
        }

        [WebMethod]
        public int DevolverCliente(string usuario, string contraseña)
        {
            int us = -1;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT DPI FROM Cliente WHERE Usuario = '" + usuario + "' AND Contraseña = '" + contraseña + "'";
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    us = lector.GetInt32(0);
                }
            }
            lector.Close();
            conexion.Close();
            return us;
        }

        [WebMethod]
        public int DevolverDirector(string usuario, string contraseña)
        {
            int us = -1;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT Numero_de_identificacion FROM Empleado WHERE Usuario = '" + usuario + "' AND Contraseña = '" + contraseña + "' AND Rol = 'Director'";
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    us = lector.GetInt32(0);
                }
            }
            lector.Close();
            conexion.Close();
            return us;
        }

        [WebMethod]
        public int DevolverAdministrador(string usuario, string contraseña)
        {
            int us = -1;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT Numero_de_identificacion FROM Empleado WHERE Usuario = '" + usuario + "' AND Contraseña = '" + contraseña + "' AND Rol = 'Administrador'";
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    us = lector.GetInt32(0);
                }
            }
            lector.Close();
            conexion.Close();
            return us;
        }

        [WebMethod]
        public string DevolverNombreCliente(int pDPI)
        {
            string nombre = "";
            string apellido = "";
            SqlCommand comando= new SqlCommand();
            SqlCommand comando1 = new SqlCommand();
            comando.CommandText="SELECT Nombre FROM Cliente WHERE DPI = " + pDPI;
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    nombre = lector.GetString(0);
                }
            }
            lector.Close();
            conexion.Close();
            return nombre;
        }

        [WebMethod]
        public string DevolverNombreEmpleado(int pNumero)
        {
            string nombre = "";
            string apellido = "";
            SqlCommand comando = new SqlCommand();
            SqlCommand comando1 = new SqlCommand();
            comando.CommandText = "SELECT Nombre FROM Empleado WHERE Numero_de_identificacion = " + pNumero;
            comando1.CommandText = "SELECT Apellido FROM Empleado WHERE Numero_de_identificacion = " + pNumero;
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            comando1.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    nombre = lector.GetString(1);
                }
            }
            lector.Close();
            SqlDataReader lector1 = comando.ExecuteReader();
            if (lector1.HasRows)
            {
                while(lector1.Read()){
                    apellido = lector1.GetString(2);
                }
            }
            lector1.Close();
            conexion.Close();
            nombre += apellido;
            return nombre;
        }

        [WebMethod]
        public int DevolverCasillaCliente(int pDPI)
        {
            int casilla = 0;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select Casilla From Cliente where DPI = " + pDPI;
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    casilla = lector.GetInt32(7);
                }
            }
            lector.Close();
            conexion.Close();
            return casilla;
        }

        [WebMethod]
        public List<string[]> ParseoCSV(string direccion)
        {
            List<string[]> datosparseados = new List<string[]>();
            using (StreamReader Leerarchivo = new StreamReader(direccion))
            {
                string linea;
                string[] columna;

                while ((linea = Leerarchivo.ReadLine()) != null)
                {
                    columna = linea.Split(',');
                    datosparseados.Add(columna);
                }
            }
            return datosparseados;
        }

        [WebMethod]
        public bool AgregarCategoria(string categoria, float porcentaje)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText="INSERT Categoria(Nombre_categoria, Valor_Impuesto) VALUES ('" + categoria + "', " +porcentaje+")";
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                conexion.Close();
                return true;
                
            }
            else
            {
                conexion.Close();
                return false;
                
            }
            
        }

        [WebMethod]
        public List<string> Categorias()
        {
            List<string> cat = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * FROM Categoria";
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            string nombre = "";
            string valor = "";
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    nombre = lector.GetString(1);
                    valor = (lector.GetDouble(2).ToString());
                    cat.Add(nombre + "-" + valor);
                }
            }
            return cat;
        }

        [WebMethod]
        public List<string> DevolverDatosCliente(int pDPI)
        {
            List<string> datos = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select Nombre, Apellido, NIT, Telefono, Domicilio, Tarjeta From Cliente Where DPI = " + pDPI;
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    datos.Add(lector.GetString(0));
                    datos.Add(lector.GetString(1));
                    datos.Add(Convert.ToString(lector.GetInt64(2)));
                    datos.Add(Convert.ToString(lector.GetInt64(3)));
                    datos.Add(lector.GetString(4));
                    datos.Add(Convert.ToString(lector.GetInt64(5)));
                }
            }
            return datos;
        }

        [WebMethod]
        public int  actualizarCliente(int pDPI, string pnombre, string papellido, string pnit, string ptelefono, string pdir, string ptar)  
        {
            SqlCommand comando = new SqlCommand();
            long nit = Convert.ToInt64(pnit);
            long telefono = Convert.ToInt64(ptelefono);
            long tarjeta = Convert.ToInt64(ptar);
            comando.CommandText = "Update Cliente set Nombre='" + pnombre+ "' where DPI = " + pDPI;
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            conexion.Close();
        }
    }
}