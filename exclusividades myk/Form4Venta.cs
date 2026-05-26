using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exclusividades_myk
{
    public partial class Form4Venta : Form
    {
        Form2 menu;
        public Form4Venta(Form2 frm)
        {
            InitializeComponent();
            menu = frm;
            CargarProductos();

            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void CargarProductos()
        {
            cmbProductos.Items.Clear();

            foreach (Producto p in Sistema.Productos)
            {
                cmbProductos.Items.Add(p.Nombre);
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAR CAMPOS VACIOS
                if (txtId.Text == "" ||
                    txtCliente.Text == "" ||
                    cmbProductos.Text == "")
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }

                // VALIDAR ID NUMERICO
                int idVenta;

                if (!int.TryParse(txtId.Text, out idVenta))
                {
                    MessageBox.Show("El ID debe ser numérico");
                    return;
                }

                // BUSCAR PRODUCTO
                Producto productoSeleccionado = null;

                foreach (Producto p in Sistema.Productos)
                {
                    if (p.Nombre == cmbProductos.Text)
                    {
                        productoSeleccionado = p;
                        break;
                    }
                }

                // VALIDAR STOCK
                if (productoSeleccionado.Stock <= 0)
                {
                    MessageBox.Show("No hay stock disponible");
                    return;
                }

                // RESTAR STOCK
                productoSeleccionado.Stock--;

                // OBTENER TOTAL
                double total = productoSeleccionado.Precio;

                // MOSTRAR TOTAL
                lblTotal.Text = "₡" + total.ToString();

                // CREAR VENTA
                Venta nuevaVenta = new Venta(
                    idVenta,
                    txtCliente.Text,
                    productoSeleccionado.Nombre,
                    total,
                    DateTime.Now
                );

                // GUARDAR EN LISTA
                Sistema.Ventas.Add(nuevaVenta);
                menu.MostrarVentas();
                menu.ActualizarContadorVentas();

                menu.ActualizarContadorProductos();

                menu.ActualizarContadorClientes();

                MessageBox.Show("Venta realizada correctamente");

                // LIMPIAR CONTROLES
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LimpiarControles()
        {
            txtId.Clear();

            txtCliente.Clear();

            cmbProductos.SelectedIndex = -1;

            lblTotal.Text = "₡0";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAR ID
                int idVenta;

                if (!int.TryParse(txtId.Text, out idVenta))
                {
                    MessageBox.Show("Ingrese un ID válido");
                    return;
                }

                // BUSCAR VENTA
                Venta ventaEliminar = null;

                foreach (Venta v in Sistema.Ventas)
                {
                    if (v.Id == idVenta)
                    {
                        ventaEliminar = v;
                        break;
                    }
                }

                // VALIDAR SI EXISTE
                if (ventaEliminar == null)
                {
                    MessageBox.Show("No se encontró la venta");
                    return;
                }

                // DEVOLVER STOCK
                foreach (Producto p in Sistema.Productos)
                {
                    if (p.Nombre == ventaEliminar.Producto)
                    {
                        p.Stock++;
                        break;
                    }
                }

                // ELIMINAR VENTA
                Sistema.Ventas.Remove(ventaEliminar);

                // ACTUALIZAR DATAGRIDVIEW
                menu.MostrarVentas();

                MessageBox.Show("Venta eliminada correctamente");

                // LIMPIAR CONTROLES
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
