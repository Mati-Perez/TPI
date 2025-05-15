using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Datos;
using MySql.Data.MySqlClient;

namespace TPI.Servicios
{
    public class BaseDatosService
    {
        public void CrearBaseYTablas()
        {
            string crearBD = "CREATE DATABASE IF NOT EXISTS Proyecto;";
            string usarBD = "USE Proyecto;";

            string crearTablaCliente = @"
                CREATE TABLE IF NOT EXISTS Cliente (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    nombre VARCHAR(100),
                    dni VARCHAR(20),
                    tipo ENUM('Socio', 'NoSocio')
                );";

            string crearTablaSocio = @"
                CREATE TABLE IF NOT EXISTS Socio (
                    id INT PRIMARY KEY,
                    fechaAlta DATE,
                    FOREIGN KEY (id) REFERENCES Cliente(id)
                );";

            string crearTablaNoSocio = @"
                CREATE TABLE IF NOT EXISTS NoSocio (
                    id INT PRIMARY KEY,
                    categoria VARCHAR(50),
                    FOREIGN KEY (id) REFERENCES Cliente(id)
                );";

            string crearTablaActividad = @"
                CREATE TABLE IF NOT EXISTS Actividad (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    nombre VARCHAR(100),
                    descripcion TEXT,
                    precio DECIMAL(10,2)
                );";

            string crearTablaCuota = @"
                CREATE TABLE IF NOT EXISTS Cuota (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    idCliente INT,
                    monto DECIMAL(10,2),
                    fecha DATE,
                    pagado BOOLEAN,
                    FOREIGN KEY (idCliente) REFERENCES Cliente(id)
                );";

            string crearTablaPagoDiario = @"
                CREATE TABLE IF NOT EXISTS PagoDiario (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    idCliente INT,
                    idActividad INT,
                    fecha DATE,
                    monto DECIMAL(10,2),
                    FOREIGN KEY (idCliente) REFERENCES Cliente(id),
                    FOREIGN KEY (idActividad) REFERENCES Actividad(id)
                );";

            using (var conexion = new MySqlConnection("server=localhost;port=3306;user=root;password=;"))
            {
                try
                {
                    conexion.Open();
                    var cmd = new MySqlCommand(crearBD, conexion);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = usarBD;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = crearTablaCliente;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = crearTablaSocio;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = crearTablaNoSocio;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = crearTablaActividad;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = crearTablaCuota;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = crearTablaPagoDiario;
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("✅ Base de datos y tablas creadas correctamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                }
            }
        }
    }
}
