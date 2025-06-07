using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Datos
{
    internal class NoSocioDB
    {
        public DataTable GetNoSocios()
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM noSocio;";
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

        public void AddNoSocio(string nombre, string apellido, string tipoDni, int dni, string calle, int altura, string localidad, int cp, DateTime fechaInscripcion)
        {
            string query = @"INSERT INTO NoSocio (Nombre, Apellido,TipoDoc, Documento, Calle, Altura, Localidad, CP, FechaInscripcion)
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

        public DataTable GetNoSocioByDni(int dni)
        {
            DataTable socio = new DataTable();
            string query = @"SELECT * FROM noSocio WHERE DOCUMENTO = @DNI;";
            try
            {
                using (var sqlcon = Conexion.getInstancia().CrearConexion())
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

        public int DeleteNoSocio(int dni)
        {
            string query = @"DELETE FROM noSocio WHERE Documento = @DNI;";
            try
            {
                using (var sqlcon = Conexion.getInstancia().CrearConexion())
                {
                    sqlcon.Open();
                    using (var command = new MySqlCommand(query, sqlcon))
                    {
                        command.Parameters.AddWithValue("@DNI", dni);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el socio: " + ex.Message);
            }
        }

        public int UpdateNoSocio(string nombre, string apellido, string tipoDni, int dni, string calle, int altura, string localidad, int cp)
        {

            string query = @"UPDATE noSocio SET Nombre = @Nombre, Apellido = @Apellido, TipoDoc = @TipoDoc, Documento = @Documento, 
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
    }
}
