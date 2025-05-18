using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI.Forms
{


    public partial class RegistroForm : Form
    {
        //inicializo combo box
        static string[] tipo = { "SOCIO", "NO SOCIO", "PROFESOR" };
        static string[] mes = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };


        static void llenarCombo(ComboBox comboTipo, ComboBox comboDia, ComboBox comboMes, ComboBox comboYear)
        {
            foreach (string item in tipo)
            {
                comboTipo.Items.Add(item);
            }


            for (int i = 1; i <= 31; i++)
            {
                comboDia.Items.Add(i.ToString());
            }

            foreach (string item in mes)
            {
                comboMes.Items.Add(item);
            }


            int year = DateTime.Now.Year;
            for (int i = 1800; i <= (year - 5); i++)
            {
                comboYear.Items.Add(i.ToString());
            }
        }

        public RegistroForm()
        {
            InitializeComponent();
            Show_date();
            Show_Time();
            comboTipo.Text = "SOCIO"; // Set default value
            listRegistro.GridLines = true; //-> permite dibujar la grilla , las celdas 
            listRegistro.FullRowSelect = true; // -> permite selecionar la fila completa
            llenarCombo(comboTipo, comboDia, comboMes, comboYear);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Show_date();
            Show_Time();

            string id = new Random().Next(100).ToString();
            string sexo = radioM.Checked ? "M" : "F";
            String fechaNacimiento = comboDia.Text + "/" + comboMes.Text + "/" + comboYear.Text;

            ListViewItem fila = new ListViewItem(id);
            fila.SubItems.Add(txtNombre.Text);
            fila.SubItems.Add(txtApellido.Text);
            fila.SubItems.Add(comboTipo.Text);
            fila.SubItems.Add(sexo);
            fila.SubItems.Add(txtDni.Text);
            fila.SubItems.Add(fechaNacimiento);
            fila.SubItems.Add(txtCalle.Text);
            fila.SubItems.Add(txtLocalidad.Text);
            fila.SubItems.Add(txtCp.Text);
            fila.SubItems.Add(lblFecha.Text);
            fila.SubItems.Add(lblHora.Text);


            listRegistro.Items.Add(fila);
            tabControl1.SelectedTab = tabPage2;
        }

    }
}
