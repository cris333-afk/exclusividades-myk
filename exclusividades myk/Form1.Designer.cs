namespace exclusividades_myk
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
            panel1 = new Panel();
            picLogo = new PictureBox();
            lbUsuario = new Label();
            lblContrasena = new Label();
            lblLogin = new Label();
            btnLogin = new Button();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            textUsuario = new TextBox();
            textContrasena = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 185, 190);
            panel1.Controls.Add(picLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 550);
            panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(22, 100);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(273, 303);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lbUsuario
            // 
            lbUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.ForeColor = Color.FromArgb(60, 60, 60);
            lbUsuario.Location = new Point(420, 160);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(417, 30);
            lbUsuario.TabIndex = 1;
            lbUsuario.Text = "USUARIO:";
            // 
            // lblContrasena
            // 
            lblContrasena.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.FromArgb(60, 60, 60);
            lblContrasena.Location = new Point(420, 260);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(417, 25);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "CONTRASEÑA:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.White;
            lblLogin.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(470, 80);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(291, 50);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "INICIAR SESION";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(27, 185, 190);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            btnLogin.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(420, 380);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ACCEDER";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(969, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 21);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(930, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(33, 21);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 6;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.White;
            textUsuario.BorderStyle = BorderStyle.FixedSingle;
            textUsuario.Font = new Font("Segoe UI", 12F);
            textUsuario.Location = new Point(420, 190);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(350, 34);
            textUsuario.TabIndex = 7;
            // 
            // textContrasena
            // 
            textContrasena.BackColor = Color.White;
            textContrasena.BorderStyle = BorderStyle.FixedSingle;
            textContrasena.Font = new Font("Segoe UI", 12F);
            textContrasena.Location = new Point(420, 290);
            textContrasena.Name = "textContrasena";
            textContrasena.PasswordChar = '*';
            textContrasena.Size = new Size(350, 34);
            textContrasena.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_05_25_at_10_18_33_AM;
            pictureBox1.Location = new Point(352, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2026_05_25_at_10_18_33_AM__1_;
            pictureBox2.Location = new Point(352, 264);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 550);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textContrasena);
            Controls.Add(textUsuario);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnLogin);
            Controls.Add(lblLogin);
            Controls.Add(lblContrasena);
            Controls.Add(lbUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbUsuario;
        private Label lblContrasena;
        private Label lblLogin;
        private Button btnLogin;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox picLogo;
        private TextBox textUsuario;
        private TextBox textContrasena;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
