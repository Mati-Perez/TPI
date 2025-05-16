using System.Data;

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
            lblMensaje.Text = "";
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                //aca abajo iria para ir al nuevo form

                //FrmPrincipal Principal = new FrmPrincipal();

                //Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);

                //Principal.usuario = Convert.ToString(txtUsuario.Text);
                //Principal.Show();
                //this.Hide();
            }
            else
            {
                lblMensaje.Text = "*Usuario y/o contraseña incorrectos";
                lblMensaje.ForeColor = Color.Red;
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
            if(txtPass.Text == "CONTRASEÑA")
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
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}
