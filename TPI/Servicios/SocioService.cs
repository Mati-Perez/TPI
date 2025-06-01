using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Datos;
using TPI.Entidades;

namespace TPI.Servicios
{
    public class SocioService
    {
        private readonly List<Socio> socios = new List<Socio>();

        public static void RegistrarSocio(Socio socio)
        {
            var repo = new SocioBD();
            string calle = socio.Direccion.Split(' ')[0]; // Asumiendo que la dirección está en el formato "Calle Altura, Localidad CP"
            int altura = Convert.ToInt32(socio.Direccion.Split(' ')[1]); // Asumiendo que la altura es el segundo elemento de la dirección
            string localidad = socio.Direccion.Split(' ')[2]; // Asumiendo que la localidad es el tercer elemento de la dirección
            int cp = Convert.ToInt32(socio.Direccion.Split(' ')[3]); // Asumiendo que el CP es el cuarto elemento de la dirección

            try
            {
                repo.AddSocio(
                    socio.Nombre,
                    socio.Apellido,
                    socio.TipoDoc,
                    socio.Dni,
                    calle,
                    altura,
                    localidad,
                    cp,
                    socio.FechaInscripcion
                    );

                MessageBox.Show("Cliente registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static List<Socio> ObtenerSocios()
        {
            List<Socio> socios = new List<Socio>();
            DataTable dt = new SocioBD().GetSocios();

            foreach (DataRow row in dt.Rows)
            {
                Socio socio = new Socio(
                Convert.ToInt32(row["NumCarnet"]),
                (row["Nombre"]?.ToString() ?? ""),
                (row["Apellido"]?.ToString() ?? ""),
                (row["TipoDoc"]?.ToString() ?? ""),
                Convert.ToInt32(row["Documento"]),
                $"{row["Calle"]?.ToString() ?? ""} {row["Altura"]?.ToString() ?? ""}, {row["Localidad"]?.ToString() ?? ""} {row["CP"]?.ToString() ?? ""}",
                Convert.ToDateTime(row["FechaInscripcion"]),
                Convert.ToBoolean(row["Carnet"])
                );
                socios.Add(socio);
            }

            return socios;
        }

        public void ModificarSocio(int numCarnet, string nombre, string apellido, int dni, string direccion)
        {
            var socio = socios.FirstOrDefault(s => s.NumCarnet == numCarnet);
            if (socio != null)
            {
                socio.Nombre = nombre;
                socio.Apellido = apellido;
                socio.Dni = dni;
                socio.Direccion = direccion;
            }
        }

        public void DarDeBajaSocio(int numCarnet)
        {
            var socio = socios.FirstOrDefault(s => s.NumCarnet == numCarnet);
            if (socio != null)
            {
                socios.Remove(socio);
            }
        }
    }
}
