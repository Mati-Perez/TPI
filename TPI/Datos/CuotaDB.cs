using MySql.Data.MySqlClient;
using System;
using System.Data;
using TPI.Entidades;

namespace TPI.Datos
{
    internal class CuotaBD
    {
        public void MarcarCuotaComoPagada(int numCarnet, DateTime fechaPago)
        {
            string query = @"UPDATE cuota 
                             SET Estado = 1, FechaPago = @FechaPago 
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

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception("No se encontró una cuota impaga para este socio.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la cuota: " + ex.Message);
            }
        }
    }
}
