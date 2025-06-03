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


    public partial class RegistroForm : Form
    {
        //inicializo combo box
        static string[] tipo = { "SOCIO", "NO SOCIO", "PROFESOR" };
        static string[] tipoDni = { "DNI", "LE", "LC", "CI", "PASAPORTE" };


        static void llenarCombo(ComboBox TipoRegistro, ComboBox TipoDni)
        {
            foreach (string item in tipo)
            {
                TipoRegistro.Items.Add(item);
            }

            foreach (string item in tipoDni)
            {
                TipoDni.Items.Add(item);
            }

        }

        public RegistroForm()
        {
            InitializeComponent();
            Show_date();
            Show_Time();
            cbTipoRegistro.Text = "SOCIO"; // Set default value
            cbTipoDni.Text = "DNI"; // Set default value
            listRegistro.GridLines = true; //-> permite dibujar la grilla , las celdas 
            listRegistro.FullRowSelect = true; // -> permite selecionar la fila completa
            llenarCombo(cbTipoRegistro, cbTipoDni);
            CargarSociosEnListView();
        }

        private void Show_date()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Show_Time()
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cbTipoDni.Text = "DNI";
            txtDni.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtAltura.Text = string.Empty;
            txtLocalidad.Text = string.Empty;
            txtCp.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show_date();
            Show_Time();

            string direccion = txtCalle.Text.Trim() + " " + txtAltura.Text + " " + txtLocalidad.Text + " " + txtCp.Text;

            // Corrected object initialization to match the constructor signature
            var newSocio = new Socio(
                null, // Assuming NumCarnet is optional and can be null
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                cbTipoDni.Text,
                Convert.ToInt32(txtDni.Text),
                direccion,
                DateTime.Now, // Fecha de inscripción actual
                true // Asumimos que el carnet está activo al registrarlo
            );

            SocioService.RegistrarSocio(newSocio); // Registrar el nuevo socio
            CargarSociosEnListView();
            tabControl1.SelectedTab = tabPage2;
            limpiarCampos(); // Limpiar los campos después de registrar
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void CargarSociosEnListView()
        {
            List<Socio> socios = SocioService.ObtenerSocios(); // Asumiendo que tienes un método para obtener los socios

             listRegistro.Items.Clear(); // limpia el listView antes de cargar

            foreach (var s in socios)
            {
                ListViewItem item = new ListViewItem(s.NumCarnet.ToString());
                item.SubItems.Add(s.Nombre);
                item.SubItems.Add(s.Apellido);
                item.SubItems.Add(s.TipoDoc); // suponiendo que lo tengas
                item.SubItems.Add(s.Dni.ToString());
                item.SubItems.Add(s.Direccion); // ya formateada
                item.SubItems.Add(s.FechaInscripcion.ToShortDateString());

                listRegistro.Items.Add(item);
            }
        }
    }
}
