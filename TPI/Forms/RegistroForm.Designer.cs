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
            txtTelEmerg = new TextBox();
            label14 = new Label();
            txtPreEmerg = new TextBox();
            txtTel = new TextBox();
            label13 = new Label();
            txtEmail = new TextBox();
            label12 = new Label();
            label10 = new Label();
            txtPreTel = new TextBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txtLetra = new TextBox();
            txtPiso = new TextBox();
            label7 = new Label();
            txtAltura = new TextBox();
            label15 = new Label();
            txtLocalidad = new TextBox();
            txtCalle = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCp = new TextBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox8 = new GroupBox();
            radioF = new RadioButton();
            radioM = new RadioButton();
            comboMes = new ComboBox();
            comboYear = new ComboBox();
            comboDia = new ComboBox();
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
            EMAIL = new ColumnHeader();
            FECHANACIMIENTO = new ColumnHeader();
            TELEFONO = new ColumnHeader();
            TELEMERGENCIAS = new ColumnHeader();
            CALLE = new ColumnHeader();
            CALLEALTURA = new ColumnHeader();
            CALLEPISO = new ColumnHeader();
            DEPARTAMENTO = new ColumnHeader();
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
            groupBox8.SuspendLayout();
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
            tabControl1.Size = new Size(1148, 601);
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
            REGISTRO.Size = new Size(1140, 568);
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
            groupBox3.Controls.Add(txtTelEmerg);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtPreEmerg);
            groupBox3.Controls.Add(txtTel);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtPreTel);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(45, 221);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(858, 103);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "CONTACTO";
            // 
            // txtTelEmerg
            // 
            txtTelEmerg.Location = new Point(349, 58);
            txtTelEmerg.Name = "txtTelEmerg";
            txtTelEmerg.Size = new Size(149, 27);
            txtTelEmerg.TabIndex = 22;
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
            // txtPreEmerg
            // 
            txtPreEmerg.Location = new Point(270, 58);
            txtPreEmerg.Name = "txtPreEmerg";
            txtPreEmerg.Size = new Size(53, 27);
            txtPreEmerg.TabIndex = 20;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(85, 58);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(149, 27);
            txtTel.TabIndex = 19;
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
            // txtEmail
            // 
            txtEmail.Location = new Point(538, 58);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 27);
            txtEmail.TabIndex = 17;
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
            // txtPreTel
            // 
            txtPreTel.Location = new Point(6, 58);
            txtPreTel.Name = "txtPreTel";
            txtPreTel.Size = new Size(53, 27);
            txtPreTel.TabIndex = 13;
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
            button2.Location = new Point(915, 461);
            button2.Name = "button2";
            button2.Size = new Size(202, 48);
            button2.TabIndex = 26;
            button2.Text = "REGISTRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(915, 393);
            button1.Name = "button1";
            button1.Size = new Size(202, 48);
            button1.TabIndex = 25;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtLetra);
            groupBox2.Controls.Add(txtPiso);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtAltura);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtLocalidad);
            groupBox2.Controls.Add(txtCalle);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtCp);
            groupBox2.Location = new Point(45, 330);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 181);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "DIRRECCION";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 108);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 17;
            label8.Text = "LETRA / N°";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(131, 131);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(116, 27);
            txtLetra.TabIndex = 16;
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(6, 131);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(106, 27);
            txtPiso.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 108);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 14;
            label7.Text = "PISO";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(261, 63);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(77, 27);
            txtAltura.TabIndex = 13;
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
            groupBox4.Controls.Add(groupBox8);
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
            // groupBox8
            // 
            groupBox8.Controls.Add(radioF);
            groupBox8.Controls.Add(radioM);
            groupBox8.Location = new Point(431, 0);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(427, 88);
            groupBox8.TabIndex = 16;
            groupBox8.TabStop = false;
            groupBox8.Text = "SEXO";
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.Location = new Point(135, 38);
            radioF.Name = "radioF";
            radioF.Size = new Size(91, 24);
            radioF.TabIndex = 11;
            radioF.TabStop = true;
            radioF.Text = "HOMBRE";
            radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            radioM.AutoSize = true;
            radioM.Location = new Point(36, 37);
            radioM.Name = "radioM";
            radioM.Size = new Size(75, 24);
            radioM.TabIndex = 10;
            radioM.TabStop = true;
            radioM.Text = "MUJER";
            radioM.UseVisualStyleBackColor = true;
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
            tabPage2.Size = new Size(1140, 568);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "LISTADO";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listRegistro
            // 
            listRegistro.Columns.AddRange(new ColumnHeader[] { ID, NOMBRE, APELLIDO, TIPO, SEXO, DNI, EMAIL, FECHANACIMIENTO, TELEFONO, TELEMERGENCIAS, CALLE, CALLEALTURA, CALLEPISO, DEPARTAMENTO, LOCALIDAD, CP, FECHAREGISTRO, HORAREGISTRO });
            listRegistro.Dock = DockStyle.Fill;
            listRegistro.Location = new Point(3, 3);
            listRegistro.Name = "listRegistro";
            listRegistro.Size = new Size(1134, 562);
            listRegistro.TabIndex = 28;
            listRegistro.UseCompatibleStateImageBehavior = false;
            listRegistro.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "N° SOCIO";
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
            // EMAIL
            // 
            EMAIL.Text = "E-MAIL";
            EMAIL.Width = 180;
            // 
            // FECHANACIMIENTO
            // 
            FECHANACIMIENTO.Text = "FEC. NACIMIENTO";
            FECHANACIMIENTO.Width = 160;
            // 
            // TELEFONO
            // 
            TELEFONO.Text = "TELEFONO";
            TELEFONO.Width = 160;
            // 
            // TELEMERGENCIAS
            // 
            TELEMERGENCIAS.Text = "TEL. EMERGENCIAS";
            TELEMERGENCIAS.Width = 160;
            // 
            // CALLE
            // 
            CALLE.Text = "CALLE";
            CALLE.Width = 250;
            // 
            // CALLEALTURA
            // 
            CALLEALTURA.Text = "ALTURA N°";
            CALLEALTURA.TextAlign = HorizontalAlignment.Right;
            CALLEALTURA.Width = 90;
            // 
            // CALLEPISO
            // 
            CALLEPISO.Text = "PISO";
            // 
            // DEPARTAMENTO
            // 
            DEPARTAMENTO.Text = "DEPTO.";
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
            tabPage3.Size = new Size(1140, 568);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PROFESORES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1148, 601);
            Controls.Add(tabControl1);
            Name = "RegistroForm";
            Text = "Registro";
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
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage REGISTRO;
        private GroupBox groupBox3;
        private TextBox txtTelEmerg;
        private Label label14;
        private TextBox txtPreEmerg;
        private TextBox txtTel;
        private Label label13;
        private TextBox txtEmail;
        private Label label12;
        private Label label10;
        private TextBox txtPreTel;
        private Label label9;
        private ComboBox comboTipo;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox txtAltura;
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
        private Label label7;
        private Label label8;
        private TextBox txtLetra;
        private TextBox txtPiso;
        private GroupBox groupBox8;
        private ColumnHeader EMAIL;
        private ColumnHeader TELEFONO;
        private ColumnHeader TELEMERGENCIAS;
        private ColumnHeader CALLEALTURA;
        private ColumnHeader CALLEPISO;
        private ColumnHeader DEPARTAMENTO;
    }
}