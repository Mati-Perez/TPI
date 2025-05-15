using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Servicios
{
    public class ActividadService
    {
        private readonly List<Actividad> actividades = new();

        public void AgregarActividad(Actividad actividad)
        {
            actividades.Add(actividad);
        }

        public List<Actividad> ObtenerActividades()
        {
            return actividades;
        }
    }
}