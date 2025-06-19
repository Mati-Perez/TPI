using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Datos;
using TPI.Entidades;
using TPI.Servicios;

namespace TPI.Forms
{
    public partial class CuotaForm : Form
    {
        public frmFactura doc = new frmFactura();

        public CuotaForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumCarnet.Text))
                {
                    MessageBox.Show("Por favor, ingrese el número de carnet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int numCarnet = int.Parse(txtNumCarnet.Text);
                DateTime fechaPago = dtpFechaPago.Value;
                string formaDePago;
                if(rbEfectivo.Checked == true)
                {
                    formaDePago = "Efectivo";
                }else if(rbTarjeta.Checked == true)
                {
                    formaDePago = "Tarjeta";
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una forma de pago","AVISO DEL SISTEMA",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CuotaService cuota = new CuotaService();
                cuota.PagarCuota(numCarnet, formaDePago);

                MessageBox.Show("Cuota actualizada como pagada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var soc = SocioService.ObtenerSocioPorCarnet(numCarnet);
                if(soc is null)
                {
                    MessageBox.Show("No hay socio", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                doc.nombre_f = soc.Nombre;
                doc.apellido_f = soc.Apellido;
                doc.forma_f = formaDePago;
                doc.monto_f = 25000;
                doc.carnet_f = numCarnet;
                doc.Show();
                this.Hide();

            }
            catch (FormatException)
            {
                MessageBox.Show("El número de carnet debe ser un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarCuotas_Click(object sender, EventArgs e)
        {
            try
            {
                CuotaBD cuotaBD = new CuotaBD();
                DataTable dt = cuotaBD.ObtenerCuotas();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron cuotas.");
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuotas: " + ex.Message);
            }
        }

    }
}
