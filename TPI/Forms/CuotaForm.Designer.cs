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
            SuspendLayout();
            // 
            // lblNumCarnet
            // 
            lblNumCarnet.AutoSize = true;
            lblNumCarnet.Location = new Point(47, 49);
            lblNumCarnet.Name = "lblNumCarnet";
            lblNumCarnet.Size = new Size(158, 25);
            lblNumCarnet.TabIndex = 0;
            lblNumCarnet.Text = "Numero de Carnet";
            lblNumCarnet.Click += label1_Click;
            // 
            // txtNumCarnet
            // 
            txtNumCarnet.Location = new Point(256, 49);
            txtNumCarnet.Name = "txtNumCarnet";
            txtNumCarnet.Size = new Size(150, 31);
            txtNumCarnet.TabIndex = 1;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(47, 107);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(127, 25);
            lblFechaPago.TabIndex = 2;
            lblFechaPago.Text = "Fecha de Pago";
            lblFechaPago.Click += label1_Click_1;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(256, 107);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(300, 31);
            dtpFechaPago.TabIndex = 3;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Location = new Point(597, 339);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(148, 52);
            btnRegistrarPago.TabIndex = 4;
            btnRegistrarPago.Text = "Registrar Pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += button1_Click;
            // 
            // CuotaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarPago);
            Controls.Add(dtpFechaPago);
            Controls.Add(lblFechaPago);
            Controls.Add(txtNumCarnet);
            Controls.Add(lblNumCarnet);
            Name = "CuotaForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumCarnet;
        private TextBox txtNumCarnet;
        private Label lblFechaPago;
        private DateTimePicker dtpFechaPago;
        private Button btnRegistrarPago;
    }
}