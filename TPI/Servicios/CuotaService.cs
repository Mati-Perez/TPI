using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TPI.Entidades;

namespace TPI.Servicios
{
    public class CuotaService
    {
        private readonly List<Cuota> cuotas = new();

        public void RegistrarCuota(Cuota cuota)
        {
            cuotas.Add(cuota);
        }

        public List<Cuota> ObtenerCuotas()
        {
            return cuotas;
        }

        public Cuota ObtenerCuota(int idCuota)
        {
            return cuotas.FirstOrDefault(c => c.IdCuota == idCuota);
        }

        public bool PagarCuota(int idCuota)
        {
            var cuota = ObtenerCuota(idCuota);

            if (cuota == null)
                throw new InvalidOperationException("No se encontró la cuota.");

            if (cuota.Estado == "Pagado")
                throw new InvalidOperationException("La cuota ya fue pagada.");

            cuota.FechaPago = DateTime.Now;
            cuota.Estado = "Pagado";
            return true;
        }
    }
}