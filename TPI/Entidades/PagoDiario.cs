using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPI.Entidades
{
    public class PagoDiario
    {
        public int IdPagoDiario { get; set; }
        public int IdNoSocio { get; set; }
        public decimal Monto { get; set; }
        public string Tipo { get; set; }
        public int IdActividad { get; set; }
        public DateTime FechaPago { get; set; }
        public string Estado { get; set; }

        public PagoDiario(int idPagoDiario, int idNoSocio, decimal monto, string tipo,
            int idActividad, DateTime fechaPago, string estado)
        {
            IdPagoDiario = idPagoDiario;
            IdNoSocio = idNoSocio;
            Monto = monto;
            Tipo = tipo;
            IdActividad = idActividad;
            FechaPago = fechaPago;
            Estado = estado;
        }

        public void PagarActividad()
        {
            // TODO: implementar lógica de pago (actualizar Estado, persistir, etc.)
            throw new NotImplementedException();
        }
    }
}