using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exclusividades_myk
{
    public partial class Form4Venta : Form
    {

        private List<DetalleVenta> carrito =
    new List<DetalleVenta>();

        private Form2 menu;
        public Form4Venta(Form2 menuPrincipal)
        {
            InitializeComponent();
            menu = menuPrincipal;
        }

        private void Form4Venta_Load(object sender, EventArgs e)
        {
            txtIdVenta.Text =
        (Sistema.Ventas.Count + 1).ToString();

            CargarClientes();
            CargarProductos();
            ConfigurarDGV();

            lblTotal.Text = "₡0";
        }

        private void ConfigurarDGV()
        {
            dgvVenta.Columns.Clear();

            dgvVenta.Columns.Add(
                "Producto",
                "Producto");

            dgvVenta.Columns.Add(
                "Cantidad",
                "Cantidad");

            dgvVenta.Columns.Add(
                "Precio",
                "Precio");

            dgvVenta.Columns.Add(
                "Subtotal",
                "Subtotal");
        }
        private void CargarClientes()
        {
            cmbCliente.Items.Clear();

            cmbCliente.Items.Add("Sin cliente");

            foreach (Cliente c in Sistema.Clientes)
            {
                cmbCliente.Items.Add(
                    c.Id + " - " + c.Nombre);
            }

            cmbCliente.SelectedIndex = 0;
        }

        private void CargarProductos()
        {
            cmbProducto.Items.Clear();

            foreach (Producto p in Sistema.Productos)
            {
                cmbProducto.Items.Add(
                    p.Id + " - " +
                    p.Nombre +
                    " | Stock: " +
                    p.Stock);
            }

            if (cmbProducto.Items.Count > 0)
            {
                cmbProducto.SelectedIndex = 0;
            }
        }
        private void ActualizarTotal()
        {
            double total = 0;

            foreach (DetalleVenta d in carrito)
            {
                total += d.Subtotal;
            }

            lblTotal.Text =
                "₡" + total.ToString("N2");
        }

        private void LimpiarVenta()
        {
            carrito.Clear();

            dgvVenta.Rows.Clear();

            lblTotal.Text = "₡0";

            nudCantidad.Value = 1;

            txtIdVenta.Text =
                (Sistema.Ventas.Count + 1)
                .ToString();

            CargarProductos();

            cmbCliente.SelectedIndex = 0;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un producto");
                return;
            }

            string texto =
                cmbProducto.SelectedItem
                .ToString();

            int id =
                Convert.ToInt32(
                    texto.Split('-')[0]
                    .Trim());

            Producto p =
                Sistema.Productos
                .FirstOrDefault(
                    x => x.Id == id);

            if (p == null)
            {
                return;
            }

            int cantidad =
                Convert.ToInt32(
                    nudCantidad.Value);

            if (cantidad > p.Stock)
            {
                MessageBox.Show(
                    "Stock insuficiente");
                return;
            }

            DetalleVenta existente =
                carrito.FirstOrDefault(
                    d => d.Producto.Id == p.Id);

            if (existente != null)
            {
                if (existente.Cantidad +
                    cantidad > p.Stock)
                {
                    MessageBox.Show(
                        "Stock insuficiente");
                    return;
                }

                existente.Cantidad +=
                    cantidad;
            }
            else
            {
                carrito.Add(
                    new DetalleVenta(
                        p,
                        cantidad));
            }

            dgvVenta.Rows.Clear();

            foreach (DetalleVenta d in carrito)
            {
                dgvVenta.Rows.Add(
                    d.Producto.Nombre,
                    d.Cantidad,
                    d.Producto.Precio,
                    d.Subtotal);
            }

            ActualizarTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count == 0)
            {
                return;
            }

            int fila =
                dgvVenta.SelectedRows[0].Index;

            carrito.RemoveAt(fila);

            dgvVenta.Rows.RemoveAt(fila);

            ActualizarTotal();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show(
                    "No hay productos en la venta");
                return;
            }

            Cliente clienteVenta = null;

            if (cmbCliente.SelectedIndex > 0)
            {
                string textoCliente =
                    cmbCliente.SelectedItem
                    .ToString();

                int idCliente =
                    Convert.ToInt32(
                        textoCliente
                        .Split('-')[0]
                        .Trim());

                clienteVenta =
                    Sistema.Clientes
                    .FirstOrDefault(
                        c => c.Id == idCliente);
            }

            foreach (DetalleVenta d in carrito)
            {
                if (d.Cantidad >
                    d.Producto.Stock)
                {
                    MessageBox.Show(
                        "Stock insuficiente para " +
                        d.Producto.Nombre);
                    return;
                }
            }

            foreach (DetalleVenta d in carrito)
            {
                d.Producto.Stock -=
                    d.Cantidad;
            }

            double total =
                carrito.Sum(
                    d => d.Subtotal);

            Venta nuevaVenta =
                new Venta(
                    Sistema.Ventas.Count + 1,
                    clienteVenta,
                    new List<DetalleVenta>(
                        carrito),
                    total,
                    DateTime.Now);

            Sistema.Ventas.Add(
    nuevaVenta);

            menu.ActualizarContadorVentas();
            menu.MostrarVentasRecientes();
            CargarProductos();

            MessageBox.Show(
                "Venta realizada");

            LimpiarVenta();
        }

        private void panelventa_Paint(object sender, PaintEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
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
