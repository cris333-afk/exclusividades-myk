using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exclusividades_myk
{
    public partial class Form3Productos : Form
    {
        Form2 menu;
        public Form3Productos(Form2 frm)
        {
            InitializeComponent();
            menu = frm;
        }

        private void ActualizarLista()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Sistema.Productos;
        }

        private void Form3Productos_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto(
           int.Parse(txtId.Text),
           txtNombre.Text,
           double.Parse(txtPrecio.Text),
           int.Parse(txtStock.Text));

            Sistema.Productos.Add(nuevo);
            menu.ActualizarContadorProductos();

            ActualizarLista();

            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int fila = dgvProductos.SelectedRows[0].Index;
                Sistema.Productos.RemoveAt(fila);
                menu.ActualizarContadorProductos();
                ActualizarLista();
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Círculo grande superior
            using (SolidBrush brush1 = new SolidBrush(Color.FromArgb(40, 255, 255, 255)))
            {
                g.FillEllipse(brush1, -80, -50, 220, 220);
            }

            // Círculo medio
            using (SolidBrush brush2 = new SolidBrush(Color.FromArgb(25, 255, 255, 255)))
            {
                g.FillEllipse(brush2, 120, 200, 180, 180);
            }

            // Círculo inferior
            using (SolidBrush brush3 = new SolidBrush(Color.FromArgb(18, 255, 255, 255)))
            {
                g.FillEllipse(brush3, -50, 450, 250, 250);
            }
        }
    }
}
