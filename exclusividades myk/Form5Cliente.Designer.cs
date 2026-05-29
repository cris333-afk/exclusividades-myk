namespace exclusividades_myk
{
    partial class Form5Cliente
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
            txtIdCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtTelefono = new TextBox();
            btnAgregarCliente = new Button();
            btnEliminarCliente = new Button();
            dgvClientes = new DataGridView();
            panelCliente = new Panel();
            pictureBox1 = new PictureBox();
            panelTop = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 12F);
            txtIdCliente.Location = new Point(380, 375);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(250, 34);
            txtIdCliente.TabIndex = 0;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Segoe UI", 12F);
            txtNombreCliente.Location = new Point(670, 375);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(350, 34);
            txtNombreCliente.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(1060, 375);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 34);
            txtTelefono.TabIndex = 2;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(27, 185, 190);
            btnAgregarCliente.Cursor = Cursors.Hand;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(380, 500);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(210, 60);
            btnAgregarCliente.TabIndex = 3;
            btnAgregarCliente.Text = "Registrar";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.FromArgb(250, 95, 95);
            btnEliminarCliente.Cursor = Cursors.Hand;
            btnEliminarCliente.FlatStyle = FlatStyle.Flat;
            btnEliminarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarCliente.ForeColor = Color.White;
            btnEliminarCliente.Location = new Point(640, 500);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(210, 60);
            btnEliminarCliente.TabIndex = 4;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(380, 620);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(930, 620);
            dgvClientes.TabIndex = 5;
            // 
            // panelCliente
            // 
            panelCliente.BackColor = Color.FromArgb(27, 185, 190);
            panelCliente.Controls.Add(pictureBox1);
            panelCliente.Dock = DockStyle.Left;
            panelCliente.Location = new Point(0, 0);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(320, 900);
            panelCliente.TabIndex = 6;
            panelCliente.Paint += panelCliente_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_blanco_transparente;
            pictureBox1.Location = new Point(55, 470);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(27, 185, 190);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(320, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1080, 50);
            panelTop.TabIndex = 9;
            panelTop.Paint += panelTop_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(380, 120);
            label1.Name = "label1";
            label1.Size = new Size(496, 62);
            label1.TabIndex = 10;
            label1.Text = "GESTION DE CLIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(385, 185);
            label2.Name = "label2";
            label2.Size = new Size(416, 28);
            label2.TabIndex = 11;
            label2.Text = "Agrega, consulta o elimina clientes registrados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(380, 330);
            label3.Name = "label3";
            label3.Size = new Size(38, 32);
            label3.TabIndex = 12;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(670, 330);
            label4.Name = "label4";
            label4.Size = new Size(103, 32);
            label4.TabIndex = 13;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(1060, 330);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 14;
            label5.Text = "Telefono";
            // 
            // Form5Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 900);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelTop);
            Controls.Add(panelCliente);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtIdCliente);
            Name = "Form5Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5Cliente";
            Load += Form5Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panelCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCliente;
        private TextBox txtNombreCliente;
        private TextBox txtTelefono;
        private Button btnAgregarCliente;
        private Button btnEliminarCliente;
        private DataGridView dgvClientes;
        private Panel panelCliente;
        private PictureBox pictureBox1;
        private Panel panelTop;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}