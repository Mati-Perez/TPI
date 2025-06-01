using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class NoSocio : Cliente
    {
        public int IdNoSocio { get; set; }

        public NoSocio(int idNoSocio, string nombre, string apellido,string tipoDoc, int dni, string direccion)
            : base(nombre, apellido, tipoDoc, dni, direccion)
        {
            IdNoSocio = idNoSocio;
        }

        public void InscribirActividad(int idActividad)
        {
            // TODO: validar y registrar inscripción de actividad
            throw new NotImplementedException();
        }
    }
}