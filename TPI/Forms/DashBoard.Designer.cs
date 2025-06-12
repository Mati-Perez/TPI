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
            tableLayoutPanel2 = new TableLayoutPanel();
            listVistaBusquedaNosocio = new ListView();
            NOMBREBUSQUEDA = new ColumnHeader();
            APELLIDOBUSQUEDA = new ColumnHeader();
            DNIBUSQUEDA = new ColumnHeader();
            INSCRIPCIONBUSQUEDA = new ColumnHeader();
            panel5 = new Panel();
            txtBusquedaNosocio = new TextBox();
            rbBusqNoSocioApellido = new RadioButton();
            rbBusqNoSocioNombre = new RadioButton();
            rbBusqNoSocioDni = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            listVistaBusquedaSocio = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel4 = new Panel();
            rbBusqSocioApellido = new RadioButton();
            rbBusqSocioNombre = new RadioButton();
            rbBusqSocioDni = new RadioButton();
            txtBusquedaSocio = new TextBox();
            groupBox9 = new GroupBox();
            button1 = new Button();
            btnPagos = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            listVistaVencimientos = new ListView();
            CARNET = new ColumnHeader();
            NOMBREVENCIMIENTO = new ColumnHeader();
            APELLIDOVENCIMIENTO = new ColumnHeader();
            DNIVENCIMIENTO = new ColumnHeader();
            MONTO = new ColumnHeader();
            VENCIMIENTO = new ColumnHeader();
            panel6 = new Panel();
            rbBusqVencimientoNombre = new RadioButton();
            rbBusqVencimientoDni = new RadioButton();
            rbBusqVencimientoCarnet = new RadioButton();
            txtBusquedaVencimiento = new TextBox();
            groupBox6 = new GroupBox();
            panel7 = new Panel();
            groupBox7 = new GroupBox();
            lblCantidadClientes = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox9.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel6.SuspendLayout();
            groupBox6.SuspendLayout();
            panel7.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(31, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 411);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CANTIDADES";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(120, 0, 0);
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
            groupBox4.ForeColor = Color.WhiteSmoke;
            groupBox4.Location = new Point(31, 81);
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
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(58, 19);
            label3.Name = "label3";
            label3.Size = new Size(127, 31);
            label3.TabIndex = 3;
            label3.Text = "ACTIVIDAD";
            // 
            // btnRegistrarActividad
            // 
            btnRegistrarActividad.BackColor = Color.FromArgb(0, 48, 73);
            btnRegistrarActividad.FlatStyle = FlatStyle.Popup;
            btnRegistrarActividad.ForeColor = Color.WhiteSmoke;
            btnRegistrarActividad.Location = new Point(40, 293);
            btnRegistrarActividad.Name = "btnRegistrarActividad";
            btnRegistrarActividad.Size = new Size(159, 52);
            btnRegistrarActividad.TabIndex = 2;
            btnRegistrarActividad.Text = "AGREGAR";
            btnRegistrarActividad.UseVisualStyleBackColor = false;
            btnRegistrarActividad.Click += btnRegistrarActividad_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(120, 0, 0);
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
            groupBox3.ForeColor = Color.WhiteSmoke;
            groupBox3.Location = new Point(33, 81);
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
            lblCantidadNoSocio.ForeColor = Color.WhiteSmoke;
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
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(57, 19);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 2;
            label2.Text = "NO SOCIO";
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.FromArgb(0, 48, 73);
            btnRegistrarNoSocio.FlatStyle = FlatStyle.Popup;
            btnRegistrarNoSocio.ForeColor = Color.WhiteSmoke;
            btnRegistrarNoSocio.Location = new Point(36, 293);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(159, 52);
            btnRegistrarNoSocio.TabIndex = 1;
            btnRegistrarNoSocio.Text = "AGREGAR";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(120, 0, 0);
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
            groupBox2.BackColor = Color.FromArgb(120, 0, 0);
            groupBox2.Controls.Add(lblCantidadSocio);
            groupBox2.ForeColor = Color.WhiteSmoke;
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
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(77, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 1;
            label1.Text = "SOCIO";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = Color.FromArgb(0, 48, 73);
            btnRegistrarSocio.FlatStyle = FlatStyle.Popup;
            btnRegistrarSocio.ForeColor = Color.WhiteSmoke;
            btnRegistrarSocio.Location = new Point(40, 293);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(159, 52);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "AGREGAR";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.WhiteSmoke;
            groupBox5.Controls.Add(tableLayoutPanel2);
            groupBox5.Controls.Add(tableLayoutPanel1);
            groupBox5.ForeColor = Color.Black;
            groupBox5.Location = new Point(843, 31);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(696, 802);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "BUSQUEDA";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(listVistaBusquedaNosocio, 0, 1);
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Location = new Point(26, 410);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(632, 365);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // listVistaBusquedaNosocio
            // 
            listVistaBusquedaNosocio.BackColor = Color.FromArgb(0, 48, 73);
            listVistaBusquedaNosocio.Columns.AddRange(new ColumnHeader[] { NOMBREBUSQUEDA, APELLIDOBUSQUEDA, DNIBUSQUEDA, INSCRIPCIONBUSQUEDA });
            listVistaBusquedaNosocio.Dock = DockStyle.Fill;
            listVistaBusquedaNosocio.ForeColor = Color.WhiteSmoke;
            listVistaBusquedaNosocio.Location = new Point(3, 76);
            listVistaBusquedaNosocio.Name = "listVistaBusquedaNosocio";
            listVistaBusquedaNosocio.Size = new Size(626, 286);
            listVistaBusquedaNosocio.TabIndex = 11;
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
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 48, 73);
            panel5.Controls.Add(txtBusquedaNosocio);
            panel5.Controls.Add(rbBusqNoSocioApellido);
            panel5.Controls.Add(rbBusqNoSocioNombre);
            panel5.Controls.Add(rbBusqNoSocioDni);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(626, 67);
            panel5.TabIndex = 10;
            // 
            // txtBusquedaNosocio
            // 
            txtBusquedaNosocio.Location = new Point(13, 17);
            txtBusquedaNosocio.Name = "txtBusquedaNosocio";
            txtBusquedaNosocio.Size = new Size(216, 27);
            txtBusquedaNosocio.TabIndex = 11;
            txtBusquedaNosocio.TextChanged += txtBusquedaNosocio_TextChanged;
            // 
            // rbBusqNoSocioApellido
            // 
            rbBusqNoSocioApellido.AutoSize = true;
            rbBusqNoSocioApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBusqNoSocioApellido.ForeColor = Color.WhiteSmoke;
            rbBusqNoSocioApellido.Location = new Point(481, 17);
            rbBusqNoSocioApellido.Name = "rbBusqNoSocioApellido";
            rbBusqNoSocioApellido.Size = new Size(107, 27);
            rbBusqNoSocioApellido.TabIndex = 10;
            rbBusqNoSocioApellido.TabStop = true;
            rbBusqNoSocioApellido.Text = "APELLIDO";
            rbBusqNoSocioApellido.UseVisualStyleBackColor = true;
            // 
            // rbBusqNoSocioNombre
            // 
            rbBusqNoSocioNombre.AutoSize = true;
            rbBusqNoSocioNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBusqNoSocioNombre.ForeColor = Color.WhiteSmoke;
            rbBusqNoSocioNombre.Location = new Point(362, 17);
            rbBusqNoSocioNombre.Name = "rbBusqNoSocioNombre";
            rbBusqNoSocioNombre.Size = new Size(101, 27);
            rbBusqNoSocioNombre.TabIndex = 9;
            rbBusqNoSocioNombre.TabStop = true;
            rbBusqNoSocioNombre.Text = "NOMBRE";
            rbBusqNoSocioNombre.UseVisualStyleBackColor = true;
            // 
            // rbBusqNoSocioDni
            // 
            rbBusqNoSocioDni.AutoSize = true;
            rbBusqNoSocioDni.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBusqNoSocioDni.ForeColor = Color.WhiteSmoke;
            rbBusqNoSocioDni.Location = new Point(273, 17);
            rbBusqNoSocioDni.Name = "rbBusqNoSocioDni";
            rbBusqNoSocioDni.Size = new Size(61, 27);
            rbBusqNoSocioDni.TabIndex = 8;
            rbBusqNoSocioDni.TabStop = true;
            rbBusqNoSocioDni.Text = "DNI";
            rbBusqNoSocioDni.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(listVistaBusquedaSocio, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Location = new Point(26, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(632, 362);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // listVistaBusquedaSocio
            // 
            listVistaBusquedaSocio.BackColor = Color.FromArgb(0, 48, 73);
            listVistaBusquedaSocio.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listVistaBusquedaSocio.Dock = DockStyle.Fill;
            listVistaBusquedaSocio.ForeColor = Color.WhiteSmoke;
            listVistaBusquedaSocio.LabelEdit = true;
            listVistaBusquedaSocio.Location = new Point(3, 75);
            listVistaBusquedaSocio.Name = "listVistaBusquedaSocio";
            listVistaBusquedaSocio.Size = new Size(626, 284);
            listVistaBusquedaSocio.TabIndex = 9;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 48, 73);
            panel4.Controls.Add(rbBusqSocioApellido);
            panel4.Controls.Add(rbBusqSocioNombre);
            panel4.Controls.Add(rbBusqSocioDni);
            panel4.Controls.Add(txtBusquedaSocio);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 66);
            panel4.TabIndex = 10;
            // 
            // rbBusqSocioApellido
            // 
            rbBusqSocioApellido.AutoSize = true;
            rbBusqSocioApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBusqSocioApellido.ForeColor = Color.WhiteSmoke;
            rbBusqSocioApellido.Location = new Point(481, 17);
            rbBusqSocioApellido.Name = "rbBusqSocioApellido";
            rbBusqSocioApellido.Size = new Size(107, 27);
            rbBusqSocioApellido.TabIndex = 10;
            rbBusqSocioApellido.TabStop = true;
            rbBusqSocioApellido.Text = "APELLIDO";
            rbBusqSocioApellido.UseVisualStyleBackColor = true;
            // 
            // rbBusqSocioNombre
            // 
            rbBusqSocioNombre.AutoSize = true;
            rbBusqSocioNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBusqSocioNombre.ForeColor = Color.WhiteSmoke;
            rbBusqSocioNombre.Location = new Point(362, 17);
            rbBusqSocioNombre.Name = "rbBusqSocioNombre";
            rbBusqSocioNombre.Size = new Size(101, 27);
            rbBusqSocioNombre.TabIndex = 9;
            rbBusqSocioNombre.TabStop = true;
            rbBusqSocioNombre.Text = "NOMBRE";
            rbBusqSocioNombre.UseVisualStyleBackColor = true;
            // 
            // rbBusqSocioDni
            // 
            rbBusqSocioDni.AutoSize = true;
            rbBusqSocioDni.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBusqSocioDni.ForeColor = Color.WhiteSmoke;
            rbBusqSocioDni.Location = new Point(273, 17);
            rbBusqSocioDni.Name = "rbBusqSocioDni";
            rbBusqSocioDni.Size = new Size(61, 27);
            rbBusqSocioDni.TabIndex = 8;
            rbBusqSocioDni.TabStop = true;
            rbBusqSocioDni.Text = "DNI";
            rbBusqSocioDni.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaSocio
            // 
            txtBusquedaSocio.Location = new Point(13, 17);
            txtBusquedaSocio.Name = "txtBusquedaSocio";
            txtBusquedaSocio.Size = new Size(216, 27);
            txtBusquedaSocio.TabIndex = 7;
            txtBusquedaSocio.TextChanged += txtBusquedaSocio_TextChanged;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(button1);
            groupBox9.Controls.Add(btnPagos);
            groupBox9.ForeColor = Color.Black;
            groupBox9.Location = new Point(1574, 351);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(228, 269);
            groupBox9.TabIndex = 3;
            groupBox9.TabStop = false;
            groupBox9.Text = "OPCIONES";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 48, 73);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(29, 151);
            button1.Name = "button1";
            button1.Size = new Size(179, 55);
            button1.TabIndex = 1;
            button1.Text = "REGISTRO";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.FromArgb(0, 48, 73);
            btnPagos.FlatStyle = FlatStyle.Popup;
            btnPagos.ForeColor = Color.WhiteSmoke;
            btnPagos.Location = new Point(29, 78);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(179, 55);
            btnPagos.TabIndex = 0;
            btnPagos.Text = "PAGOS";
            btnPagos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(listVistaVencimientos, 0, 1);
            tableLayoutPanel3.Controls.Add(panel6, 0, 0);
            tableLayoutPanel3.Location = new Point(16, 26);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.Size = new Size(755, 332);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // listVistaVencimientos
            // 
            listVistaVencimientos.BackColor = Color.FromArgb(120, 0, 0);
            listVistaVencimientos.Columns.AddRange(new ColumnHeader[] { CARNET, NOMBREVENCIMIENTO, APELLIDOVENCIMIENTO, DNIVENCIMIENTO, MONTO, VENCIMIENTO });
            listVistaVencimientos.Dock = DockStyle.Fill;
            listVistaVencimientos.ForeColor = Color.WhiteSmoke;
            listVistaVencimientos.Location = new Point(3, 69);
            listVistaVencimientos.Name = "listVistaVencimientos";
            listVistaVencimientos.Size = new Size(749, 260);
            listVistaVencimientos.TabIndex = 4;
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
            APELLIDOVENCIMIENTO.Width = 100;
            // 
            // DNIVENCIMIENTO
            // 
            DNIVENCIMIENTO.Text = "DNI";
            DNIVENCIMIENTO.Width = 160;
            // 
            // MONTO
            // 
            MONTO.Text = "MONTO";
            MONTO.Width = 80;
            // 
            // VENCIMIENTO
            // 
            VENCIMIENTO.Text = "VENCIMIENTO";
            VENCIMIENTO.Width = 130;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(120, 0, 0);
            panel6.Controls.Add(rbBusqVencimientoNombre);
            panel6.Controls.Add(rbBusqVencimientoDni);
            panel6.Controls.Add(rbBusqVencimientoCarnet);
            panel6.Controls.Add(txtBusquedaVencimiento);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(749, 60);
            panel6.TabIndex = 5;
            // 
            // rbBusqVencimientoNombre
            // 
            rbBusqVencimientoNombre.AutoSize = true;
            rbBusqVencimientoNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBusqVencimientoNombre.ForeColor = Color.WhiteSmoke;
            rbBusqVencimientoNombre.Location = new Point(545, 18);
            rbBusqVencimientoNombre.Name = "rbBusqVencimientoNombre";
            rbBusqVencimientoNombre.Size = new Size(101, 27);
            rbBusqVencimientoNombre.TabIndex = 12;
            rbBusqVencimientoNombre.TabStop = true;
            rbBusqVencimientoNombre.Text = "NOMBRE";
            rbBusqVencimientoNombre.UseVisualStyleBackColor = true;
            // 
            // rbBusqVencimientoDni
            // 
            rbBusqVencimientoDni.AutoSize = true;
            rbBusqVencimientoDni.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBusqVencimientoDni.ForeColor = Color.WhiteSmoke;
            rbBusqVencimientoDni.Location = new Point(416, 18);
            rbBusqVencimientoDni.Name = "rbBusqVencimientoDni";
            rbBusqVencimientoDni.Size = new Size(61, 27);
            rbBusqVencimientoDni.TabIndex = 11;
            rbBusqVencimientoDni.TabStop = true;
            rbBusqVencimientoDni.Text = "DNI";
            rbBusqVencimientoDni.UseVisualStyleBackColor = true;
            // 
            // rbBusqVencimientoCarnet
            // 
            rbBusqVencimientoCarnet.AutoSize = true;
            rbBusqVencimientoCarnet.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBusqVencimientoCarnet.ForeColor = Color.WhiteSmoke;
            rbBusqVencimientoCarnet.Location = new Point(279, 18);
            rbBusqVencimientoCarnet.Name = "rbBusqVencimientoCarnet";
            rbBusqVencimientoCarnet.Size = new Size(94, 27);
            rbBusqVencimientoCarnet.TabIndex = 10;
            rbBusqVencimientoCarnet.TabStop = true;
            rbBusqVencimientoCarnet.Text = "CARNET";
            rbBusqVencimientoCarnet.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaVencimiento
            // 
            txtBusquedaVencimiento.Location = new Point(20, 20);
            txtBusquedaVencimiento.Name = "txtBusquedaVencimiento";
            txtBusquedaVencimiento.Size = new Size(216, 27);
            txtBusquedaVencimiento.TabIndex = 0;
            txtBusquedaVencimiento.TextChanged += txtBusquedaVencimiento_TextChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tableLayoutPanel3);
            groupBox6.Location = new Point(31, 448);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(796, 385);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "VENCIMIENTOS";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(102, 155, 188);
            panel7.Controls.Add(groupBox7);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(1574, 43);
            panel7.Name = "panel7";
            panel7.Size = new Size(228, 285);
            panel7.TabIndex = 5;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lblCantidadClientes);
            groupBox7.Location = new Point(41, 58);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(158, 199);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "TOTALES";
            // 
            // lblCantidadClientes
            // 
            lblCantidadClientes.AutoSize = true;
            lblCantidadClientes.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadClientes.Location = new Point(-6, 40);
            lblCantidadClientes.Name = "lblCantidadClientes";
            lblCantidadClientes.Size = new Size(174, 106);
            lblCantidadClientes.TabIndex = 0;
            lblCantidadClientes.Text = "151";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 14);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 0;
            label4.Text = "CLIENTES";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1814, 845);
            Controls.Add(panel7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox9);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SECTOR 7G";
            Load += DashBoard_Load;
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
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox9.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
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
        private GroupBox groupBox9;
        private Button btnPagos;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listVistaBusquedaSocio;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtBusquedaSocio;
        private Panel panel4;
        private RadioButton rbBusqSocioNombre;
        private RadioButton rbBusqSocioDni;
        private TableLayoutPanel tableLayoutPanel2;
        private ListView listVistaBusquedaNosocio;
        private ColumnHeader NOMBREBUSQUEDA;
        private ColumnHeader APELLIDOBUSQUEDA;
        private ColumnHeader DNIBUSQUEDA;
        private ColumnHeader INSCRIPCIONBUSQUEDA;
        private Panel panel5;
        private TextBox txtBusquedaNosocio;
        private RadioButton rbBusqNoSocioApellido;
        private RadioButton rbBusqNoSocioNombre;
        private RadioButton rbBusqNoSocioDni;
        private RadioButton rbBusqSocioApellido;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView listVistaVencimientos;
        private ColumnHeader CARNET;
        private ColumnHeader NOMBREVENCIMIENTO;
        private ColumnHeader APELLIDOVENCIMIENTO;
        private ColumnHeader DNIVENCIMIENTO;
        private ColumnHeader VENCIMIENTO;
        private Panel panel6;
        private RadioButton rbBusqVencimientoNombre;
        private RadioButton rbBusqVencimientoDni;
        private RadioButton rbBusqVencimientoCarnet;
        private TextBox txtBusquedaVencimiento;
        private GroupBox groupBox6;
        private Panel panel7;
        private GroupBox groupBox7;
        private Label lblCantidadClientes;
        private Label label4;
        private ColumnHeader MONTO;
    }
}