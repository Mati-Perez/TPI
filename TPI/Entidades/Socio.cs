using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPI.Entidades
{
    public class Socio : Cliente
    {
        public int NumCarnet { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public string TipoCuota { get; set; }
        public bool Carnet { get; set; }

        public Socio(int numCarnet, DateTime fechaInscripcion, string tipoCuota, bool carnet,
            string nombre, string apellido, int dni, string direccion)
            : base(nombre, apellido, dni, direccion)
        {
            NumCarnet = numCarnet;
            FechaInscripcion = fechaInscripcion;
            TipoCuota = tipoCuota;
            Carnet = carnet;
        }
    }
}