namespace TPI.Forms
{
    partial class frmFactura
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            lblDfecha = new Label();
            label3 = new Label();
            btnImprimir = new Button();
            lblNombre = new Label();
            lblSocio = new Label();
            label4 = new Label();
            lblDia = new Label();
            label5 = new Label();
            lblFPago = new Label();
            label6 = new Label();
            lblValor = new Label();
            panel4 = new Panel();
            lblCarnet = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(40, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(127, 23);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 0;
            label1.Text = "COMPROBANTE DE PAGO";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(40, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 64);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(33, 21);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 0;
            label2.Text = "Club Deportivo 7G";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(lblDfecha);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(270, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 64);
            panel3.TabIndex = 2;
            // 
            // lblDfecha
            // 
            lblDfecha.AutoSize = true;
            lblDfecha.Font = new Font("Segoe UI", 10F);
            lblDfecha.Location = new Point(77, 24);
            lblDfecha.Name = "lblDfecha";
            lblDfecha.Size = new Size(0, 19);
            lblDfecha.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 21);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = SystemColors.ActiveCaption;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Location = new Point(232, 337);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 39);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(24, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 19);
            lblNombre.TabIndex = 0;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI", 10F);
            lblSocio.Location = new Point(24, 46);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(0, 19);
            lblSocio.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(24, 74);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 2;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 10F);
            lblDia.Location = new Point(230, 74);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(0, 19);
            lblDia.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(24, 108);
            label5.Name = "label5";
            label5.Size = new Size(105, 19);
            label5.TabIndex = 4;
            label5.Text = "Forma de Pago:";
            // 
            // lblFPago
            // 
            lblFPago.AutoSize = true;
            lblFPago.Font = new Font("Segoe UI", 10F);
            lblFPago.Location = new Point(135, 108);
            lblFPago.Name = "lblFPago";
            lblFPago.Size = new Size(0, 19);
            lblFPago.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(230, 108);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 6;
            label6.Text = "Monto:  $";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 10F);
            lblValor.Location = new Point(306, 108);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(0, 19);
            lblValor.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(lblCarnet);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(lblValor);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(lblFPago);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblDia);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblSocio);
            panel4.Controls.Add(lblNombre);
            panel4.Location = new Point(40, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(477, 148);
            panel4.TabIndex = 3;
            // 
            // lblCarnet
            // 
            lblCarnet.AutoSize = true;
            lblCarnet.Font = new Font("Segoe UI", 10F);
            lblCarnet.Location = new Point(123, 80);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.Size = new Size(0, 19);
            lblCarnet.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(24, 74);
            label15.Name = "label15";
            label15.Size = new Size(80, 19);
            label15.TabIndex = 8;
            label15.Text = "Carnet:   N°";
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 389);
            Controls.Add(btnImprimir);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmFactura";
            Text = "Comprobante de Pago";
            Load += frmFactura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnImprimir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDfecha;
        private Label lblNombre;
        private Label lblSocio;
        private Label label4;
        private Label lblDia;
        private Label label5;
        private Label lblFPago;
        private Label label6;
        private Label lblValor;
        private Panel panel4;
        private Label lblCarnet;
        private Label label15;
    }
}