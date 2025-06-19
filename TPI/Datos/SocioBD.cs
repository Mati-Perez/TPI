using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;


namespace TPI.Datos
{
    internal class SocioBD
    {
        public DataTable GetSocios()
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM socio;";
            try
            {
                using (var sqlcon = Conexion.getInstancia().CrearConexion())
                {
                    sqlcon.Open();
                    using (var command = new MySqlCommand(query, sqlcon))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            ds.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los socios: " + ex.Message);
            }
            finally
            {
                // Aquí podrías cerrar la conexión si no estás usando 'using'
                // pero en este caso, el 'using' se encarga de cerrarla automáticamente.
            }
            return ds;
        }

        public void AddSocio(string nombre, string apellido, string tipoDni, int dni, string calle, int altura, string localidad, int cp, DateTime fechaInscripcion)
        {

            string query = @"INSERT INTO socio (Nombre, Apellido,TipoDoc, Documento, Calle, Altura, Localidad, CP, FechaInscripcion)
                         VALUES (@Nombre, @Apellido,@tipoDoc, @Documento, @Calle, @Altura, @Localidad, @CP, @FechaInscripcion);";


            try
            {
                using (var sqlcon = Conexion.getInstancia().CrearConexion())
                {
                    sqlcon.Open();

                    using (var command = new MySqlCommand(query, sqlcon))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@tipoDoc", tipoDni);
                        command.Parameters.AddWithValue("@Documento", dni);
                        command.Parameters.AddWithValue("@Calle", calle);
                        command.Parameters.AddWithValue("@Altura", altura);
                        command.Parameters.AddWithValue("@Localidad", localidad);
                        command.Parameters.AddWithValue("@CP", cp);
                        command.Parameters.AddWithValue("@FechaInscripcion", fechaInscripcion);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No se pudo agregar el socio.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar socio: " + ex.Message);
            }
        }

        public DataTable GetSocioByDni(int dni)
        {
            DataTable socio = new DataTable();
            string query = @"SELECT * FROM SOCIO WHERE DOCUMENTO = @DNI;";
            try
            { 
                using(var sqlcon = Conexion.getInstancia().CrearConexion())
                {
                    sqlcon.Open();
                    using (var command = new MySqlCommand(query, sqlcon))
                    {
                        command.Parameters.AddWithValue("@DNI", dni);
                         using (var reader = command.ExecuteReader())
                         {
                            socio.Load(reader);
                         }
                    }
                }
                return socio;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el socio por DNI: " + ex.Message);
            }

        }

        public int DeleteSocio(int dni)
        {
            string deleteCuotasQuery = @"
        DELETE FROM cuota 
        WHERE NumCarnet = (
            SELECT NumCarnet FROM socio WHERE Documento = @DNI
        );";

            string deleteSocioQuery = @"DELETE FROM socio WHERE Documento = @DNI;";

            try
            {
                using (var sqlcon = Conexion.getInstancia().CrearConexion())
                {
                    sqlcon.Open();
                    using (var transaction = sqlcon.BeginTransaction())
                    {
                        try
                        {
                            // Eliminar cuotas asociadas
                            using (var cmdCuotas = new MySqlCommand(deleteCuotasQuery, sqlcon, transaction))
                            {
                                cmdCuotas.Parameters.AddWithValue("@DNI", dni);
                                cmdCuotas.ExecuteNonQuery();
                            }

                            // Eliminar socio
                            using (var cmdSocio = new MySqlCommand(deleteSocioQuery, sqlcon, transaction))
                            {
                                cmdSocio.Parameters.AddWithValue("@DNI", dni);
                                int rowsAffected = cmdSocio.ExecuteNonQuery();

                                transaction.Commit();
                                return rowsAffected;
                            }
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el socio y sus cuotas: " + ex.Message);
            }

        }

        public int UpdateSocio(string nombre, string apellido, string tipoDni, int dni, string calle, int altura, string localidad, int cp) 
        {

            string query  = @"UPDATE socio SET Nombre = @Nombre, Apellido = @Apellido, TipoDoc = @TipoDoc, Documento = @Documento, 
                                  Calle = @Calle, Altura = @Altura, Localidad = @Localidad, CP = @CP WHERE Documento = @Documento;";
            try
            {
                using (var sqlcon = Conexion.getInstancia().CrearConexion()) 
                {
                    sqlcon.Open();
                    using (var command = new MySqlCommand(query, sqlcon)) 
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@TipoDoc", tipoDni);
                        command.Parameters.AddWithValue("@Documento", dni); 
                        command.Parameters.AddWithValue("@Calle", calle);
                        command.Parameters.AddWithValue("@Altura", altura); 
                        command.Parameters.AddWithValue("@Localidad", localidad);
                        command.Parameters.AddWithValue("@CP", cp);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el socio: " + ex.Message);
            }
        }

        public DataTable GetSocioPorCarnet(int numCarnet)
        {
            DataTable socio = new DataTable();
            string query = @"SELECT * FROM socio WHERE NumCarnet = @NumCarnet;";

            try
            {
                using (var sqlcon = Conexion.getInstancia().CrearConexion())
                {
                    sqlcon.Open();
                    using (var command = new MySqlCommand(query, sqlcon))
                    {
                        command.Parameters.AddWithValue("@NumCarnet", numCarnet);
                        using (var reader = command.ExecuteReader())
                        {
                            socio.Load(reader);
                        }
                    }
                }

                return socio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el socio por número de carnet: " + ex.Message);
            }
        }


    }
}
