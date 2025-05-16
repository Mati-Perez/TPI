using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;


namespace TPI.Servicios
{
    public class NoSocioService
    {
        private List<NoSocio> noSocios = new();

        public void AgregarNoSocio(NoSocio noSocio)
        {
            noSocios.Add(noSocio);
        }

        public List<NoSocio> ObtenerNoSocios()
        {
            return noSocios;
        }
    }
}