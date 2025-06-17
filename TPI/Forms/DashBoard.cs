using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Entidades;
using TPI.Servicios;

namespace TPI.Forms
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            ActualizarVista();
            rbBusqNoSocioDni.Checked = true;
            rbBusqSocioDni.Checked = true;
            rbBusqVencimientoDni.Checked = true;
            Show_Vencimientos(CuotaService.ObtenerVencimientos());
        }

        public void CantidadClientes(List<Socio> socio, List<NoSocio> noSocios)
        {
            int cantidadSocios = socio.Count();
            int cantidadNoSocios = noSocios.Count();
            lblCantidadSocio.Text = cantidadSocios.ToString("D3");
            lblCantidadNoSocio.Text = cantidadNoSocios.ToString("D3");
            lblCantidadClientes.Text = (cantidadSocios + cantidadNoSocios).ToString("D3");
        }

        public void ActualizarVista()
        {


            SocioService.cargarSocios();
            List<Socio> ListadoSocios = SocioService.ListaSocios();

            NoSocioService.CargarNoSocios();
            List<NoSocio> ListadoNoSocios = NoSocioService.ListaNoSocios();

            listVistaBusquedaSocio.Items.Clear();
            listVistaBusquedaNosocio.Items.Clear();

            Show_Socios(ListadoSocios);
            Show_NoSocios(ListadoNoSocios);
            CantidadClientes(ListadoSocios, ListadoNoSocios);
        }

        private void Show_Socios(List<Socio> socios)
        {
            foreach (var socio in socios)
            {
                ListViewItem item = new ListViewItem(socio.Nombre);
                item.SubItems.Add(socio.Apellido);
                item.SubItems.Add(socio.Dni.ToString());
                item.SubItems.Add(socio.FechaInscripcion.ToShortDateString());

                listVistaBusquedaSocio.Items.Add(item);
            }
        }

        private void Show_Vencimientos(List<dynamic> vencimientos)
        {
            foreach (dynamic vencimiento in vencimientos)
            {
                ListViewItem item = new ListViewItem(vencimiento.NumCarnet.ToString());
                item.SubItems.Add(vencimiento.Nombre);
                item.SubItems.Add(vencimiento.Apellido);
                item.SubItems.Add(vencimiento.Documento.ToString());
                item.SubItems.Add(vencimiento.Monto.ToString());
                item.SubItems.Add(Convert.ToDateTime(vencimiento.FechaVencimiento).ToShortDateString());
                listVistaVencimientos.Items.Add(item);
            }
        }

        private void Show_NoSocios(List<NoSocio> noSocios)
        {
            foreach (var noSocio in noSocios)
            {
                ListViewItem item = new ListViewItem(noSocio.Nombre);
                item.SubItems.Add(noSocio.Apellido);
                item.SubItems.Add(noSocio.Dni.ToString());
                item.SubItems.Add(noSocio.FechaInscripcion.ToShortDateString());

                listVistaBusquedaNosocio.Items.Add(item);
            }
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            Form form = new RegistroForm(this, "SOCIO", true);
            form.ShowDialog();
        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            Form form = new RegistroForm(this, "NO SOCIO", true);
            form.ShowDialog();
        }

        private void btnRegistrarActividad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no implementada aún.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusquedaSocio_TextChanged(object sender, EventArgs e)
        {
            string searchDni = txtBusquedaSocio.Text.Trim().ToUpper();

            listVistaBusquedaSocio.Items.Clear();

            var socios = SocioService.ListaSocios()
                .Where(s => (rbBusqSocioDni.Checked && s.Dni.ToString().Contains(searchDni)) ||
                            (rbBusqSocioNombre.Checked && s.Nombre.Contains(searchDni)) ||
                            (rbBusqSocioApellido.Checked && s.Apellido.Equals(searchDni))).ToList();

            Show_Socios(socios);
        }

        private void txtBusquedaNosocio_TextChanged(object sender, EventArgs e)
        {
            string searchDni = txtBusquedaNosocio.Text.Trim().ToUpper();

            listVistaBusquedaNosocio.Items.Clear();

            var noSocios = NoSocioService.ListaNoSocios()
                .Where(ns => (rbBusqNoSocioDni.Checked && ns.Dni.ToString().Contains(searchDni)) ||
                             (rbBusqNoSocioNombre.Checked && ns.Nombre.Contains(searchDni)) ||
                             (rbBusqNoSocioApellido.Checked && ns.Apellido.Equals(searchDni))).ToList();


            Show_NoSocios(noSocios);

        }
        private void txtBusquedaVencimiento_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBusquedaVencimiento.Text.Trim().ToLower();

            listVistaVencimientos.Items.Clear();

            var vencimientos = CuotaService.ObtenerVencimientos()
                .Where(v => (rbBusqVencimientoDni.Checked && v.Documento.ToString().Contains(busqueda)) ||
                            (rbBusqVencimientoNombre.Checked && (v.Nombre.ToLower().Contains(busqueda) || v.Apellido.ToLower().Contains(busqueda))) ||
                            (rbBusqVencimientoCarnet.Checked && v.NumCarnet.ToString().Contains(busqueda))).ToList();

            Show_Vencimientos(vencimientos);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            CuotaForm cuotaForm = new CuotaForm();
            cuotaForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            registroForm.ShowDialog();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
