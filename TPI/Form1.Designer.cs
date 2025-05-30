namespace TPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnIngresar = new Button();
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblPassword = new Label();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Indigo;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ButtonFace;
            btnIngresar.Location = new Point(323, 255);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(98, 43);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtPass
            // 
            txtPass.ForeColor = Color.Silver;
            txtPass.Location = new Point(294, 182);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(155, 23);
            txtPass.TabIndex = 1;
            txtPass.Text = "PASSWORD";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.Silver;
            txtUsuario.Location = new Point(294, 115);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(285, 71);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 3;
            label1.Text = "INGRESO AL SISTEMA";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Location = new Point(294, 219);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 15);
            lblPassword.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Location = new Point(294, 141);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(535, 348);
            Controls.Add(lblUsuario);
            Controls.Add(lblPassword);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtPass);
            Controls.Add(btnIngresar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtPass;
        private TextBox txtUsuario;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblPassword;
        private Label lblUsuario;
    }
}
