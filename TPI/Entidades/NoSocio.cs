using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class NoSocio : Cliente
    {
        public int? IdNoSocio { get; set; }
        public DateTime FechaInscripcion { get; set; }


        public NoSocio(int? idNoSocio, string nombre, string apellido,string tipoDoc, int dni, string direccion, DateTime fechaInscripcion): base(nombre, apellido, tipoDoc, dni, direccion)
        {
            IdNoSocio = idNoSocio;
            FechaInscripcion = fechaInscripcion;
        }

        public void InscribirActividad(int idActividad)
        {
            // TODO: validar y registrar inscripción de actividad
            throw new NotImplementedException();
        }
    }
}