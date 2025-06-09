namespace TPI.Forms
{
    partial class DashBoard
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
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            groupBox4 = new GroupBox();
            lblCantidadActividad = new Label();
            label3 = new Label();
            btnRegistrarActividad = new Button();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            lblCantidadNoSocio = new Label();
            label2 = new Label();
            btnRegistrarNoSocio = new Button();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            lblCantidadSocio = new Label();
            label1 = new Label();
            btnRegistrarSocio = new Button();
            groupBox5 = new GroupBox();
            groupBox7 = new GroupBox();
            textBox3 = new TextBox();
            label9 = new Label();
            listVistaBusquedaNosocio = new ListView();
            NOMBREBUSQUEDA = new ColumnHeader();
            APELLIDOBUSQUEDA = new ColumnHeader();
            DNIBUSQUEDA = new ColumnHeader();
            INSCRIPCIONBUSQUEDA = new ColumnHeader();
            txtBusquedaNosocio = new TextBox();
            label8 = new Label();
            groupBox6 = new GroupBox();
            textBox1 = new TextBox();
            label4 = new Label();
            listVistaBusquedaSocio = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            txtBusquedaSocio = new TextBox();
            label7 = new Label();
            groupBox8 = new GroupBox();
            listVistaVencimientos = new ListView();
            CARNET = new ColumnHeader();
            NOMBREVENCIMIENTO = new ColumnHeader();
            APELLIDOVENCIMIENTO = new ColumnHeader();
            DNIVENCIMIENTO = new ColumnHeader();
            VENCIMIENTO = new ColumnHeader();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(31, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 411);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CANTIDADES";
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(groupBox4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnRegistrarActividad);
            panel3.Location = new Point(532, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 362);
            panel3.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblCantidadActividad);
            groupBox4.Location = new Point(25, 81);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(174, 161);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "REGISTRADOS";
            // 
            // lblCantidadActividad
            // 
            lblCantidadActividad.AutoSize = true;
            lblCantidadActividad.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadActividad.Location = new Point(0, 34);
            lblCantidadActividad.Name = "lblCantidadActividad";
            lblCantidadActividad.Size = new Size(174, 106);
            lblCantidadActividad.TabIndex = 2;
            lblCantidadActividad.Text = "010";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 19);
            label3.Name = "label3";
            label3.Size = new Size(127, 31);
            label3.TabIndex = 3;
            label3.Text = "ACTIVIDAD";
            // 
            // btnRegistrarActividad
            // 
            btnRegistrarActividad.Location = new Point(40, 293);
            btnRegistrarActividad.Name = "btnRegistrarActividad";
            btnRegistrarActividad.Size = new Size(159, 52);
            btnRegistrarActividad.TabIndex = 2;
            btnRegistrarActividad.Text = "AGREGAR";
            btnRegistrarActividad.UseVisualStyleBackColor = true;
            btnRegistrarActividad.Click += btnRegistrarActividad_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnRegistrarNoSocio);
            panel2.Location = new Point(271, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 362);
            panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblCantidadNoSocio);
            groupBox3.Location = new Point(36, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(174, 161);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "REGISTRADOS";
            // 
            // lblCantidadNoSocio
            // 
            lblCantidadNoSocio.AutoSize = true;
            lblCantidadNoSocio.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadNoSocio.Location = new Point(0, 34);
            lblCantidadNoSocio.Name = "lblCantidadNoSocio";
            lblCantidadNoSocio.Size = new Size(174, 106);
            lblCantidadNoSocio.TabIndex = 1;
            lblCantidadNoSocio.Text = "150";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 19);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 2;
            label2.Text = "NO SOCIO";
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.Location = new Point(36, 293);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(159, 52);
            btnRegistrarNoSocio.TabIndex = 1;
            btnRegistrarNoSocio.Text = "AGREGAR";
            btnRegistrarNoSocio.UseVisualStyleBackColor = true;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegistrarSocio);
            panel1.Location = new Point(16, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 362);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GrayText;
            groupBox2.Controls.Add(lblCantidadSocio);
            groupBox2.Location = new Point(33, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(174, 161);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "REGISTRADOS";
            // 
            // lblCantidadSocio
            // 
            lblCantidadSocio.AutoSize = true;
            lblCantidadSocio.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadSocio.Location = new Point(0, 34);
            lblCantidadSocio.Name = "lblCantidadSocio";
            lblCantidadSocio.Size = new Size(174, 106);
            lblCantidadSocio.TabIndex = 0;
            lblCantidadSocio.Text = "001";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 1;
            label1.Text = "SOCIO";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(40, 293);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(159, 52);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "AGREGAR";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Control;
            groupBox5.Controls.Add(groupBox7);
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Location = new Point(843, 31);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(696, 775);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "BUSQUEDA";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.Control;
            groupBox7.Controls.Add(textBox3);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(listVistaBusquedaNosocio);
            groupBox7.Controls.Add(txtBusquedaNosocio);
            groupBox7.Controls.Add(label8);
            groupBox7.Location = new Point(26, 413);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(632, 333);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "NO SOCIO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(250, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 27);
            textBox3.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(250, 46);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 4;
            label9.Text = "NOMBRE";
            // 
            // listVistaBusquedaNosocio
            // 
            listVistaBusquedaNosocio.Columns.AddRange(new ColumnHeader[] { NOMBREBUSQUEDA, APELLIDOBUSQUEDA, DNIBUSQUEDA, INSCRIPCIONBUSQUEDA });
            listVistaBusquedaNosocio.Location = new Point(16, 102);
            listVistaBusquedaNosocio.Name = "listVistaBusquedaNosocio";
            listVistaBusquedaNosocio.Size = new Size(585, 204);
            listVistaBusquedaNosocio.TabIndex = 3;
            listVistaBusquedaNosocio.UseCompatibleStateImageBehavior = false;
            listVistaBusquedaNosocio.View = View.Details;
            // 
            // NOMBREBUSQUEDA
            // 
            NOMBREBUSQUEDA.Text = "NOMBRE";
            NOMBREBUSQUEDA.Width = 160;
            // 
            // APELLIDOBUSQUEDA
            // 
            APELLIDOBUSQUEDA.Text = "APELLIDO";
            APELLIDOBUSQUEDA.Width = 160;
            // 
            // DNIBUSQUEDA
            // 
            DNIBUSQUEDA.Text = "DNI";
            DNIBUSQUEDA.Width = 160;
            // 
            // INSCRIPCIONBUSQUEDA
            // 
            INSCRIPCIONBUSQUEDA.Text = "INSCRIPCION";
            INSCRIPCIONBUSQUEDA.Width = 100;
            // 
            // txtBusquedaNosocio
            // 
            txtBusquedaNosocio.Location = new Point(16, 69);
            txtBusquedaNosocio.Name = "txtBusquedaNosocio";
            txtBusquedaNosocio.Size = new Size(216, 27);
            txtBusquedaNosocio.TabIndex = 3;
            txtBusquedaNosocio.TextChanged += txtBusquedaNosocio_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 46);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 2;
            label8.Text = "DNI";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.Control;
            groupBox6.Controls.Add(textBox1);
            groupBox6.Controls.Add(label4);
            groupBox6.Controls.Add(listVistaBusquedaSocio);
            groupBox6.Controls.Add(txtBusquedaSocio);
            groupBox6.Controls.Add(label7);
            groupBox6.Location = new Point(26, 54);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(632, 334);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "SOCIO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 41);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "NOMBRE";
            // 
            // listVistaBusquedaSocio
            // 
            listVistaBusquedaSocio.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listVistaBusquedaSocio.Location = new Point(16, 97);
            listVistaBusquedaSocio.Name = "listVistaBusquedaSocio";
            listVistaBusquedaSocio.Size = new Size(585, 204);
            listVistaBusquedaSocio.TabIndex = 4;
            listVistaBusquedaSocio.UseCompatibleStateImageBehavior = false;
            listVistaBusquedaSocio.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "NOMBRE";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "APELLIDO";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DNI";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "INSCRIPCION";
            columnHeader4.Width = 100;
            // 
            // txtBusquedaSocio
            // 
            txtBusquedaSocio.Location = new Point(16, 64);
            txtBusquedaSocio.Name = "txtBusquedaSocio";
            txtBusquedaSocio.Size = new Size(216, 27);
            txtBusquedaSocio.TabIndex = 1;
            txtBusquedaSocio.TextChanged += txtBusquedaSocio_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 41);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 0;
            label7.Text = "DNI";
            // 
            // groupBox8
            // 
            groupBox8.BackColor = SystemColors.Control;
            groupBox8.Controls.Add(listVistaVencimientos);
            groupBox8.Location = new Point(31, 462);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(796, 344);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "VENCIMIENTOS";
            // 
            // listVistaVencimientos
            // 
            listVistaVencimientos.Columns.AddRange(new ColumnHeader[] { CARNET, NOMBREVENCIMIENTO, APELLIDOVENCIMIENTO, DNIVENCIMIENTO, VENCIMIENTO });
            listVistaVencimientos.Location = new Point(16, 38);
            listVistaVencimientos.Name = "listVistaVencimientos";
            listVistaVencimientos.Size = new Size(755, 239);
            listVistaVencimientos.TabIndex = 3;
            listVistaVencimientos.UseCompatibleStateImageBehavior = false;
            listVistaVencimientos.View = View.Details;
            // 
            // CARNET
            // 
            CARNET.Text = "CARNET";
            CARNET.Width = 100;
            // 
            // NOMBREVENCIMIENTO
            // 
            NOMBREVENCIMIENTO.Text = "NOMBRE";
            NOMBREVENCIMIENTO.Width = 160;
            // 
            // APELLIDOVENCIMIENTO
            // 
            APELLIDOVENCIMIENTO.Text = "APELLIDO";
            APELLIDOVENCIMIENTO.Width = 160;
            // 
            // DNIVENCIMIENTO
            // 
            DNIVENCIMIENTO.Text = "DNI";
            DNIVENCIMIENTO.Width = 160;
            // 
            // VENCIMIENTO
            // 
            VENCIMIENTO.Text = "VENCIMIENTO";
            VENCIMIENTO.Width = 160;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1814, 845);
            Controls.Add(groupBox8);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            WindowState = FormWindowState.Minimized;
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private GroupBox groupBox4;
        private Label label3;
        private Button btnRegistrarActividad;
        private GroupBox groupBox3;
        private Label label2;
        private Button btnRegistrarNoSocio;
        private GroupBox groupBox2;
        private Label label1;
        private Button btnRegistrarSocio;
        private Label lblCantidadActividad;
        private Label lblCantidadNoSocio;
        private Label lblCantidadSocio;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private TextBox txtBusquedaNosocio;
        private Label label8;
        private GroupBox groupBox6;
        private TextBox txtBusquedaSocio;
        private Label label7;
        private GroupBox groupBox8;
        private ListView listVistaBusquedaNosocio;
        private ListView listVistaVencimientos;
        private ColumnHeader NOMBREBUSQUEDA;
        private ColumnHeader APELLIDOBUSQUEDA;
        private ColumnHeader DNIBUSQUEDA;
        private ColumnHeader INSCRIPCIONBUSQUEDA;
        private ListView listVistaBusquedaSocio;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader CARNET;
        private ColumnHeader NOMBREVENCIMIENTO;
        private ColumnHeader APELLIDOVENCIMIENTO;
        private ColumnHeader DNIVENCIMIENTO;
        private ColumnHeader VENCIMIENTO;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox1;
        private Label label4;
    }
}