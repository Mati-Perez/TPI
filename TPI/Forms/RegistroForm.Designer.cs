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
            lblError = new Label();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            groupBox7 = new GroupBox();
            cbTipoRegistro = new ComboBox();
            groupBox6 = new GroupBox();
            lblHora = new Label();
            groupBox2 = new GroupBox();
            txtAltura = new TextBox();
            label15 = new Label();
            txtLocalidad = new TextBox();
            txtCalle = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCp = new TextBox();
            groupBox1 = new GroupBox();
            cbTipoDni = new ComboBox();
            label9 = new Label();
            txtDni = new TextBox();
            label5 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            lblFecha = new Label();
            SOCIO = new TabPage();
            listRegistro = new ListView();
            ID = new ColumnHeader();
            NOMBRE = new ColumnHeader();
            APELLIDO = new ColumnHeader();
            TIPO = new ColumnHeader();
            DNI = new ColumnHeader();
            DIRECCION = new ColumnHeader();
            FECHAREGISTRO = new ColumnHeader();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            NOSOCIO = new TabPage();
            listNoSocio = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox4 = new GroupBox();
            btnDeleteNoSocio = new Button();
            btnEditNoSocio = new Button();
            PROFESORES = new TabPage();
            listProfesores = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            groupBox8 = new GroupBox();
            btnDeleteProfesor = new Button();
            btnEditProfesor = new Button();
            tabControl1.SuspendLayout();
            REGISTRO.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            SOCIO.SuspendLayout();
            groupBox3.SuspendLayout();
            NOSOCIO.SuspendLayout();
            groupBox4.SuspendLayout();
            PROFESORES.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(REGISTRO);
            tabControl1.Controls.Add(SOCIO);
            tabControl1.Controls.Add(NOSOCIO);
            tabControl1.Controls.Add(PROFESORES);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(722, 393);
            tabControl1.TabIndex = 0;
            // 
            // REGISTRO
            // 
            REGISTRO.BackColor = SystemColors.Control;
            REGISTRO.Controls.Add(lblError);
            REGISTRO.Controls.Add(btnActualizar);
            REGISTRO.Controls.Add(btnRegistrar);
            REGISTRO.Controls.Add(btnCancelar);
            REGISTRO.Controls.Add(groupBox7);
            REGISTRO.Controls.Add(groupBox6);
            REGISTRO.Controls.Add(groupBox2);
            REGISTRO.Controls.Add(groupBox1);
            REGISTRO.Controls.Add(groupBox5);
            REGISTRO.Location = new Point(4, 24);
            REGISTRO.Margin = new Padding(3, 2, 3, 2);
            REGISTRO.Name = "REGISTRO";
            REGISTRO.Padding = new Padding(3, 2, 3, 2);
            REGISTRO.Size = new Size(714, 365);
            REGISTRO.TabIndex = 0;
            REGISTRO.Text = "REGISTRO";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(18, 325);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 35;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(514, 259);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(177, 36);
            btnActualizar.TabIndex = 34;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(514, 259);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(177, 36);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button2_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(514, 218);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(177, 36);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbTipoRegistro);
            groupBox7.Location = new Point(514, 128);
            groupBox7.Margin = new Padding(3, 2, 3, 2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 2, 3, 2);
            groupBox7.Size = new Size(177, 57);
            groupBox7.TabIndex = 33;
            groupBox7.TabStop = false;
            groupBox7.Text = "TIPO DE REGISTRO";
            // 
            // cbTipoRegistro
            // 
            cbTipoRegistro.FormattingEnabled = true;
            cbTipoRegistro.Location = new Point(10, 20);
            cbTipoRegistro.Margin = new Padding(3, 2, 3, 2);
            cbTipoRegistro.Name = "cbTipoRegistro";
            cbTipoRegistro.Size = new Size(153, 23);
            cbTipoRegistro.TabIndex = 28;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblHora);
            groupBox6.Location = new Point(514, 70);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(177, 42);
            groupBox6.TabIndex = 32;
            groupBox6.TabStop = false;
            groupBox6.Text = "HORA";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(49, 17);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(63, 19);
            lblHora.TabIndex = 24;
            lblHora.Text = "17:00:23";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAltura);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtLocalidad);
            groupBox2.Controls.Add(txtCalle);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtCp);
            groupBox2.Location = new Point(16, 181);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(486, 134);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "DIRRECCION";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(228, 47);
            txtAltura.Margin = new Padding(3, 2, 3, 2);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(88, 23);
            txtAltura.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(228, 30);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 12;
            label15.Text = "ALTURA";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(5, 97);
            txtLocalidad.Margin = new Padding(3, 2, 3, 2);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(207, 23);
            txtLocalidad.TabIndex = 11;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(5, 47);
            txtCalle.Margin = new Padding(3, 2, 3, 2);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(207, 23);
            txtCalle.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 80);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 10;
            label6.Text = "LOCALIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 30);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "CALLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 30);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 6;
            label4.Text = "CP";
            // 
            // txtCp
            // 
            txtCp.Location = new Point(331, 47);
            txtCp.Margin = new Padding(3, 2, 3, 2);
            txtCp.Name = "txtCp";
            txtCp.Size = new Size(88, 23);
            txtCp.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTipoDni);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(486, 160);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS REGISTRO";
            // 
            // cbTipoDni
            // 
            cbTipoDni.FormattingEnabled = true;
            cbTipoDni.Location = new Point(10, 96);
            cbTipoDni.Margin = new Padding(3, 2, 3, 2);
            cbTipoDni.Name = "cbTipoDni";
            cbTipoDni.Size = new Size(86, 23);
            cbTipoDni.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 79);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 34;
            label9.Text = "DNI TIPO";
            label9.Click += label9_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(111, 96);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(205, 23);
            txtDni.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 79);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 8;
            label5.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(234, 47);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(207, 23);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 30);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "APELLIDO";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(10, 47);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblFecha);
            groupBox5.Location = new Point(514, 14);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(177, 42);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            groupBox5.Text = "FECHA";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(49, 17);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(83, 19);
            lblFecha.TabIndex = 23;
            lblFecha.Text = "12/12/2021";
            // 
            // SOCIO
            // 
            SOCIO.Controls.Add(listRegistro);
            SOCIO.Controls.Add(groupBox3);
            SOCIO.Location = new Point(4, 24);
            SOCIO.Margin = new Padding(3, 2, 3, 2);
            SOCIO.Name = "SOCIO";
            SOCIO.Padding = new Padding(3, 2, 3, 2);
            SOCIO.Size = new Size(714, 365);
            SOCIO.TabIndex = 1;
            SOCIO.Text = "SOCIO";
            SOCIO.UseVisualStyleBackColor = true;
            // 
            // listRegistro
            // 
            listRegistro.Columns.AddRange(new ColumnHeader[] { ID, NOMBRE, APELLIDO, TIPO, DNI, DIRECCION, FECHAREGISTRO });
            listRegistro.Dock = DockStyle.Fill;
            listRegistro.Location = new Point(3, 2);
            listRegistro.Margin = new Padding(3, 2, 3, 2);
            listRegistro.Name = "listRegistro";
            listRegistro.Size = new Size(708, 311);
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
            // DNI
            // 
            DNI.Text = "DNI";
            DNI.Width = 150;
            // 
            // DIRECCION
            // 
            DIRECCION.Text = "DIRECCION";
            DIRECCION.Width = 250;
            // 
            // FECHAREGISTRO
            // 
            FECHAREGISTRO.Text = "FEC. REGISTRO";
            FECHAREGISTRO.Width = 160;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnEditar);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(3, 313);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(708, 50);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "CONTROLES";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(553, 14);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 31);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(390, 14);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(141, 31);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // NOSOCIO
            // 
            NOSOCIO.Controls.Add(listNoSocio);
            NOSOCIO.Controls.Add(groupBox4);
            NOSOCIO.Location = new Point(4, 24);
            NOSOCIO.Margin = new Padding(3, 2, 3, 2);
            NOSOCIO.Name = "NOSOCIO";
            NOSOCIO.Padding = new Padding(3, 2, 3, 2);
            NOSOCIO.Size = new Size(714, 365);
            NOSOCIO.TabIndex = 2;
            NOSOCIO.Text = "NO SOCIOS";
            NOSOCIO.UseVisualStyleBackColor = true;
            // 
            // listNoSocio
            // 
            listNoSocio.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listNoSocio.Dock = DockStyle.Fill;
            listNoSocio.Location = new Point(3, 2);
            listNoSocio.Margin = new Padding(3, 2, 3, 2);
            listNoSocio.Name = "listNoSocio";
            listNoSocio.Size = new Size(708, 311);
            listNoSocio.TabIndex = 33;
            listNoSocio.UseCompatibleStateImageBehavior = false;
            listNoSocio.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOMBRE";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "APELLIDO";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TIPO";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "DNI";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "DIRECCION";
            columnHeader6.Width = 250;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "FEC. REGISTRO";
            columnHeader7.Width = 160;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDeleteNoSocio);
            groupBox4.Controls.Add(btnEditNoSocio);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(3, 313);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(708, 50);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "CONTROLES";
            // 
            // btnDeleteNoSocio
            // 
            btnDeleteNoSocio.Location = new Point(553, 14);
            btnDeleteNoSocio.Margin = new Padding(3, 2, 3, 2);
            btnDeleteNoSocio.Name = "btnDeleteNoSocio";
            btnDeleteNoSocio.Size = new Size(141, 31);
            btnDeleteNoSocio.TabIndex = 30;
            btnDeleteNoSocio.Text = "ELIMINAR";
            btnDeleteNoSocio.UseVisualStyleBackColor = true;
            btnDeleteNoSocio.Click += btnEliminar_Click;
            // 
            // btnEditNoSocio
            // 
            btnEditNoSocio.Location = new Point(390, 14);
            btnEditNoSocio.Margin = new Padding(3, 2, 3, 2);
            btnEditNoSocio.Name = "btnEditNoSocio";
            btnEditNoSocio.Size = new Size(141, 31);
            btnEditNoSocio.TabIndex = 29;
            btnEditNoSocio.Text = "EDITAR";
            btnEditNoSocio.UseVisualStyleBackColor = true;
            btnEditNoSocio.Click += btnEditar_Click;
            // 
            // PROFESORES
            // 
            PROFESORES.Controls.Add(listProfesores);
            PROFESORES.Controls.Add(groupBox8);
            PROFESORES.Location = new Point(4, 24);
            PROFESORES.Margin = new Padding(3, 2, 3, 2);
            PROFESORES.Name = "PROFESORES";
            PROFESORES.Padding = new Padding(3, 2, 3, 2);
            PROFESORES.Size = new Size(714, 365);
            PROFESORES.TabIndex = 3;
            PROFESORES.Text = "PROFESORES";
            PROFESORES.UseVisualStyleBackColor = true;
            // 
            // listProfesores
            // 
            listProfesores.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listProfesores.Dock = DockStyle.Fill;
            listProfesores.Location = new Point(3, 2);
            listProfesores.Margin = new Padding(3, 2, 3, 2);
            listProfesores.Name = "listProfesores";
            listProfesores.Size = new Size(708, 311);
            listProfesores.TabIndex = 34;
            listProfesores.UseCompatibleStateImageBehavior = false;
            listProfesores.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ID";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "NOMBRE";
            columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "APELLIDO";
            columnHeader10.Width = 160;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "TIPO";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "DNI";
            columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "DIRECCION";
            columnHeader13.Width = 250;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "FEC. REGISTRO";
            columnHeader14.Width = 160;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btnDeleteProfesor);
            groupBox8.Controls.Add(btnEditProfesor);
            groupBox8.Dock = DockStyle.Bottom;
            groupBox8.Location = new Point(3, 313);
            groupBox8.Margin = new Padding(3, 2, 3, 2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 2, 3, 2);
            groupBox8.Size = new Size(708, 50);
            groupBox8.TabIndex = 33;
            groupBox8.TabStop = false;
            groupBox8.Text = "CONTROLES";
            // 
            // btnDeleteProfesor
            // 
            btnDeleteProfesor.Location = new Point(553, 14);
            btnDeleteProfesor.Margin = new Padding(3, 2, 3, 2);
            btnDeleteProfesor.Name = "btnDeleteProfesor";
            btnDeleteProfesor.Size = new Size(141, 31);
            btnDeleteProfesor.TabIndex = 30;
            btnDeleteProfesor.Text = "ELIMINAR";
            btnDeleteProfesor.UseVisualStyleBackColor = true;
            btnDeleteProfesor.Click += btnEliminar_Click;
            // 
            // btnEditProfesor
            // 
            btnEditProfesor.Location = new Point(390, 14);
            btnEditProfesor.Margin = new Padding(3, 2, 3, 2);
            btnEditProfesor.Name = "btnEditProfesor";
            btnEditProfesor.Size = new Size(141, 31);
            btnEditProfesor.TabIndex = 29;
            btnEditProfesor.Text = "EDITAR";
            btnEditProfesor.UseVisualStyleBackColor = true;
            btnEditProfesor.Click += btnEditar_Click;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(722, 393);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            FormClosed += RegistroForm_FormClosed;
            tabControl1.ResumeLayout(false);
            REGISTRO.ResumeLayout(false);
            REGISTRO.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            SOCIO.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            NOSOCIO.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            PROFESORES.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage REGISTRO;
        private ComboBox cbTipoRegistro;
        private Button btnRegistrar;
        private Button btnCancelar;
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
        private TextBox txtDni;
        private Label label5;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TabPage SOCIO;
        private ListView listRegistro;
        private ColumnHeader ID;
        private ColumnHeader NOMBRE;
        private ColumnHeader APELLIDO;
        private ColumnHeader DNI;
        private ColumnHeader DIRECCION;
        private ColumnHeader FECHAREGISTRO;
        private TabPage NOSOCIO;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private ColumnHeader TIPO;
        private TabControl tabControl1;
        private Label label9;
        private ComboBox cbTipoDni;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnActualizar;
        private TabPage PROFESORES;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnDeleteNoSocio;
        private Button btnEditNoSocio;
        private ListView listNoSocio;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView listProfesores;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private GroupBox groupBox8;
        private Button btnDeleteProfesor;
        private Button btnEditProfesor;
        private Label lblError;
    }
}