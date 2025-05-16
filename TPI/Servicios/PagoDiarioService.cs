using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Entidades;

namespace TPI.Servicios
{
    public class PagoDiarioService
    {
        private readonly List<PagoDiario> pagos = new();

        public void RegistrarPago(PagoDiario pago)
        {
            pagos.Add(pago);
        }

        public PagoDiario ObtenerPago(int idPagoDiario)
        {
            return pagos.FirstOrDefault(p => p.IdPagoDiario == idPagoDiario);
        }

        public void PagarActividad(int idPagoDiario)
        {
            var pago = ObtenerPago(idPagoDiario);
            if (pago != null && pago.Estado == "Pendiente")
            {
                pago.PagarActividad();
            }
        }
    }
}
