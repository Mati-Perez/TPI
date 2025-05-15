using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }

        public Cliente(string nombre, string apellido, int dni, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
        }
    }
}
