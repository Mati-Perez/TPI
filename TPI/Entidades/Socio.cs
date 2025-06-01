using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPI.Entidades
{
    public class Socio : Cliente
    {
        public int? NumCarnet { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool Carnet { get; set; }

        public Socio(int? numCarnet,string nombre, string apellido, string tipoDoc, int dni, string direccion, DateTime fechaInscripcion, bool carnet): base(nombre, apellido, tipoDoc, dni, direccion)
        {
            NumCarnet = numCarnet;
            FechaInscripcion = fechaInscripcion;
            Carnet = carnet;
        }
    }
}