namespace TPI.Forms
{
    partial class RegistroForm
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
            tabControl1 = new TabControl();
            REGISTRO = new TabPage();
            groupBox7 = new GroupBox();
            comboTipo = new ComboBox();
            groupBox6 = new GroupBox();
            lblHora = new Label();
            groupBox5 = new GroupBox();
            lblFecha = new Label();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            label14 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label13 = new Label();
            textBox3 = new TextBox();
            label12 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            label15 = new Label();
            txtLocalidad = new TextBox();
            txtCalle = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCp = new TextBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            comboMes = new ComboBox();
            comboYear = new ComboBox();
            comboDia = new ComboBox();
            radioF = new RadioButton();
            radioM = new RadioButton();
            txtDni = new TextBox();
            label5 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            listRegistro = new ListView();
            ID = new ColumnHeader();
            NOMBRE = new ColumnHeader();
            APELLIDO = new ColumnHeader();
            TIPO = new ColumnHeader();
            SEXO = new ColumnHeader();
            DNI = new ColumnHeader();
            FECHANACIMIENTO = new ColumnHeader();
            CALLE = new ColumnHeader();
            LOCALIDAD = new ColumnHeader();
            CP = new ColumnHeader();
            FECHAREGISTRO = new ColumnHeader();
            HORAREGISTRO = new ColumnHeader();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            REGISTRO.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(REGISTRO);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(1148, 641);
            tabControl1.TabIndex = 0;
            // 
            // REGISTRO
            // 
            REGISTRO.BackColor = SystemColors.Control;
            REGISTRO.Controls.Add(groupBox7);
            REGISTRO.Controls.Add(groupBox6);
            REGISTRO.Controls.Add(groupBox5);
            REGISTRO.Controls.Add(groupBox3);
            REGISTRO.Controls.Add(button2);
            REGISTRO.Controls.Add(button1);
            REGISTRO.Controls.Add(groupBox2);
            REGISTRO.Controls.Add(groupBox1);
            REGISTRO.Location = new Point(4, 29);
            REGISTRO.Name = "REGISTRO";
            REGISTRO.Padding = new Padding(3);
            REGISTRO.Size = new Size(1140, 608);
            REGISTRO.TabIndex = 0;
            REGISTRO.Text = "REGISTRO";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(comboTipo);
            groupBox7.Location = new Point(915, 164);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(202, 76);
            groupBox7.TabIndex = 33;
            groupBox7.TabStop = false;
            groupBox7.Text = "TIPO DE REGISTRO";
            // 
            // comboTipo
            // 
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(12, 26);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(174, 28);
            comboTipo.TabIndex = 28;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblHora);
            groupBox6.Location = new Point(915, 87);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(202, 56);
            groupBox6.TabIndex = 32;
            groupBox6.TabStop = false;
            groupBox6.Text = "HORA";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(56, 23);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(72, 23);
            lblHora.TabIndex = 24;
            lblHora.Text = "17:00:23";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblFecha);
            groupBox5.Location = new Point(915, 25);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(202, 56);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            groupBox5.Text = "FECHA";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(56, 23);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(96, 23);
            lblFecha.TabIndex = 23;
            lblFecha.Text = "12/12/2021";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(45, 238);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(858, 103);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "CONTACTO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(349, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 27);
            textBox2.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(328, 61);
            label14.Name = "label14";
            label14.Size = new Size(15, 20);
            label14.TabIndex = 21;
            label14.Text = "-";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(270, 58);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(53, 27);
            textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(85, 58);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 27);
            textBox4.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(64, 61);
            label13.Name = "label13";
            label13.Size = new Size(15, 20);
            label13.TabIndex = 18;
            label13.Text = "-";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(538, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(538, 35);
            label12.Name = "label12";
            label12.Size = new Size(57, 20);
            label12.TabIndex = 16;
            label12.Text = "E-MAIL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(269, 35);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 14;
            label10.Text = "TEL. EMERGENCIA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(53, 27);
            textBox1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 35);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 12;
            label9.Text = "TELEFONO";
            // 
            // button2
            // 
            button2.Location = new Point(915, 442);
            button2.Name = "button2";
            button2.Size = new Size(186, 48);
            button2.TabIndex = 26;
            button2.Text = "REGISTRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(915, 374);
            button1.Name = "button1";
            button1.Size = new Size(186, 48);
            button1.TabIndex = 25;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtLocalidad);
            groupBox2.Controls.Add(txtCalle);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtCp);
            groupBox2.Location = new Point(45, 347);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 143);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "DIRRECCION";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(261, 63);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(77, 27);
            textBox6.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(261, 40);
            label15.Name = "label15";
            label15.Size = new Size(62, 20);
            label15.TabIndex = 12;
            label15.Text = "ALTURA";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(357, 63);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(256, 27);
            txtLocalidad.TabIndex = 11;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(6, 63);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(236, 27);
            txtCalle.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(357, 40);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 10;
            label6.Text = "LOCALIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 40);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "CALLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 40);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 6;
            label4.Text = "CP";
            // 
            // txtCp
            // 
            txtCp.Location = new Point(631, 63);
            txtCp.Name = "txtCp";
            txtCp.Size = new Size(156, 27);
            txtCp.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(radioF);
            groupBox1.Controls.Add(radioM);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(45, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 193);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS REGISTRO";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboMes);
            groupBox4.Controls.Add(comboYear);
            groupBox4.Controls.Add(comboDia);
            groupBox4.Location = new Point(0, 105);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(858, 88);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "FECHA DE NACIMIENTO";
            // 
            // comboMes
            // 
            comboMes.FormattingEnabled = true;
            comboMes.Location = new Point(77, 37);
            comboMes.Name = "comboMes";
            comboMes.Size = new Size(111, 28);
            comboMes.TabIndex = 14;
            comboMes.Text = "MES";
            // 
            // comboYear
            // 
            comboYear.FormattingEnabled = true;
            comboYear.Location = new Point(194, 37);
            comboYear.Name = "comboYear";
            comboYear.Size = new Size(91, 28);
            comboYear.TabIndex = 15;
            comboYear.Text = "AÑO";
            // 
            // comboDia
            // 
            comboDia.FormattingEnabled = true;
            comboDia.Items.AddRange(new object[] { "1" });
            comboDia.Location = new Point(10, 37);
            comboDia.Name = "comboDia";
            comboDia.Size = new Size(61, 28);
            comboDia.TabIndex = 13;
            comboDia.Text = "DIA";
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.Location = new Point(801, 62);
            radioF.Name = "radioF";
            radioF.Size = new Size(37, 24);
            radioF.TabIndex = 11;
            radioF.TabStop = true;
            radioF.Text = "F";
            radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            radioM.AutoSize = true;
            radioM.Location = new Point(752, 62);
            radioM.Name = "radioM";
            radioM.Size = new Size(43, 24);
            radioM.TabIndex = 10;
            radioM.TabStop = true;
            radioM.Text = "M";
            radioM.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(489, 62);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(249, 27);
            txtDni.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 39);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 8;
            label5.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(269, 62);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(197, 27);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 39);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "APELLIDO";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listRegistro);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1140, 608);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "LISTADO";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listRegistro
            // 
            listRegistro.Columns.AddRange(new ColumnHeader[] { ID, NOMBRE, APELLIDO, TIPO, SEXO, DNI, FECHANACIMIENTO, CALLE, LOCALIDAD, CP, FECHAREGISTRO, HORAREGISTRO });
            listRegistro.Dock = DockStyle.Fill;
            listRegistro.Location = new Point(3, 3);
            listRegistro.Name = "listRegistro";
            listRegistro.Size = new Size(1134, 602);
            listRegistro.TabIndex = 28;
            listRegistro.UseCompatibleStateImageBehavior = false;
            listRegistro.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 100;
            // 
            // NOMBRE
            // 
            NOMBRE.Text = "NOMBRE";
            NOMBRE.Width = 200;
            // 
            // APELLIDO
            // 
            APELLIDO.Text = "APELLIDO";
            APELLIDO.Width = 160;
            // 
            // TIPO
            // 
            TIPO.Text = "TIPO";
            TIPO.Width = 100;
            // 
            // SEXO
            // 
            SEXO.Text = "SEXO";
            // 
            // DNI
            // 
            DNI.Text = "DNI";
            DNI.Width = 150;
            // 
            // FECHANACIMIENTO
            // 
            FECHANACIMIENTO.Text = "FEC. NACIMIENTO";
            FECHANACIMIENTO.Width = 160;
            // 
            // CALLE
            // 
            CALLE.Text = "CALLE";
            CALLE.Width = 250;
            // 
            // LOCALIDAD
            // 
            LOCALIDAD.Text = "LOCALIDAD";
            LOCALIDAD.Width = 180;
            // 
            // CP
            // 
            CP.Text = "CP";
            CP.Width = 70;
            // 
            // FECHAREGISTRO
            // 
            FECHAREGISTRO.Text = "FEC. REGISTRO";
            FECHAREGISTRO.Width = 160;
            // 
            // HORAREGISTRO
            // 
            HORAREGISTRO.Text = "HORA REGISTRO";
            HORAREGISTRO.Width = 160;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1140, 608);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PROFESORES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 641);
            Controls.Add(tabControl1);
            Name = "RegistroForm";
            Text = "RegistroForm";
            tabControl1.ResumeLayout(false);
            REGISTRO.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage REGISTRO;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private Label label14;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label13;
        private TextBox textBox3;
        private Label label12;
        private Label label10;
        private TextBox textBox1;
        private Label label9;
        private ComboBox comboTipo;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private Label label15;
        private TextBox txtLocalidad;
        private TextBox txtCalle;
        private Label label6;
        private Label label3;
        private Label label4;
        private TextBox txtCp;
        private Label lblHora;
        private Label lblFecha;
        private GroupBox groupBox1;
        private RadioButton radioF;
        private RadioButton radioM;
        private TextBox txtDni;
        private Label label5;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TabPage tabPage2;
        private ListView listRegistro;
        private ColumnHeader ID;
        private ColumnHeader NOMBRE;
        private ColumnHeader APELLIDO;
        private ColumnHeader SEXO;
        private ColumnHeader DNI;
        private ColumnHeader CALLE;
        private ColumnHeader LOCALIDAD;
        private ColumnHeader CP;
        private ColumnHeader FECHAREGISTRO;
        private ColumnHeader HORAREGISTRO;
        private TabPage tabPage3;
        private GroupBox groupBox4;
        private ComboBox comboYear;
        private ComboBox comboMes;
        private ComboBox comboDia;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private ColumnHeader TIPO;
        private ColumnHeader FECHANACIMIENTO;
        private TabControl tabControl1;
    }
}