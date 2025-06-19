using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI.Forms
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }
        public string? nombre_f;
        public string? apellido_f;
        public float monto_f;
        public int carnet_f;
        public string? forma_f;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true; // visualizamos nuevamente el objeto
            /* _________________________________
            * regreso al formulario principal
            * después del dar aviso
            * ---------------------------------- */
            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DashBoard principal = new DashBoard();
            principal.Show();
            this.Close();
        }

        /* -------------------------------------------------------
        * Conjunto de sentencias necesarias para
        * el objeto Print
        * ------------------------------------------------------- */
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
        private void frmFactura_Load(object sender, EventArgs e)
        {
            /* ----------------------------------------
            * asignación de los valores a los datos
            * que muestra cada etiqueta del diseño
            * del comprobante de pago
            * --------------------------------------------- */
            lblNombre.Text = nombre_f + " " + apellido_f;
            lblSocio.Text = "Se ha completado el registro de socio";
            lblCarnet.Text = carnet_f.ToString();
            lblValor.Text = Convert.ToString(monto_f);
            lblFPago.Text = forma_f;
            // se obtiene la fecha actual
            lblDfecha.Text = DateTime.UtcNow.ToShortDateString();
        }
    }
}
