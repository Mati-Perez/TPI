using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public string NombreActividad { get; set; }
        public string ProfesorAsignado { get; set; }
        public string Horario { get; set; }

        public Actividad(int idActividad, string nombreActividad, string profesorAsignado, string horario)
        {
            IdActividad = idActividad;
            NombreActividad = nombreActividad;
            ProfesorAsignado = profesorAsignado;
            Horario = horario;
        }
    }
}