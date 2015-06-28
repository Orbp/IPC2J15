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
            comando.CommandText = "SELECT DPI FROM Cliente WHERE Usuario = '" + usuario + "' AND Contraseña = '" + contraseña + "' AND Estado =" + 1;
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
            comando.CommandText = "Update Cliente set Nombre='" + pnombre+ "' , Apellido ='" + papellido + "', NIT = "+ nit +", Telefono = " + telefono + ", Domicilio = '"+ pdir +"', Tarjeta = " + tarjeta +"where DPI = " + pDPI;
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

        [WebMethod]
        public List<string> Sucursales()
        {
            List<string> cat = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select Direccion FROM Sucursal";
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
                    nombre = lector.GetString(0);
                    cat.Add(nombre);
                }
            }
            return cat;
        }    

        
        [WebMethod]
        public void cargarEmpleado(String direccion)
        {


            SqlCommand miComandoSQL = new SqlCommand("BULK INSERT Empleado FROM '" + direccion + "' WITH ( FIRSTROW = 2, FIELDTERMINATOR = ',', ROWTERMINATOR = '\n', TABLOCK )");
            conexion = new SqlConnection(CadenaConexion);
            miComandoSQL.Connection = conexion;
            conexion.Open();
            miComandoSQL.ExecuteNonQuery();
            conexion.Close();



        }
        [WebMethod]
        public void cargarCategoria(String direccion)
        {
            SqlCommand miComandoSQL = new SqlCommand("BULK INSERT Categoria FROM '" + direccion + "' WITH ( FIRSTROW = 2, FIELDTERMINATOR = ',', ROWTERMINATOR = '\n', TABLOCK )");
            conexion = new SqlConnection(CadenaConexion);
            miComandoSQL.Connection = conexion;
            conexion.Open();
            miComandoSQL.ExecuteNonQuery();
            conexion.Close();
        }

        [WebMethod]

        public int Cat(string categoria)
        {
            int sucursal = 0;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select Id_sucursal From Sucursal Where Direccion = '" + categoria + "'";
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    sucursal = lector.GetInt32(0);
                }
            }
            conexion.Close();
            return sucursal;
        }

        [WebMethod]
        public bool AgregarCliente(int pdpi, string pnombre, string papellido, long pnit, long ptelefono, string pdomicilio, long ptarjeta, int psucursal, string pusuario, string pcontraseña)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText="Insert into Cliente (DPI, Nombre, Apellido, NIT, Telefono, Domicilio, Tarjeta, Casilla, Id_sucursal, Usuario, Contraseña, Estado) Values (" + pdpi + ", '" + pnombre+"', '"+ papellido + "', " + pnit+ ", " +ptelefono+", '"+pdomicilio+"', "+ptarjeta+", 0, "+ psucursal+", '" + pusuario+"', '" + pcontraseña+"', 0)";
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            conexion.Close();
        }
    
        [WebMethod]
        public string ObtenerComision(int pidsede)
        {
            string comision = "";
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select Comision From Sede where Id_Sede = " + 2;
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    comision = Convert.ToString(lector.GetDouble(0));
                }
            }
            return comision;
        }

        [WebMethod]
        public int ObtenerSede(string psucursal)
        {
            int sede = 0;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select Id_sede From Sucursal Where Direccion = '" + psucursal + "'";
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    sede = lector.GetInt32(0);
                }
            }
            return sede;
        }

        [WebMethod]
        public int ObtenerCategoria(string nombre, float pporcentaje)
        {
            int categoria = 0;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select Id_Categoria From Categoria Where Nombre_categoria = '" + nombre + "' And Valor_Impuesto = " + pporcentaje;
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    categoria = lector.GetInt32(0);
                }
            }
            conexion.Close();
            return categoria;
        }

        [WebMethod]
        public bool AgregarPaquete(string pnombre, string pdescripcion, int pcategoria, int pcliente, float pprecio, int ppeso, int psucursal, int plote)
        {
            SqlCommand comando = new SqlCommand();
            conexion = new SqlConnection(CadenaConexion);
            comando.CommandText = "INSERT Producto (Nombre, Descripcion, Id_Categoria, Id_Cliente, Precio, Peso, Estado, Sucursal, Lote) Values ('" + pnombre + "', '" + pdescripcion + "'," + pcategoria + ", " + pcliente + ", " + pprecio + "," + ppeso + "," + 0 + "," + psucursal + "," + plote+")";
            comando.Connection = conexion;
            conexion.Open();
            if (comando.ExecuteNonQuery() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public List<Producto> Devolverpedidos(int pcasilla)
        {
            List<Producto> pedidos = new List<Producto>();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select Id_producto From Producto where Id_Cliente = " + pcasilla;
            conexion = new SqlConnection(CadenaConexion);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Producto p = new Producto();
                    p.idproducto = lector.GetInt32(0);
                    pedidos.Add(p);
                }
            }
            return pedidos;
        }

        
    }
}