
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNumCarnet
            // 
            lblNumCarnet.AutoSize = true;
            lblNumCarnet.Location = new Point(38, 39);
            lblNumCarnet.Margin = new Padding(2, 0, 2, 0);
            lblNumCarnet.Name = "lblNumCarnet";
            lblNumCarnet.Size = new Size(131, 20);
            lblNumCarnet.TabIndex = 0;
            lblNumCarnet.Text = "Numero de Carnet";
            lblNumCarnet.Click += label1_Click;
            // 
            // txtNumCarnet
            // 
            txtNumCarnet.Location = new Point(205, 39);
            txtNumCarnet.Margin = new Padding(2, 2, 2, 2);
            txtNumCarnet.Name = "txtNumCarnet";
            txtNumCarnet.Size = new Size(121, 27);
            txtNumCarnet.TabIndex = 1;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(38, 86);
            lblFechaPago.Margin = new Padding(2, 0, 2, 0);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(105, 20);
            lblFechaPago.TabIndex = 2;
            lblFechaPago.Text = "Fecha de Pago";
            lblFechaPago.Click += label1_Click_1;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(205, 86);
            dtpFechaPago.Margin = new Padding(2, 2, 2, 2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(241, 27);
            dtpFechaPago.TabIndex = 3;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Location = new Point(698, 39);
            btnRegistrarPago.Margin = new Padding(2, 2, 2, 2);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(118, 42);
            btnRegistrarPago.TabIndex = 4;
            btnRegistrarPago.Text = "Registrar Pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += button1_Click;
            // 
            // btnMostrarCuotas
            // 
            btnMostrarCuotas.Location = new Point(698, 134);
            btnMostrarCuotas.Margin = new Padding(2, 2, 2, 2);
            btnMostrarCuotas.Name = "btnMostrarCuotas";
            btnMostrarCuotas.Size = new Size(118, 44);
            btnMostrarCuotas.TabIndex = 5;
            btnMostrarCuotas.Text = "Mostrar Cuotas";
            btnMostrarCuotas.UseVisualStyleBackColor = true;
            btnMostrarCuotas.Click += btnMostrarCuotas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 134);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(636, 180);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // CuotaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 360);
            Controls.Add(dataGridView1);
            Controls.Add(btnMostrarCuotas);
            Controls.Add(btnRegistrarPago);
            Controls.Add(dtpFechaPago);
            Controls.Add(lblFechaPago);
            Controls.Add(txtNumCarnet);
            Controls.Add(lblNumCarnet);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CuotaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAGOS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}