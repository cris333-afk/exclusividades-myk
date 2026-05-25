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
            panelMenu = new Panel();
            picLogo = new PictureBox();
            btnInventario = new Button();
            btnSalir = new Button();
            btnReportes = new Button();
            btnClientes = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            panelContenido = new Panel();
            panelClientes = new Panel();
            lblCantidadC = new Label();
            lblClientes = new Label();
            panelVentas = new Panel();
            lblCantidadV = new Label();
            lblVentas = new Label();
            panelProductos = new Panel();
            lblCantidadP = new Label();
            lblProductos = new Label();
            panelTop = new Panel();
            lblVrecientes = new Label();
            dgvVentas = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelContenido.SuspendLayout();
            panelClientes.SuspendLayout();
            panelVentas.SuspendLayout();
            panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(192, 255, 255);
            panelMenu.Controls.Add(picLogo);
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(192, 255, 255);
            picLogo.Image = Properties.Resources.logomk;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(88, 68);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // btnInventario
            // 
            btnInventario.ForeColor = SystemColors.ControlDarkDark;
            btnInventario.Location = new Point(26, 260);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(170, 50);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.ForeColor = SystemColors.ControlDarkDark;
            btnSalir.Location = new Point(59, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.ForeColor = SystemColors.ControlDarkDark;
            btnReportes.Location = new Point(26, 316);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(170, 50);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.ForeColor = SystemColors.ControlDarkDark;
            btnClientes.Location = new Point(26, 204);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(170, 50);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.ForeColor = SystemColors.ControlDarkDark;
            btnVentas.Location = new Point(26, 148);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(170, 50);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.ForeColor = SystemColors.ControlDarkDark;
            btnProductos.Location = new Point(26, 92);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(170, 50);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(dgvVentas);
            panelContenido.Controls.Add(lblVrecientes);
            panelContenido.Controls.Add(panelClientes);
            panelContenido.Controls.Add(panelVentas);
            panelContenido.Controls.Add(panelProductos);
            panelContenido.Controls.Add(panelTop);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(220, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(580, 450);
            panelContenido.TabIndex = 1;
            // 
            // panelClientes
            // 
            panelClientes.BackColor = Color.FromArgb(224, 224, 224);
            panelClientes.BorderStyle = BorderStyle.FixedSingle;
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
            lblCantidadC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadC.ForeColor = Color.FromArgb(64, 64, 64);
            lblCantidadC.Location = new Point(77, 58);
            lblCantidadC.Name = "lblCantidadC";
            lblCantidadC.Size = new Size(26, 31);
            lblCantidadC.TabIndex = 1;
            lblCantidadC.Text = "0";
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.ForeColor = Color.FromArgb(64, 64, 64);
            lblClientes.Location = new Point(59, 13);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(72, 20);
            lblClientes.TabIndex = 0;
            lblClientes.Text = "CLIENTES";
            // 
            // panelVentas
            // 
            panelVentas.BackColor = Color.FromArgb(224, 224, 224);
            panelVentas.BorderStyle = BorderStyle.FixedSingle;
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
            lblCantidadV.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadV.ForeColor = Color.FromArgb(64, 64, 64);
            lblCantidadV.Location = new Point(73, 58);
            lblCantidadV.Name = "lblCantidadV";
            lblCantidadV.Size = new Size(26, 31);
            lblCantidadV.TabIndex = 1;
            lblCantidadV.Text = "0";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.ForeColor = Color.FromArgb(64, 64, 64);
            lblVentas.Location = new Point(57, 13);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(62, 20);
            lblVentas.TabIndex = 0;
            lblVentas.Text = "VENTAS";
            // 
            // panelProductos
            // 
            panelProductos.BackColor = Color.FromArgb(224, 224, 224);
            panelProductos.BorderStyle = BorderStyle.FixedSingle;
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
            lblCantidadP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadP.ForeColor = Color.FromArgb(64, 64, 64);
            lblCantidadP.Location = new Point(79, 58);
            lblCantidadP.Name = "lblCantidadP";
            lblCantidadP.Size = new Size(26, 31);
            lblCantidadP.TabIndex = 1;
            lblCantidadP.Text = "0";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.ForeColor = Color.FromArgb(64, 64, 64);
            lblProductos.Location = new Point(45, 13);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(93, 20);
            lblProductos.TabIndex = 0;
            lblProductos.Text = "PRODUCTOS";
            // 
            // panelTop
            // 
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(580, 42);
            panelTop.TabIndex = 0;
            // 
            // lblVrecientes
            // 
            lblVrecientes.AutoSize = true;
            lblVrecientes.BackColor = SystemColors.ButtonHighlight;
            lblVrecientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVrecientes.ForeColor = SystemColors.ControlDarkDark;
            lblVrecientes.Location = new Point(194, 226);
            lblVrecientes.Name = "lblVrecientes";
            lblVrecientes.Size = new Size(182, 28);
            lblVrecientes.TabIndex = 4;
            lblVrecientes.Text = "VENTAS RECIENTES";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.Silver;
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colID, colCliente, colProducto, colTotal, colFecha });
            dgvVentas.Location = new Point(35, 260);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(515, 160);
            dgvVentas.TabIndex = 5;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            Name = "Form2";
            Text = "Form2";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            panelVentas.ResumeLayout(false);
            panelVentas.PerformLayout();
            panelProductos.ResumeLayout(false);
            panelProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContenido;
        private Panel panelTop;
        private Button btnReportes;
        private Button btnClientes;
        private Button btnInventario;
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
        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colFecha;
    }
}