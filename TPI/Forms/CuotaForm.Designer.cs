
namespace TPI.Forms
{
    partial class CuotaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumCarnet = new Label();
            txtNumCarnet = new TextBox();
            lblFechaPago = new Label();
            dtpFechaPago = new DateTimePicker();
            btnRegistrarPago = new Button();
            btnMostrarCuotas = new Button();
            dataGridView1 = new DataGridView();
            gpbFormaPago = new GroupBox();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gpbFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumCarnet
            // 
            lblNumCarnet.AutoSize = true;
            lblNumCarnet.Location = new Point(33, 29);
            lblNumCarnet.Margin = new Padding(2, 0, 2, 0);
            lblNumCarnet.Name = "lblNumCarnet";
            lblNumCarnet.Size = new Size(105, 15);
            lblNumCarnet.TabIndex = 0;
            lblNumCarnet.Text = "Numero de Carnet";
            // 
            // txtNumCarnet
            // 
            txtNumCarnet.Location = new Point(179, 29);
            txtNumCarnet.Margin = new Padding(2);
            txtNumCarnet.Name = "txtNumCarnet";
            txtNumCarnet.Size = new Size(106, 23);
            txtNumCarnet.TabIndex = 1;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(33, 64);
            lblFechaPago.Margin = new Padding(2, 0, 2, 0);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(84, 15);
            lblFechaPago.TabIndex = 2;
            lblFechaPago.Text = "Fecha de Pago";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(179, 64);
            dtpFechaPago.Margin = new Padding(2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(211, 23);
            dtpFechaPago.TabIndex = 3;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Location = new Point(501, 134);
            btnRegistrarPago.Margin = new Padding(2);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(103, 32);
            btnRegistrarPago.TabIndex = 4;
            btnRegistrarPago.Text = "Registrar Pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += button1_Click;
            // 
            // btnMostrarCuotas
            // 
            btnMostrarCuotas.Location = new Point(501, 185);
            btnMostrarCuotas.Margin = new Padding(2);
            btnMostrarCuotas.Name = "btnMostrarCuotas";
            btnMostrarCuotas.Size = new Size(103, 33);
            btnMostrarCuotas.TabIndex = 5;
            btnMostrarCuotas.Text = "Mostrar Cuotas";
            btnMostrarCuotas.UseVisualStyleBackColor = true;
            btnMostrarCuotas.Click += btnMostrarCuotas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 100);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(443, 135);
            dataGridView1.TabIndex = 6;
            // 
            // gpbFormaPago
            // 
            gpbFormaPago.Controls.Add(rbEfectivo);
            gpbFormaPago.Controls.Add(rbTarjeta);
            gpbFormaPago.Location = new Point(501, 29);
            gpbFormaPago.Name = "gpbFormaPago";
            gpbFormaPago.Size = new Size(200, 100);
            gpbFormaPago.TabIndex = 7;
            gpbFormaPago.TabStop = false;
            gpbFormaPago.Text = "Forma de Pago";
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(9, 59);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 1;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(9, 33);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(59, 19);
            rbTarjeta.TabIndex = 0;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // CuotaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 270);
            Controls.Add(gpbFormaPago);
            Controls.Add(dataGridView1);
            Controls.Add(btnMostrarCuotas);
            Controls.Add(btnRegistrarPago);
            Controls.Add(dtpFechaPago);
            Controls.Add(lblFechaPago);
            Controls.Add(txtNumCarnet);
            Controls.Add(lblNumCarnet);
            Margin = new Padding(2);
            Name = "CuotaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAGOS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gpbFormaPago.ResumeLayout(false);
            gpbFormaPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label lblNumCarnet;
        private TextBox txtNumCarnet;
        private Label lblFechaPago;
        private DateTimePicker dtpFechaPago;
        private Button btnRegistrarPago;
        private Button btnMostrarCuotas;
        private DataGridView dataGridView1;
        private GroupBox gpbFormaPago;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
    }
}