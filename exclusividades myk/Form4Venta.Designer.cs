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
            cmbCliente = new ComboBox();
            cmbProducto = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnVender = new Button();
            dgvVenta = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtIdVenta = new TextBox();
            label3 = new Label();
            lblTotalTitulo = new Label();
            lblTotal = new Label();
            panelventa = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            panelventa.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCliente.BackColor = Color.White;
            cmbCliente.Font = new Font("Segoe UI", 11F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(30, 160);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(280, 33);
            cmbCliente.TabIndex = 0;
            // 
            // cmbProducto
            // 
            cmbProducto.BackColor = Color.White;
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Font = new Font("Segoe UI", 11F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(30, 270);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(280, 33);
            cmbProducto.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.BackColor = Color.White;
            nudCantidad.Font = new Font("Segoe UI", 11F);
            nudCantidad.Location = new Point(30, 370);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 32);
            nudCantidad.TabIndex = 2;
            nudCantidad.TextAlign = HorizontalAlignment.Center;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(30, 450);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(280, 55);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Carrito";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(667, 531);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(280, 55);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar Item";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(27, 185, 190);
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(700, 760);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(240, 70);
            btnVender.TabIndex = 5;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // dgvVenta
            // 
            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenta.BackgroundColor = Color.White;
            dgvVenta.BorderStyle = BorderStyle.None;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.EnableHeadersVisualStyles = false;
            dgvVenta.Location = new Point(378, 0);
            dgvVenta.MultiSelect = false;
            dgvVenta.Name = "dgvVenta";
            dgvVenta.ReadOnly = true;
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVenta.Size = new Size(569, 505);
            dgvVenta.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 7;
            label1.Text = "ID Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 130);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 8;
            label2.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 340);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 9;
            label4.Text = "Cantidad";
            // 
            // txtIdVenta
            // 
            txtIdVenta.BackColor = Color.Gainsboro;
            txtIdVenta.BorderStyle = BorderStyle.FixedSingle;
            txtIdVenta.Enabled = false;
            txtIdVenta.Font = new Font("Segoe UI", 11F);
            txtIdVenta.Location = new Point(30, 60);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.ReadOnly = true;
            txtIdVenta.Size = new Size(280, 32);
            txtIdVenta.TabIndex = 10;
            txtIdVenta.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 240);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 11;
            label3.Text = "Producto";
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTitulo.Location = new Point(650, 630);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(67, 31);
            lblTotalTitulo.TabIndex = 12;
            lblTotalTitulo.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(650, 661);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 41);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "$0";
            // 
            // panelventa
            // 
            panelventa.BackColor = Color.FromArgb(27, 185, 190);
            panelventa.Controls.Add(label1);
            panelventa.Controls.Add(txtIdVenta);
            panelventa.Controls.Add(label2);
            panelventa.Controls.Add(label4);
            panelventa.Controls.Add(label3);
            panelventa.Controls.Add(cmbCliente);
            panelventa.Controls.Add(btnAgregar);
            panelventa.Controls.Add(cmbProducto);
            panelventa.Controls.Add(nudCantidad);
            panelventa.Location = new Point(-4, 0);
            panelventa.Name = "panelventa";
            panelventa.Size = new Size(376, 919);
            panelventa.TabIndex = 14;
            panelventa.Paint += panelventa_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 185, 190);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1105, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 900);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.logo_blanco_transparente;
            pictureBox1.Location = new Point(41, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 900);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form4Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 900);
            Controls.Add(panel1);
            Controls.Add(panelventa);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalTitulo);
            Controls.Add(dgvVenta);
            Controls.Add(btnVender);
            Controls.Add(btnEliminar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form4Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4Venta";
            Load += Form4Venta_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            panelventa.ResumeLayout(false);
            panelventa.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCliente;
        private ComboBox cmbProducto;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnVender;
        private DataGridView dgvVenta;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtIdVenta;
        private Label label3;
        private Label lblTotalTitulo;
        private Label lblTotal;
        private Panel panelventa;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}