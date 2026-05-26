namespace exclusividades_myk
{
    partial class Form4Venta
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
            pictureLogo = new PictureBox();
            panelTop = new Panel();
            labelTitulo = new Label();
            label2 = new Label();
            lblF = new Label();
            lblT = new Label();
            lblCliente = new Label();
            lblIdVneta = new Label();
            btnEliminar = new Button();
            btnVender = new Button();
            txtCliente = new TextBox();
            txtId = new TextBox();
            lblProducto = new Label();
            cmbProductos = new ComboBox();
            lblTotal = new Label();
            lblFecha = new Label();
            btbLimpiar = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(27, 185, 190);
            panelMenu.Controls.Add(pictureLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 900);
            panelMenu.TabIndex = 8;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Transparent;
            pictureLogo.Image = Properties.Resources.logo_blanco_transparente;
            pictureLogo.Location = new Point(55, 300);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(200, 200);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(27, 185, 190);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(300, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1100, 50);
            panelTop.TabIndex = 9;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.DimGray;
            labelTitulo.Location = new Point(338, 84);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(464, 62);
            labelTitulo.TabIndex = 10;
            labelTitulo.Text = "GESTION DE VENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(350, 146);
            label2.Name = "label2";
            label2.Size = new Size(309, 28);
            label2.TabIndex = 11;
            label2.Text = "Agrega, consulta o elimina ventas ";
            // 
            // lblF
            // 
            lblF.AutoSize = true;
            lblF.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblF.ForeColor = Color.DimGray;
            lblF.Location = new Point(506, 343);
            lblF.Name = "lblF";
            lblF.Size = new Size(69, 28);
            lblF.TabIndex = 24;
            lblF.Text = "Fecha:";
            // 
            // lblT
            // 
            lblT.AutoSize = true;
            lblT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblT.ForeColor = Color.DimGray;
            lblT.Location = new Point(315, 343);
            lblT.Name = "lblT";
            lblT.Size = new Size(60, 28);
            lblT.TabIndex = 23;
            lblT.Text = "Total:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.DimGray;
            lblCliente.Location = new Point(683, 202);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(75, 28);
            lblCliente.TabIndex = 22;
            lblCliente.Text = "Cliente";
            // 
            // lblIdVneta
            // 
            lblIdVneta.AutoSize = true;
            lblIdVneta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdVneta.ForeColor = Color.DimGray;
            lblIdVneta.Location = new Point(315, 202);
            lblIdVneta.Name = "lblIdVneta";
            lblIdVneta.Size = new Size(32, 28);
            lblIdVneta.TabIndex = 21;
            lblIdVneta.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 99, 99);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1154, 429);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 50);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(27, 185, 190);
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(899, 429);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(180, 50);
            btnVender.TabIndex = 19;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.White;
            txtCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCliente.Font = new Font("Segoe UI", 12F);
            txtCliente.ForeColor = Color.Black;
            txtCliente.Location = new Point(683, 237);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(250, 34);
            txtCliente.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.ForeColor = Color.Black;
            txtId.Location = new Point(315, 237);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 34);
            txtId.TabIndex = 15;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.ForeColor = Color.DimGray;
            lblProducto.Location = new Point(1039, 202);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(95, 28);
            lblProducto.TabIndex = 26;
            lblProducto.Text = "Producto";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(1039, 237);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(211, 28);
            cmbProductos.TabIndex = 27;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.DimGray;
            lblTotal.Location = new Point(381, 343);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 28);
            lblTotal.TabIndex = 28;
            lblTotal.Text = " ₡ 0";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.DimGray;
            lblFecha.Location = new Point(581, 343);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 28);
            lblFecha.TabIndex = 29;
            // 
            // btbLimpiar
            // 
            btbLimpiar.BackColor = Color.Gray;
            btbLimpiar.Cursor = Cursors.Hand;
            btbLimpiar.FlatStyle = FlatStyle.Flat;
            btbLimpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbLimpiar.ForeColor = Color.White;
            btbLimpiar.Location = new Point(319, 445);
            btbLimpiar.Name = "btbLimpiar";
            btbLimpiar.Size = new Size(108, 34);
            btbLimpiar.TabIndex = 30;
            btbLimpiar.Text = "Limpiar";
            btbLimpiar.UseVisualStyleBackColor = false;
            // 
            // Form4Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 900);
            Controls.Add(btbLimpiar);
            Controls.Add(lblFecha);
            Controls.Add(lblTotal);
            Controls.Add(cmbProductos);
            Controls.Add(lblProducto);
            Controls.Add(lblF);
            Controls.Add(lblT);
            Controls.Add(lblCliente);
            Controls.Add(lblIdVneta);
            Controls.Add(btnEliminar);
            Controls.Add(btnVender);
            Controls.Add(txtCliente);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(labelTitulo);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Name = "Form4Venta";
            Text = "Form4Venta";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private PictureBox pictureLogo;
        private Panel panelTop;
        private Label labelTitulo;
        private Label label2;
        private Label lblF;
        private Label lblT;
        private Label lblCliente;
        private Label lblIdVneta;
        private Button btnEliminar;
        private Button btnVender;
        private TextBox txtCliente;
        private TextBox txtId;
        private Label lblProducto;
        private ComboBox cmbProductos;
        private Label lblTotal;
        private Label lblFecha;
        private Button btbLimpiar;
    }
}