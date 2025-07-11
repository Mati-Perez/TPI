﻿using System;
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


        private DashBoard dashBoard; // Variable para almacenar la instancia de DashBoard
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

        public RegistroForm(DashBoard dashboard = null, string comboBox = "SOCIO", bool bloqueo = false)
        {
            InitializeComponent();
            this.dashBoard = dashboard; // Asigna la instancia de DashBoard a la variable de clase
            Show_date();
            Show_Time();
            cbTipoRegistro.Text = comboBox; // Set default value
            cbTipoDni.Text = "DNI"; // Set default value

            if (bloqueo)
            {
                cbTipoRegistro.Enabled = false; // Bloquea el ComboBox si el parámetro es true
            }

            listRegistro.GridLines = true; //-> permite dibujar la grilla , las celdas 
            listRegistro.FullRowSelect = true; // -> permite selecionar la fila completa
            listRegistro.View = View.Details; // -> permite ver los detalles de la lista

            listNoSocio.GridLines = true; //-> permite dibujar la grilla , las celdas
            listNoSocio.FullRowSelect = true; // -> permite selecionar la fila completa
            listNoSocio.View = View.Details; // -> permite ver los detalles de la lista

            listProfesores.GridLines = true; //-> permite dibujar la grilla , las celdas
            listProfesores.FullRowSelect = true; // -> permite selecionar la fila completa
            listProfesores.View = View.Details; // -> permite ver los detalles de la lista

            llenarCombo(cbTipoRegistro, cbTipoDni);

            CargarSociosEnListView();
            CargarNoSociosEnListView();

            btnActualizar.Visible = false;
        }

        private void Show_date()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Show_Time()
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
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
            btnActualizar.Visible = false; // Oculta el botón de actualizar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show_date();
            Show_Time();
            lblError.Text = "";

            if (!verificarRegistro(txtNombre.Text.Trim(), txtApellido.Text.Trim(), cbTipoDni.Text, txtDni.Text, txtCalle.Text.Trim(), txtAltura.Text, txtLocalidad.Text, txtCp.Text))
            {
                return;
            }

            string direccion = txtCalle.Text.Trim() + ", " + txtAltura.Text + ", " + txtLocalidad.Text + ", " + txtCp.Text;
            DateTime fechaActual = DateTime.Now;

            switch (cbTipoRegistro.Text)
            {
                case "SOCIO":
                    var newSocio = new Socio(
                        null, 
                        txtNombre.Text.Trim(),
                        txtApellido.Text.Trim(),
                        cbTipoDni.Text,
                        Convert.ToInt32(txtDni.Text),
                        direccion,
                        fechaActual, // Fecha de inscripción actual
                        true // Asumimos que el carnet está activo al registrarlo
                    );
                    
                    SocioService.RegistrarSocio(newSocio); // Registrar el nuevo socio

                    Socio socioEncontrado = SocioService.ObtenerSocioPorDni(newSocio.Dni);
                    
                    var newCuota = new Cuota(
                        null,
                        socioEncontrado.NumCarnet.Value,
                        25000,
                        null,
                        null,
                        fechaActual.AddMonths(1),
                        false
                    );
                    CuotaService.RegistrarCuota(newCuota); // Registra una nueva cuota

                    CargarSociosEnListView();
                    tabControl1.SelectedTab = SOCIO;
                    limpiarCampos(); // Limpiar los campos después de registrar

                    break;
                case "NO SOCIO":

                    NoSocio newNoSocio = new NoSocio(
                        null, // Assuming NumCarnet is optional and can be null
                        txtNombre.Text.Trim(),
                        txtApellido.Text.Trim(),
                        cbTipoDni.Text,
                        Convert.ToInt32(txtDni.Text),
                        direccion,
                        DateTime.Now // Fecha de inscripción actual
                    );

                    NoSocioService.RegistrarNoSocio(newNoSocio); // Registrar el nuevo no socio
                    CargarNoSociosEnListView();
                    tabControl1.SelectedTab = NOSOCIO; // Cambia a la pestaña de registro de no socio
                    limpiarCampos(); // Limpia los campos al cambiar de pestaña

                    break;
                case "PROFESOR":
                    tabControl1.SelectedTab = PROFESORES; // Cambia a la pestaña de registro de profesor
                    limpiarCampos(); // Limpia los campos al cambiar de pestaña
                    break;
                default:
                    MessageBox.Show("Por favor, seleccione un tipo de registro válido.");
                    break;
            }

        }

        private bool verificarRegistro(string nombre, string apellido, string tipoDni, string dni, string calle, string altura, string localidad, string cp)
        {
            if (nombre == "")
            {
                lblError.Text = "*Nombre requerido";
                return false;
            }
            if (apellido == "")
            {
                lblError.Text = "*Apellido requerido";
                return false;
            }
            if (dni == null)
            {
                lblError.Text = "*Dni requerido";
                return false;
            }
            if (calle == "" || altura == "" || localidad == "" || cp == "")
            {
                lblError.Text = "*Direccion incompleta";
                return false;
            }
            if (tipoDni == "")
            {
                lblError.Text = "*Debe seleccionar un tipo de documento";
                return false;
            }


            var socios = SocioService.ListaSocios()
                .Where(s => (s.Dni.ToString().Contains(dni)));
            var noSocios = NoSocioService.ListaNoSocios()
                .Where(s => (s.Dni.ToString().Contains(dni)));

            if (socios.Count() > 0 || noSocios.Count() > 0)
            {
                MessageBox.Show("Ya existe un cliente con el dni ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblError.Text = "*El cliente ya se encuentra registrado";
                return false;
            }

            return true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CargarSociosEnListView()
        {
            SocioService.cargarSocios(); // Carga la lista de socios desde el servicio

            listRegistro.Items.Clear(); // limpia el listView antes de cargar

            foreach (var s in SocioService.ListaSocios())
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

        private void CargarNoSociosEnListView()
        {
            NoSocioService.CargarNoSocios(); // Carga la lista de no socios desde el servicio

            listNoSocio.Items.Clear(); // limpia el listView antes de cargar
            foreach (var ns in NoSocioService.ListaNoSocios())
            {
                ListViewItem item = new ListViewItem(ns.IdNoSocio.ToString());
                item.SubItems.Add(ns.Nombre);
                item.SubItems.Add(ns.Apellido);
                item.SubItems.Add(ns.TipoDoc); // suponiendo que lo tengas
                item.SubItems.Add(ns.Dni.ToString());
                item.SubItems.Add(ns.Direccion); // ya formateada
                item.SubItems.Add(ns.FechaInscripcion.ToShortDateString());
                listNoSocio.Items.Add(item);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Button? boton = sender as Button;

            if (boton == null) return; // Simplified null check

            ListViewItem? item = null; // Inicializa el item como null

            switch (boton.Name)
            {
                case "btnEditar":
                    if (listRegistro.SelectedItems.Count > 0)
                        item = listRegistro.SelectedItems[0];
                    cbTipoRegistro.Text = "SOCIO"; // Set default value for cbTipoRegistro
                    break;
                case "btnEditNoSocio":
                    if (listNoSocio.SelectedItems.Count > 0)
                        item = listNoSocio.SelectedItems[0];
                    cbTipoRegistro.Text = "NO SOCIO"; // Set default value for cbTipoRegistro
                    break;

                default:
                    MessageBox.Show("Botón no reconocido.");
                    return;
            }

            if (item == null) // Simplified null check
            {
                MessageBox.Show("No hay ningún ítem seleccionado.");
                return;
            }

            // Verifica que tenga al menos dos subitems (índice 0 y 1)
            if (item.SubItems.Count >= 2)
            {
                txtNombre.Text = item.SubItems[1].Text;
                txtApellido.Text = item.SubItems[2].Text;
                cbTipoDni.Text = item.SubItems[3].Text; // Asumiendo que el tipo de DNI está en el índice 3
                txtDni.Text = item.SubItems[4].Text;
                txtCalle.Text = item.SubItems[5].Text.Split(',')[0]; // Asumiendo que la dirección está en el índice 5 y separada por espacios
                txtAltura.Text = item.SubItems[5].Text.Split(',')[1]; // Asumiendo que la dirección está en el índice 5 y separada por espacios
                txtLocalidad.Text = item.SubItems[5].Text.Split(',')[2]; // Asumiendo que la dirección está en el índice 5 y separada por espacios
                txtCp.Text = item.SubItems[5].Text.Split(',')[3]; // Asumiendo que la dirección está en el índice 5 y separada por espacios

                // Aquí puedes abrir un formulario de edición o hacer lo que necesites con los datos
                //MessageBox.Show($"Editando Socio:\nID: {numCarnet}\nNombre: {nombre}\nApellido: {apellido}\nDNI: {dni}\nDirección: {direccion}");
            }

            // Mostrar pestaña de edición
            btnRegistrar.Visible = false;
            btnActualizar.Visible = true;
            tabControl1.SelectedTab = REGISTRO;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Button? boton = sender as Button;

            if (boton == null) return; // Simplified null check

            ListViewItem? item = null; // Inicializa el item como null

            switch (boton.Name)
            {
                case "btnEliminar":
                    if (listRegistro.SelectedItems.Count > 0)
                        item = listRegistro.SelectedItems[0];
                    break;
                case "btnDeleteNoSocio":
                    if (listNoSocio.SelectedItems.Count > 0)
                        item = listNoSocio.SelectedItems[0];
                    break;

                default:
                    MessageBox.Show("Botón no reconocido.");
                    return;
            }

            if (item == null) // Simplified null check
            {
                MessageBox.Show("No hay ningún ítem seleccionado.");
                return;
            }

            if (item.SubItems.Count >= 1)
            {
                DialogResult result = MessageBox.Show(
                    $"¿Estás seguro de que deseas eliminar al {item.Name} {item.SubItems[1].Text} {item.SubItems[2].Text}? Esta acción no se puede deshacer.",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    int dni = Convert.ToInt32(item.SubItems[4].Text);
                    // Aquí puedes llamar a un método para eliminar el socio por su número de carnet

                    switch (boton.Name)
                    {
                        case "btnEliminar":
                            SocioService.DarDeBajaSocio(dni); // Asumiendo que tienes un método para eliminar socios
                            CargarSociosEnListView(); // Actualiza la lista de socios después de eliminar
                            break;
                        case "btnDeleteNoSocio":
                            NoSocioService.DarDeBajaNoSocio(dni); // Asumiendo que tienes un método para eliminar no socios
                            CargarNoSociosEnListView(); // Actualiza la lista de no socios después de eliminar
                            break;
                        case "btnDeleteProfesor":
                            // Aquí deberías implementar la lógica para eliminar un profesor, si es necesario
                            MessageBox.Show("Funcionalidad de eliminación de profesores aún no implementada.");
                            break;
                        default:
                            MessageBox.Show("Botón no reconocido.");
                            return;
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string direccion = txtCalle.Text.Trim() + ", " + txtAltura.Text + ", " + txtLocalidad.Text + ", " + txtCp.Text;

            switch (cbTipoRegistro.Text)
            {
                case "SOCIO":
                    // Corrected object initialization to match the constructor signature
                    var updateSocio = new Socio(
                        null, // Assuming NumCarnet is optional and can be null
                        txtNombre.Text.Trim(),
                        txtApellido.Text.Trim(),
                        cbTipoDni.Text,
                        Convert.ToInt32(txtDni.Text),
                        direccion,
                        DateTime.Now, // Fecha de inscripción actual
                        true // Asumimos que el carnet está activo al registrarlo
                    );

                    SocioService.ModificarSocio(updateSocio);
                    CargarSociosEnListView();// Actualiza la lista de socios

                    btnActualizar.Visible = false; // Oculta el botón de actualizar después de hacer clic
                    btnRegistrar.Visible = true; // Muestra el botón de registrar
                    tabControl1.SelectedTab = SOCIO; // Cambia a la pestaña de regist
                    limpiarCampos(); // Limpia los campos al cambiar de pestaña
                    break;
                case "NO SOCIO":

                    NoSocio newNoSocio = new NoSocio(
                          null, // Assuming NumCarnet is optional and can be null
                          txtNombre.Text.Trim(),
                          txtApellido.Text.Trim(),
                          cbTipoDni.Text,
                          Convert.ToInt32(txtDni.Text),
                          direccion,
                          DateTime.Now // Fecha de inscripción actual
                    );

                    NoSocioService.ModificarNoSocio(newNoSocio); // Registrar el nuevo no socio
                    CargarNoSociosEnListView();

                    btnActualizar.Visible = false; // Oculta el botón de actualizar después de hacer clic
                    btnRegistrar.Visible = true; // Muestra el botón de registrar
                    tabControl1.SelectedTab = NOSOCIO; // Cambia a la pestaña de registro de no socio
                    limpiarCampos(); // Limpia los campos al cambiar de pestaña
                    break;

                default:
                    MessageBox.Show("Por favor, seleccione un tipo de registro válido.");
                    break;
            }
        }

        private void RegistroForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dashBoard != null)
            {
                dashBoard.ActualizarVista(); // Actualiza la vista del DashBoard al cerrar el formulario de registro
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
