using TPI.Entidades;
using TPI.Forms;
using TPI.Servicios;

namespace TPI
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de gestión de actividades cargado.");

            var dbService = new BaseDatosService();
            dbService.CrearBaseYTablas(); // <-- crea base y tablas

            /**var cuotaService = new CuotaService();

            var cuota = new Cuota(
                idCuota: 101,
                numCarnet: 1234,
                monto: 2000m,
                tipo: "Mensual",
                fechaPago: null,
                fechaVencimiento: DateTime.Today.AddDays(15),
                estado: "Pendiente"
            );

            cuotaService.RegistrarCuota(cuota);

            Console.WriteLine("Estado antes de pagar:");
            foreach (var c in cuotaService.ObtenerCuotas())
            {
                Console.WriteLine($"Cuota {c.IdCuota} - Estado: {c.Estado}");
            }

            try
            {
                cuotaService.PagarCuota(101);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al pagar cuota: {ex.Message}");
            }

            Console.WriteLine("Estado después de pagar:");
            foreach (var c in cuotaService.ObtenerCuotas())
            {
                Console.WriteLine($"Cuota {c.IdCuota} - Estado: {c.Estado}, Fecha de Pago: {c.FechaPago}");
            } **/

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Application.Run(new RegistroForm());
            Application.Run(new CuotaForm());

        }
    }
}
