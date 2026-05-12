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
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(picLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(3, 83);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(244, 153);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lbUsuario
            // 
            lbUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsuario.ForeColor = Color.Black;
            lbUsuario.Location = new Point(287, 83);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(417, 30);
            lbUsuario.TabIndex = 1;
            lbUsuario.Text = "USUARIO:";
            // 
            // lblContrasena
            // 
            lblContrasena.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(287, 173);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(417, 25);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "CONTRASEÑA:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(433, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(73, 23);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gainsboro;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            btnLogin.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(335, 273);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(312, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ACCEDER";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(763, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(19, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(735, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(33, 21);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 6;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.FromArgb(192, 255, 255);
            textUsuario.BorderStyle = BorderStyle.None;
            textUsuario.Location = new Point(380, 83);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(294, 20);
            textUsuario.TabIndex = 7;
            // 
            // textContrasena
            // 
            textContrasena.BackColor = Color.FromArgb(192, 255, 255);
            textContrasena.BorderStyle = BorderStyle.None;
            textContrasena.Location = new Point(433, 178);
            textContrasena.Name = "textContrasena";
            textContrasena.PasswordChar = '*';
            textContrasena.Size = new Size(241, 20);
            textContrasena.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(380, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 2);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(433, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 2);
            panel3.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(780, 330);
            Controls.Add(panel3);
            Controls.Add(panel2);
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
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
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
        private Panel panel2;
        private Panel panel3;
    }
}
