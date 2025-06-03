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

namespace TPI.Forms
{
    public partial class CuotaForm : Form
    {
        public CuotaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
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

                CuotaBD cuotaBD = new CuotaBD();
                cuotaBD.MarcarCuotaComoPagada(numCarnet, fechaPago);

                MessageBox.Show("Cuota actualizada como pagada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
