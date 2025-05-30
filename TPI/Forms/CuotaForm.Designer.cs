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
            tabControl1 = new System.Windows.Forms.TabControl();
            REGISTRO = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            chkPagado = new System.Windows.Forms.CheckBox();
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            txtMonto = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtIdCliente = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            listCuotas = new System.Windows.Forms.ListView();
            ID = new System.Windows.Forms.ColumnHeader();
            IDCLIENTE = new System.Windows.Forms.ColumnHeader();
            MONTO = new System.Windows.Forms.ColumnHeader();
            FECHA = new System.Windows.Forms.ColumnHeader();
            PAGADO = new System.Windows.Forms.ColumnHeader();
            tabControl1.SuspendLayout();
            REGISTRO.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(REGISTRO);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new System.Drawing.Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // REGISTRO
            // 
            REGISTRO.BackColor = System.Drawing.SystemColors.Control;
            REGISTRO.Controls.Add(groupBox1);
            REGISTRO.Controls.Add(button2);
            REGISTRO.Controls.Add(button1);
            REGISTRO.Location = new System.Drawing.Point(4, 29);
            REGISTRO.Name = "REGISTRO";
            REGISTRO.Padding = new System.Windows.Forms.Padding(3);
            REGISTRO.Size = new System.Drawing.Size(792, 417);
            REGISTRO.TabIndex = 0;
            REGISTRO.Text = "REGISTRO CUOTA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkPagado);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(45, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(702, 200);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS CUOTA";
            // 
            // chkPagado
            // 
            chkPagado.AutoSize = true;
            chkPagado.Location = new System.Drawing.Point(20, 140);
            chkPagado.Name = "chkPagado";
            chkPagado.Size = new System.Drawing.Size(80, 24);
            chkPagado.TabIndex = 6;
            chkPagado.Text = "PAGADO";
            chkPagado.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new System.Drawing.Point(20, 100);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(200, 27);
            dtpFecha.TabIndex = 5;
            dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "FECHA";
            // 
            // txtMonto
            // 
            txtMonto.Location = new System.Drawing.Point(20, 60);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new System.Drawing.Size(200, 27);
            txtMonto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "MONTO";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new System.Drawing.Point(20, 20);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new System.Drawing.Size(200, 27);
            txtIdCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "ID CLIENTE";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(545, 231);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(202, 48);
            button2.TabIndex = 26;
            button2.Text = "REGISTRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(545, 285);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(202, 48);
            button1.TabIndex = 25;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listCuotas);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "LISTADO CUOTAS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listCuotas
            // 
            listCuotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ID, IDCLIENTE, MONTO, FECHA, PAGADO });
            listCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            listCuotas.Location = new System.Drawing.Point(3, 3);
            listCuotas.Name = "listCuotas";
            listCuotas.Size = new System.Drawing.Size(786, 411);
            listCuotas.TabIndex = 28;
            listCuotas.UseCompatibleStateImageBehavior = false;
            listCuotas.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 100;
            // 
            // IDCLIENTE
            // 
            IDCLIENTE.Text = "ID CLIENTE";
            IDCLIENTE.Width = 150;
            // 
            // MONTO
            // 
            MONTO.Text = "MONTO";
            MONTO.Width = 150;
            // 
            // FECHA
            // 
            FECHA.Text = "FECHA";
            FECHA.Width = 150;
            // 
            // PAGADO
            // 
            PAGADO.Text = "PAGADO";
            PAGADO.Width = 100;
            // 
            // CuotaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tabControl1);
            Name = "CuotaForm";
            Text = "Gestionar Cuotas";
            tabControl1.ResumeLayout(false);
            REGISTRO.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage REGISTRO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPagado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listCuotas;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader IDCLIENTE;
        private System.Windows.Forms.ColumnHeader MONTO;
        private System.Windows.Forms.ColumnHeader FECHA;
        private System.Windows.Forms.ColumnHeader PAGADO;

        private void button2_Click(object sender, System.EventArgs e)
        {
        }
    }
}