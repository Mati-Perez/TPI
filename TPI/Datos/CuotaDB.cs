using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using TPI.Entidades;

namespace TPI.Datos
{
    internal class CuotaBD
    {
        public void AddCuota(int numCarnet, float monto, string tipo, DateTime? fechaPago, DateTime vencimiento, bool estado)
        {

            string query = @"INSERT INTO cuota (NumCarnet, Monto,Tipo, FechaPago, FechaVencimiento, Estado)
                         VALUES (@numCarnet, @monto, @tipo, @fechaPago, @vencimiento, @estado);";

            try
            {
                using (var sqlcon = Conexion.getInstancia().CrearConexion())
                {
                    sqlcon.Open();

                    using (var command = new MySqlCommand(query, sqlcon))
                    {
                        command.Parameters.AddWithValue("@numCarnet", numCarnet);
                        command.Parameters.AddWithValue("@monto", monto);
                        command.Parameters.AddWithValue("@tipo", tipo);
                        command.Parameters.AddWithValue("@fechaPago", fechaPago);
                        command.Parameters.AddWithValue("@vencimiento", vencimiento);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No se pudo agregar la cuota.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar socio: " + ex.Message);
            }
        }


        public void MarcarCuotaComoPagada(int numCarnet, DateTime fechaPago, string modoDePago)
        {
            string query = @"UPDATE cuota 
                             SET Estado = 1, FechaPago = @FechaPago, tipo = @ModoDePago
                             WHERE NumCarnet = @NumCarnet AND Estado = 0
                             ORDER BY FechaVencimiento ASC
                             LIMIT 1;";

            try
            {
                using (var sqlcon = Conexion.getInstancia().CrearConexion())
                {
                    sqlcon.Open();

                    using (var command = new MySqlCommand(query, sqlcon))
                    {
                        command.Parameters.AddWithValue("@NumCarnet", numCarnet);
                        command.Parameters.AddWithValue("@FechaPago", fechaPago);
                        command.Parameters.AddWithValue("@ModoDePago", modoDePago);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception("No se encontró una cuota impaga para este socio.");
                        }
                        // llamo a comprobante de pago
                       // ComprobantePago.Generar(numCarnet, fechaPago);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la cuota: " + ex.Message);
            }
        }

        public DataTable ObtenerCuotas()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM cuota";
            using (var con = Conexion.getInstancia().CrearConexion())
            {
                con.Open();
                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public DataTable Vencimientos()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT Socio.Nombre, Socio.Apellido, Socio.NumCarnet, Socio.Documento, 
                            Cuota.Monto, Cuota.FechaVencimiento, Cuota.Estado
                     FROM cuota 
                     INNER JOIN socio ON cuota.NumCarnet = socio.NumCarnet 
                     WHERE Cuota.Estado = 0 
                       AND Cuota.FechaVencimiento = @FechaVencimiento
                     ORDER BY Cuota.FechaVencimiento ASC;";

            using (var consql = Conexion.getInstancia().CrearConexion())
            {
                consql.Open();
                using (var cmd = new MySqlCommand(query, consql))
                {
                    cmd.Parameters.AddWithValue("@FechaVencimiento", DateTime.Now.Date);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public DataTable ObtenerCuotaPorNumCarnet(int numCarnet)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM cuota WHERE NumCarnet = @NumCarnet AND Estado = 0 ORDER BY FechaVencimiento ASC LIMIT 1;";

            using (var con = Conexion.getInstancia().CrearConexion())
            {
                con.Open();
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NumCarnet", numCarnet);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

        internal class ComprobantePago
        {
            public static void Generar(int numCarnet, DateTime fechaPago)
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"Comprobante_{numCarnet}_{fechaPago:yyyyMMdd}.txt");

                try
                {
                    using (StreamWriter writer = new StreamWriter(ruta))
                    {
                        writer.WriteLine("====================================");
                        writer.WriteLine("        COMPROBANTE DE PAGO         ");
                        writer.WriteLine("====================================");
                        writer.WriteLine($"Fecha:         {fechaPago:dd/MM/yyyy}");
                        writer.WriteLine($"Carnet Nº:     {numCarnet}");
                        writer.WriteLine("------------------------------------");
                        writer.WriteLine("Estado:        PAGADO");
                        writer.WriteLine("Gracias por su pago.");
                        writer.WriteLine("====================================");
                    }

                    // Abrir el comprobante como ventana emergente
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = ruta,
                        UseShellExecute = true // Necesario para que se abra con la app predeterminada en .NET Core o .NET 5+
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al generar o abrir el comprobante: " + ex.Message);
                }
            }
        }
    }
}
