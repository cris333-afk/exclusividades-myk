namespace exclusividades_myk
{
    partial class Form3Productos
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
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            panelMenu = new Panel();
            pictureLogo = new PictureBox();
            panelTop = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvProductos = new DataGridView();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.ForeColor = Color.Black;
            txtId.Location = new Point(350, 320);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 34);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(620, 320);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 34);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(900, 320);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(250, 34);
            txtPrecio.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.White;
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 12F);
            txtStock.ForeColor = Color.Black;
            txtStock.Location = new Point(1180, 320);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(250, 34);
            txtStock.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(27, 185, 190);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(350, 420);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(180, 50);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 99, 99);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(560, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 50);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(27, 185, 190);
            panelMenu.Controls.Add(pictureLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 900);
            panelMenu.TabIndex = 7;
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
            panelTop.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(350, 100);
            label1.Name = "label1";
            label1.Size = new Size(565, 62);
            label1.TabIndex = 9;
            label1.Text = "GESTION DE PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(350, 160);
            label2.Name = "label2";
            label2.Size = new Size(452, 28);
            label2.TabIndex = 10;
            label2.Text = "Agrega, consulta o elimina productos del catalogo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(350, 289);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 11;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(620, 289);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 12;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(900, 289);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 13;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(1180, 289);
            label6.Name = "label6";
            label6.Size = new Size(61, 28);
            label6.TabIndex = 14;
            label6.Text = "Stock";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.GridColor = Color.Gray;
            dgvProductos.Location = new Point(350, 550);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1000, 300);
            dgvProductos.TabIndex = 15;
            // 
            // Form3Productos
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 900);
            Controls.Add(dgvProductos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3Productos";
            Load += Form3Productos_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnAgregar;
        private Button btnEliminar;
        private Panel panelMenu;
        private Panel panelTop;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvProductos;
        private PictureBox pictureLogo;
    }
}