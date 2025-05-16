using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TPI.Entidades;

namespace TPI.Servicios
{
    public class SocioService
    {
        private readonly List<Socio> socios = new();

        public void RegistrarSocio(Socio socio)
        {
            socios.Add(socio);
        }

        public List<Socio> ObtenerSocios()
        {
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
