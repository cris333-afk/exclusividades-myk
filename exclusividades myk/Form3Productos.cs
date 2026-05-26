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
        public Form3Productos()
        {
            InitializeComponent();
        }

        private void ActualizarLista()
        {
            lstProductos.Items.Clear();

            foreach (Producto p in Sistema.Productos)
            {
                lstProductos.Items.Add(
                    p.Id + " - " +
                    p.Nombre + " - ₡" +
                    p.Precio + " - Stock: " +
                    p.Stock);
            }
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

            ActualizarLista();

            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex >= 0)
            {
                Sistema.Productos.RemoveAt(
                    lstProductos.SelectedIndex);

                ActualizarLista();
            }
        }
    }
}
