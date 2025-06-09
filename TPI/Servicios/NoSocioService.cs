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
    public class NoSocioService
    {
        private static List<NoSocio> _noSocios = new List<NoSocio>();

        public static List<NoSocio> ListaNoSocios()
        {
            return _noSocios;
        }

        public static void CargarNoSocios()
        {
            _noSocios = NoSocioService.ObtenerNoSocios();
        }


        public static void RegistrarNoSocio(NoSocio noSocio)
        {
            var repo = new NoSocioDB();
            string calle = noSocio.Direccion.Split(',')[0]; // Asumiendo que la dirección está en el formato "Calle Altura, Localidad CP"
            int altura = Convert.ToInt32(noSocio.Direccion.Split(',')[1]); // Asumiendo que la altura es el segundo elemento de la dirección
            string localidad = noSocio.Direccion.Split(',')[2]; // Asumiendo que la localidad es el tercer elemento de la dirección
            int cp = Convert.ToInt32(noSocio.Direccion.Split(',')[3]); // Asumiendo que el CP es el cuarto elemento de la dirección

            try
            {
                repo.AddNoSocio(
                    noSocio.Nombre,
                    noSocio.Apellido,
                    noSocio.TipoDoc,
                    noSocio.Dni,
                    calle,
                    altura,
                    localidad,
                    cp,
                    noSocio.FechaInscripcion
                    );

                MessageBox.Show("Cliente registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static List<NoSocio> ObtenerNoSocios()
        {
            _noSocios.Clear();
            DataTable dt = new NoSocioDB().GetNoSocios();

            foreach (DataRow row in dt.Rows)
            {
                NoSocio noSocio = new NoSocio(
                Convert.ToInt32(row["IdNoSocio"]),
                (row["Nombre"]?.ToString() ?? ""),
                (row["Apellido"]?.ToString() ?? ""),
                (row["TipoDoc"]?.ToString() ?? ""),
                Convert.ToInt32(row["Documento"]),
                $"{row["Calle"]?.ToString() ?? ""}, {row["Altura"]?.ToString() ?? ""}, {row["Localidad"]?.ToString() ?? ""}, {row["CP"]?.ToString() ?? ""}",
                Convert.ToDateTime(row["FechaInscripcion"])
                );
                _noSocios.Add(noSocio);
            }

            return _noSocios;
        }

        public static void ModificarNoSocio(NoSocio update)
        {
            string calle = update.Direccion.Split(',')[0]; // Asumiendo que la dirección está en el formato "Calle Altura, Localidad CP"
            int altura = Convert.ToInt32(update.Direccion.Split(',')[1]); // Asumiendo que la altura es el segundo elemento de la dirección
            string localidad = update.Direccion.Split(',')[2]; // Asumiendo que la localidad es el tercer elemento de la dirección
            int cp = Convert.ToInt32(update.Direccion.Split(',')[3]); // Asumiendo que el CP es el cuarto elemento de la dirección

            var repo = new NoSocioDB();
            var response = repo.UpdateNoSocio(update.Nombre, update.Apellido, update.TipoDoc, update.Dni, calle, altura, localidad, cp);

            if (response > 0)
            {
                MessageBox.Show("Socio modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al modificar el socio. Verifique los datos ingresados.");
            }

        }

        public static void DarDeBajaNoSocio(int dni)
        {
            var repo = new NoSocioDB();
            int response = repo.DeleteNoSocio(dni);

            if (response > 0)
            {
                MessageBox.Show("El Socio se elimino correctamente.");
            }
            else
            {
                MessageBox.Show("Error al eliminar el socio. Verifique la existencia.");
            }

        }
    }
}