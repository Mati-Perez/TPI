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
            button2 = new Button();
            button1 = new Button();
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
            tabPage2 = new TabPage();
            listRegistro = new ListView();
            ID = new ColumnHeader();
            NOMBRE = new ColumnHeader();
            APELLIDO = new ColumnHeader();
            TIPO = new ColumnHeader();
            DNI = new ColumnHeader();
            DIRECCION = new ColumnHeader();
            FECHAREGISTRO = new ColumnHeader();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            REGISTRO.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
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
            tabControl1.Size = new Size(813, 447);
            tabControl1.TabIndex = 0;
            // 
            // REGISTRO
            // 
            REGISTRO.BackColor = SystemColors.Control;
            REGISTRO.Controls.Add(button2);
            REGISTRO.Controls.Add(button1);
            REGISTRO.Controls.Add(groupBox7);
            REGISTRO.Controls.Add(groupBox6);
            REGISTRO.Controls.Add(groupBox2);
            REGISTRO.Controls.Add(groupBox1);
            REGISTRO.Controls.Add(groupBox5);
            REGISTRO.Location = new Point(4, 29);
            REGISTRO.Name = "REGISTRO";
            REGISTRO.Padding = new Padding(3);
            REGISTRO.Size = new Size(805, 414);
            REGISTRO.TabIndex = 0;
            REGISTRO.Text = "REGISTRO";
            // 
            // button2
            // 
            button2.Location = new Point(578, 346);
            button2.Name = "button2";
            button2.Size = new Size(202, 48);
            button2.TabIndex = 26;
            button2.Text = "REGISTRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(578, 292);
            button1.Name = "button1";
            button1.Size = new Size(202, 48);
            button1.TabIndex = 25;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbTipoRegistro);
            groupBox7.Location = new Point(578, 172);
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
            groupBox6.Location = new Point(578, 95);
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
            groupBox2.Location = new Point(8, 200);
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
            groupBox1.Location = new Point(8, 16);
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
            groupBox5.Location = new Point(578, 20);
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
            // tabPage2
            // 
            tabPage2.Controls.Add(listRegistro);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(805, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "LISTADO";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listRegistro
            // 
            listRegistro.Columns.AddRange(new ColumnHeader[] { ID, NOMBRE, APELLIDO, TIPO, DNI, DIRECCION, FECHAREGISTRO });
            listRegistro.Dock = DockStyle.Fill;
            listRegistro.Location = new Point(3, 3);
            listRegistro.Name = "listRegistro";
            listRegistro.Size = new Size(799, 408);
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
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(805, 414);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PROFESORES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(813, 447);
            Controls.Add(tabControl1);
            Name = "RegistroForm";
            Text = "Registro";
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
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage REGISTRO;
        private ComboBox cbTipoRegistro;
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
        private ColumnHeader DNI;
        private ColumnHeader DIRECCION;
        private ColumnHeader FECHAREGISTRO;
        private TabPage tabPage3;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private ColumnHeader TIPO;
        private TabControl tabControl1;
        private Label label9;
        private ComboBox cbTipoDni;
    }
}