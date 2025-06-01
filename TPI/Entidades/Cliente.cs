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
        public string TipoDoc { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }

        public Cliente(string nombre, string apellido,string tipoDoc, int dni, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDoc = tipoDoc; // Asumiendo que el tipo de documento es siempre DNI, puedes cambiarlo según sea necesario
            Dni = dni;
            Direccion = direccion;
        }
    }
}
