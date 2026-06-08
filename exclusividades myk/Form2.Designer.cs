namespace exclusividades_myk
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            picLogo = new PictureBox();
            btnRegistrarU = new Button();
            btnSalir = new Button();
            btnReportes = new Button();
            btnClientes = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            panelContenido = new Panel();
            dgvVentasRecientes = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            lblVrecientes = new Label();
            panelClientes = new Panel();
            lblCantidadC = new Label();
            lblClientes = new Label();
            panelVentas = new Panel();
            lblCantidadV = new Label();
            lblVentas = new Label();
            panelProductos = new Panel();
            lblCantidadP = new Label();
            lblProductos = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasRecientes).BeginInit();
            panelClientes.SuspendLayout();
            panelVentas.SuspendLayout();
            panelProductos.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(27, 185, 190);
            panelMenu.Controls.Add(picLogo);
            panelMenu.Controls.Add(btnRegistrarU);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 450);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 0);
            picLogo.Margin = new Padding(3, 20, 3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 120);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // btnRegistrarU
            // 
            btnRegistrarU.BackColor = Color.White;
            btnRegistrarU.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarU.ForeColor = Color.FromArgb(80, 80, 80);
            btnRegistrarU.Location = new Point(28, 290);
            btnRegistrarU.Name = "btnRegistrarU";
            btnRegistrarU.Size = new Size(170, 45);
            btnRegistrarU.TabIndex = 2;
            btnRegistrarU.Text = "Registrar Usuario";
            btnRegistrarU.UseVisualStyleBackColor = false;
            btnRegistrarU.Click += btnRegistrarU_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.FromArgb(80, 80, 80);
            btnSalir.Location = new Point(64, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 38);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.White;
            btnReportes.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.FromArgb(80, 80, 80);
            btnReportes.Location = new Point(28, 346);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(170, 45);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.FromArgb(80, 80, 80);
            btnClientes.Location = new Point(28, 234);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(170, 45);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.White;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.FromArgb(80, 80, 80);
            btnVentas.Location = new Point(28, 178);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(170, 45);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.White;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.FromArgb(80, 80, 80);
            btnProductos.Location = new Point(28, 122);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(170, 45);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.White;
            panelContenido.BorderStyle = BorderStyle.FixedSingle;
            panelContenido.Controls.Add(dgvVentasRecientes);
            panelContenido.Controls.Add(lblVrecientes);
            panelContenido.Controls.Add(panelClientes);
            panelContenido.Controls.Add(panelVentas);
            panelContenido.Controls.Add(panelProductos);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Font = new Font("Segoe UI", 10F);
            panelContenido.Location = new Point(230, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(570, 450);
            panelContenido.TabIndex = 1;
            // 
            // dgvVentasRecientes
            // 
            dgvVentasRecientes.AllowUserToAddRows = false;
            dgvVentasRecientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasRecientes.BackgroundColor = Color.White;
            dgvVentasRecientes.BorderStyle = BorderStyle.None;
            dgvVentasRecientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentasRecientes.Columns.AddRange(new DataGridViewColumn[] { colID, colCliente, colProducto, colTotal, colFecha });
            dgvVentasRecientes.EnableHeadersVisualStyles = false;
            dgvVentasRecientes.GridColor = Color.LightGray;
            dgvVentasRecientes.Location = new Point(35, 277);
            dgvVentasRecientes.Name = "dgvVentasRecientes";
            dgvVentasRecientes.RowHeadersVisible = false;
            dgvVentasRecientes.RowHeadersWidth = 51;
            dgvVentasRecientes.Size = new Size(515, 160);
            dgvVentasRecientes.TabIndex = 5;
            // 
            // colID
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(27, 185, 190);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colID.DefaultCellStyle = dataGridViewCellStyle1;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colCliente
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 185, 190);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colCliente.DefaultCellStyle = dataGridViewCellStyle2;
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            // 
            // colProducto
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(27, 185, 190);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colProducto.DefaultCellStyle = dataGridViewCellStyle3;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            // 
            // colTotal
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(27, 185, 190);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(27, 185, 190);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colFecha.DefaultCellStyle = dataGridViewCellStyle5;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // lblVrecientes
            // 
            lblVrecientes.AutoSize = true;
            lblVrecientes.BackColor = Color.Transparent;
            lblVrecientes.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVrecientes.ForeColor = Color.FromArgb(90, 90, 90);
            lblVrecientes.Location = new Point(166, 216);
            lblVrecientes.Name = "lblVrecientes";
            lblVrecientes.Size = new Size(264, 38);
            lblVrecientes.TabIndex = 4;
            lblVrecientes.Text = "VENTAS RECIENTES";
            // 
            // panelClientes
            // 
            panelClientes.BackColor = Color.White;
            panelClientes.Controls.Add(lblCantidadC);
            panelClientes.Controls.Add(lblClientes);
            panelClientes.Location = new Point(397, 92);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(170, 110);
            panelClientes.TabIndex = 3;
            // 
            // lblCantidadC
            // 
            lblCantidadC.AutoSize = true;
            lblCantidadC.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadC.ForeColor = Color.FromArgb(27, 185, 190);
            lblCantidadC.Location = new Point(68, 44);
            lblCantidadC.Name = "lblCantidadC";
            lblCantidadC.Size = new Size(46, 54);
            lblCantidadC.TabIndex = 1;
            lblCantidadC.Text = "0";
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientes.ForeColor = Color.FromArgb(70, 70, 70);
            lblClientes.Location = new Point(40, 13);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(84, 28);
            lblClientes.TabIndex = 0;
            lblClientes.Text = "Clientes";
            // 
            // panelVentas
            // 
            panelVentas.BackColor = Color.White;
            panelVentas.Controls.Add(lblCantidadV);
            panelVentas.Controls.Add(lblVentas);
            panelVentas.Location = new Point(206, 92);
            panelVentas.Name = "panelVentas";
            panelVentas.Size = new Size(170, 110);
            panelVentas.TabIndex = 2;
            // 
            // lblCantidadV
            // 
            lblCantidadV.AutoSize = true;
            lblCantidadV.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadV.ForeColor = Color.FromArgb(27, 185, 190);
            lblCantidadV.Location = new Point(8, 54);
            lblCantidadV.Name = "lblCantidadV";
            lblCantidadV.Size = new Size(35, 41);
            lblCantidadV.TabIndex = 1;
            lblCantidadV.Text = "0";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = Color.FromArgb(70, 70, 70);
            lblVentas.Location = new Point(8, 13);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(159, 28);
            lblVentas.TabIndex = 0;
            lblVentas.Text = "Ingresos Totales";
            // 
            // panelProductos
            // 
            panelProductos.BackColor = Color.White;
            panelProductos.Controls.Add(lblCantidadP);
            panelProductos.Controls.Add(lblProductos);
            panelProductos.Location = new Point(15, 92);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(170, 110);
            panelProductos.TabIndex = 1;
            // 
            // lblCantidadP
            // 
            lblCantidadP.AutoSize = true;
            lblCantidadP.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadP.ForeColor = Color.FromArgb(27, 185, 190);
            lblCantidadP.Location = new Point(62, 44);
            lblCantidadP.Name = "lblCantidadP";
            lblCantidadP.Size = new Size(46, 54);
            lblCantidadP.TabIndex = 1;
            lblCantidadP.Text = "0";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductos.ForeColor = Color.FromArgb(70, 70, 70);
            lblProductos.Location = new Point(30, 13);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(104, 28);
            lblProductos.TabIndex = 0;
            lblProductos.Text = "Productos";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasRecientes).EndInit();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            panelVentas.ResumeLayout(false);
            panelVentas.PerformLayout();
            panelProductos.ResumeLayout(false);
            panelProductos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContenido;
        private Button btnReportes;
        private Button btnClientes;
        private Button btnRegistrarU;
        private Button btnVentas;
        private Button btnProductos;
        private Button btnSalir;
        private PictureBox picLogo;
        private Panel panelProductos;
        private Label lblCantidadP;
        private Label lblProductos;
        private Panel panelVentas;
        private Label lblCantidadV;
        private Label lblVentas;
        private Panel panelClientes;
        private Label lblCantidadC;
        private Label lblClientes;
        private Label lblVrecientes;
        private DataGridView dgvVentasRecientes;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colFecha;
        private Button button2;
    }
}