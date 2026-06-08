namespace exclusividades_myk
{
    partial class Form6Reporte
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
            btnReporteClientes = new Button();
            btnReporteProductos = new Button();
            btnReporteVentas = new Button();
            lblTitulo = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblIcono = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReporteClientes
            // 
            btnReporteClientes.BackColor = Color.DarkCyan;
            btnReporteClientes.Cursor = Cursors.Hand;
            btnReporteClientes.FlatStyle = FlatStyle.Flat;
            btnReporteClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteClientes.ForeColor = Color.White;
            btnReporteClientes.Location = new Point(200, 241);
            btnReporteClientes.Name = "btnReporteClientes";
            btnReporteClientes.Size = new Size(300, 60);
            btnReporteClientes.TabIndex = 0;
            btnReporteClientes.Text = "👥Reporte Clientes\r\n\r\n";
            btnReporteClientes.UseVisualStyleBackColor = false;
            btnReporteClientes.Click += btnReporteClientes_Click;
            // 
            // btnReporteProductos
            // 
            btnReporteProductos.BackColor = Color.DarkCyan;
            btnReporteProductos.Cursor = Cursors.Hand;
            btnReporteProductos.FlatStyle = FlatStyle.Flat;
            btnReporteProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteProductos.ForeColor = Color.White;
            btnReporteProductos.Location = new Point(200, 331);
            btnReporteProductos.Name = "btnReporteProductos";
            btnReporteProductos.Size = new Size(300, 60);
            btnReporteProductos.TabIndex = 1;
            btnReporteProductos.Text = "📦 Reporte Productos";
            btnReporteProductos.UseVisualStyleBackColor = false;
            btnReporteProductos.Click += btnReporteProductos_Click;
            // 
            // btnReporteVentas
            // 
            btnReporteVentas.BackColor = Color.DarkCyan;
            btnReporteVentas.Cursor = Cursors.Hand;
            btnReporteVentas.FlatStyle = FlatStyle.Flat;
            btnReporteVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteVentas.ForeColor = Color.White;
            btnReporteVentas.Location = new Point(200, 151);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.Size = new Size(300, 60);
            btnReporteVentas.TabIndex = 2;
            btnReporteVentas.Text = "📈 Reporte Ventas";
            btnReporteVentas.UseVisualStyleBackColor = false;
            btnReporteVentas.Click += btnReporteVentas_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(250, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(210, 50);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "REPORTES";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblIcono);
            panel1.Controls.Add(btnReporteClientes);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnReporteProductos);
            panel1.Controls.Add(btnReporteVentas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 553);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.logo_blanco_transparente;
            pictureBox1.Location = new Point(549, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 553);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font("Segoe UI Emoji", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIcono.ForeColor = Color.White;
            lblIcono.Location = new Point(157, 19);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(104, 72);
            lblIcono.TabIndex = 4;
            lblIcono.Text = "📊";
            // 
            // Form6Reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 185, 190);
            ClientSize = new Size(882, 553);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form6Reporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6Reporte";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReporteClientes;
        private Button btnReporteProductos;
        private Button btnReporteVentas;
        private Label lblTitulo;
        private Panel panel1;
        private Label lblIcono;
        private PictureBox pictureBox1;
    }
}