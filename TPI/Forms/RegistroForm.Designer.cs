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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(825, 447);
            tabControl1.TabIndex = 0;
            // 
            // REGISTRO
            // 
            REGISTRO.BackColor = SystemColors.Control;
            REGISTRO.Controls.Add(btnActualizar);
            REGISTRO.Controls.Add(btnRegistrar);
            REGISTRO.Controls.Add(btnCancelar);
            REGISTRO.Controls.Add(groupBox7);
            REGISTRO.Controls.Add(groupBox6);
            REGISTRO.Controls.Add(groupBox2);
            REGISTRO.Controls.Add(groupBox1);
            REGISTRO.Controls.Add(groupBox5);
            REGISTRO.Location = new Point(4, 29);
            REGISTRO.Name = "REGISTRO";
            REGISTRO.Padding = new Padding(3);
            REGISTRO.Size = new Size(817, 414);
            REGISTRO.TabIndex = 0;
            REGISTRO.Text = "REGISTRO";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(588, 345);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(202, 48);
            btnActualizar.TabIndex = 34;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(588, 345);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(202, 48);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button2_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(588, 291);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(202, 48);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbTipoRegistro);
            groupBox7.Location = new Point(588, 171);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(202, 76);
            groupBox7.TabIndex = 33;
            groupBox7.TabStop = false;
            groupBox7.Text = "TIPO DE REGISTRO";
            // 
            // cbTipoRegistro
            // 
            cbTipoRegistro.FormattingEnabled = true;
            cbTipoRegistro.Location = new Point(12, 26);
            cbTipoRegistro.Name = "cbTipoRegistro";
            cbTipoRegistro.Size = new Size(174, 28);
            cbTipoRegistro.TabIndex = 28;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblHora);
            groupBox6.Location = new Point(588, 94);
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
            groupBox2.Location = new Point(18, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(555, 190);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "DIRRECCION";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(261, 63);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 27);
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
            txtLocalidad.Location = new Point(6, 129);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(236, 27);
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
            label6.Location = new Point(6, 106);
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
            label4.Location = new Point(378, 40);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 6;
            label4.Text = "CP";
            // 
            // txtCp
            // 
            txtCp.Location = new Point(378, 63);
            txtCp.Name = "txtCp";
            txtCp.Size = new Size(100, 27);
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
            groupBox1.Location = new Point(18, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 178);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS REGISTRO";
            // 
            // cbTipoDni
            // 
            cbTipoDni.FormattingEnabled = true;
            cbTipoDni.Location = new Point(12, 128);
            cbTipoDni.Name = "cbTipoDni";
            cbTipoDni.Size = new Size(98, 28);
            cbTipoDni.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 105);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 34;
            label9.Text = "DNI TIPO";
            label9.Click += label9_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(127, 128);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(234, 27);
            txtDni.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 105);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 8;
            label5.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(267, 63);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(236, 27);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 40);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "APELLIDO";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblFecha);
            groupBox5.Location = new Point(588, 19);
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
            // SOCIO
            // 
            SOCIO.Controls.Add(listRegistro);
            SOCIO.Controls.Add(groupBox3);
            SOCIO.Location = new Point(4, 29);
            SOCIO.Name = "SOCIO";
            SOCIO.Padding = new Padding(3);
            SOCIO.Size = new Size(817, 414);
            SOCIO.TabIndex = 1;
            SOCIO.Text = "SOCIO";
            SOCIO.UseVisualStyleBackColor = true;
            // 
            // listRegistro
            // 
            listRegistro.Columns.AddRange(new ColumnHeader[] { ID, NOMBRE, APELLIDO, TIPO, DNI, DIRECCION, FECHAREGISTRO });
            listRegistro.Dock = DockStyle.Fill;
            listRegistro.Location = new Point(3, 3);
            listRegistro.Name = "listRegistro";
            listRegistro.Size = new Size(811, 342);
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
            groupBox3.Location = new Point(3, 345);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(811, 66);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "CONTROLES";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(632, 19);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(161, 41);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(446, 19);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(161, 41);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // NOSOCIO
            // 
            NOSOCIO.Controls.Add(listNoSocio);
            NOSOCIO.Controls.Add(groupBox4);
            NOSOCIO.Location = new Point(4, 29);
            NOSOCIO.Name = "NOSOCIO";
            NOSOCIO.Padding = new Padding(3);
            NOSOCIO.Size = new Size(817, 414);
            NOSOCIO.TabIndex = 2;
            NOSOCIO.Text = "NO SOCIOS";
            NOSOCIO.UseVisualStyleBackColor = true;
            // 
            // listNoSocio
            // 
            listNoSocio.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listNoSocio.Dock = DockStyle.Fill;
            listNoSocio.Location = new Point(3, 3);
            listNoSocio.Name = "listNoSocio";
            listNoSocio.Size = new Size(811, 342);
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
            groupBox4.Location = new Point(3, 345);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(811, 66);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "CONTROLES";
            // 
            // btnDeleteNoSocio
            // 
            btnDeleteNoSocio.Location = new Point(632, 19);
            btnDeleteNoSocio.Name = "btnDeleteNoSocio";
            btnDeleteNoSocio.Size = new Size(161, 41);
            btnDeleteNoSocio.TabIndex = 30;
            btnDeleteNoSocio.Text = "ELIMINAR";
            btnDeleteNoSocio.UseVisualStyleBackColor = true;
            btnDeleteNoSocio.Click += btnEliminar_Click;
            // 
            // btnEditNoSocio
            // 
            btnEditNoSocio.Location = new Point(446, 19);
            btnEditNoSocio.Name = "btnEditNoSocio";
            btnEditNoSocio.Size = new Size(161, 41);
            btnEditNoSocio.TabIndex = 29;
            btnEditNoSocio.Text = "EDITAR";
            btnEditNoSocio.UseVisualStyleBackColor = true;
            btnEditNoSocio.Click += btnEditar_Click;
            // 
            // PROFESORES
            // 
            PROFESORES.Controls.Add(listProfesores);
            PROFESORES.Controls.Add(groupBox8);
            PROFESORES.Location = new Point(4, 29);
            PROFESORES.Name = "PROFESORES";
            PROFESORES.Padding = new Padding(3);
            PROFESORES.Size = new Size(817, 414);
            PROFESORES.TabIndex = 3;
            PROFESORES.Text = "PROFESORES";
            PROFESORES.UseVisualStyleBackColor = true;
            // 
            // listProfesores
            // 
            listProfesores.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listProfesores.Dock = DockStyle.Fill;
            listProfesores.Location = new Point(3, 3);
            listProfesores.Name = "listProfesores";
            listProfesores.Size = new Size(811, 342);
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
            groupBox8.Location = new Point(3, 345);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(811, 66);
            groupBox8.TabIndex = 33;
            groupBox8.TabStop = false;
            groupBox8.Text = "CONTROLES";
            // 
            // btnDeleteProfesor
            // 
            btnDeleteProfesor.Location = new Point(632, 19);
            btnDeleteProfesor.Name = "btnDeleteProfesor";
            btnDeleteProfesor.Size = new Size(161, 41);
            btnDeleteProfesor.TabIndex = 30;
            btnDeleteProfesor.Text = "ELIMINAR";
            btnDeleteProfesor.UseVisualStyleBackColor = true;
            btnDeleteProfesor.Click += btnEliminar_Click;
            // 
            // btnEditProfesor
            // 
            btnEditProfesor.Location = new Point(446, 19);
            btnEditProfesor.Name = "btnEditProfesor";
            btnEditProfesor.Size = new Size(161, 41);
            btnEditProfesor.TabIndex = 29;
            btnEditProfesor.Text = "EDITAR";
            btnEditProfesor.UseVisualStyleBackColor = true;
            btnEditProfesor.Click += btnEditar_Click;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(825, 447);
            Controls.Add(tabControl1);
            Name = "RegistroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            FormClosed += RegistroForm_FormClosed;
            tabControl1.ResumeLayout(false);
            REGISTRO.ResumeLayout(false);
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
    }
}