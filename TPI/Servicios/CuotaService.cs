using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Datos;
using TPI.Entidades;

namespace TPI.Servicios
{
    public class CuotaService
    {
        private readonly List<Cuota> cuotas = new();

        public static void RegistrarCuota(Cuota cuota)
        {
            CuotaBD nuevaCuota = new CuotaBD();
            try
            {
                nuevaCuota.AddCuota(cuota.NumCarnet, cuota.Monto, cuota.Tipo, null, cuota.FechaVencimiento, cuota.Pagado);
                MessageBox.Show("Se ha generado una nueva cuota.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public List<Cuota> ObtenerCuotas()
        {
            return cuotas;
        }

        public Cuota ObtenerCuota(int numCarnet)
        {
            CuotaBD repo = new CuotaBD();
            DataTable dt = repo.ObtenerCuotaPorNumCarnet(numCarnet);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Cuota(
                Convert.ToInt32(row["IdCuota"]),
                Convert.ToInt32(row["NumCarnet"]),
                Convert.ToSingle(row["Monto"]),
                row["Tipo"]?.ToString(),
                row["FechaPago"] == DBNull.Value ? null : Convert.ToDateTime(row["FechaPago"]),
                Convert.ToDateTime(row["FechaVencimiento"]),
                Convert.ToBoolean(row["Estado"])
            );

        }

        public static List<dynamic> ObtenerVencimientos()
        {
            List <dynamic> vencimientos = new List<dynamic>();

            DataTable repo = new CuotaBD().Vencimientos();

            foreach (DataRow r in repo.Rows)
            {
                dynamic vencimiento = new
                {
                    Nombre = r["Nombre"].ToString(),
                    Apellido = r["Apellido"].ToString(),
                    NumCarnet = Convert.ToInt32(r["NumCarnet"]),
                    Documento = Convert.ToInt32(r["Documento"]),
                    Monto = Convert.ToSingle(r["Monto"]),
                    FechaVencimiento = Convert.ToDateTime(r["FechaVencimiento"]),
                    Estado = Convert.ToBoolean(r["Estado"])
                };
                vencimientos.Add(vencimiento);
            }


            return vencimientos;
        }
        public bool PagarCuota(int numCarnet, string modoDePago)
        {
            var cuota = ObtenerCuota(numCarnet);

            if (cuota == null)
                throw new InvalidOperationException("No se encontró la cuota.");

            if (cuota.Pagado == true)
                throw new InvalidOperationException("La cuota ya fue pagada.");

            CuotaBD cuotaPorPagar = new CuotaBD();
            cuotaPorPagar.MarcarCuotaComoPagada(cuota.NumCarnet, DateTime.Now, modoDePago);
            
            return true;
        }
    }
}