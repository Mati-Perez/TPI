using System.Data;
using TPI.Forms;

namespace TPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "";
            lblPassword.Text = "";

            if (txtUsuario.Text == "USUARIO" || txtUsuario.Text == "")
            {
                lblUsuario.Text = "*Debe ingresar un usuario";
                lblUsuario.ForeColor = Color.Red;
                txtUsuario.Focus();
                return;
            }

            if (txtPass.Text == "PASSWORD" || txtPass.Text == "")
            {
                lblPassword.Text = "*Debe ingresar una contrase�a";
                lblPassword.ForeColor = Color.Red;
                txtPass.Focus();
                return;
            }

            lblPassword.Text = "";
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                RegistroForm registroForm = new RegistroForm();
               // registroForm.rol = Convert.ToString(tablaLogin.Rows[0][0]);
               // registroForm.usuario = Convert.ToString(txtUsuario.Text);
                registroForm.Show();
                this.Hide();
                //agregue
                CuotaForm cuotaForm = new CuotaForm();
                cuotaForm.Show();
                this.Hide();
            }
            else
            {
                lblPassword.Text = "*Usuario y/o contrase�a incorrectos";
                lblPassword.ForeColor = Color.Red;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if(txtPass.Text == "PASSWORD")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Text = "PASSWORD";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}
