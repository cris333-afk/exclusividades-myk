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
    public partial class Form5Cliente : Form
    {
        Form2 menu;
        public Form5Cliente(Form2 frm)
        {
            InitializeComponent();
            menu = frm;

        }
        private void ActualizarListaClientes()
        {
            dgvClientes.Rows.Clear();

            foreach (Cliente c in Sistema.Clientes)
            {
                dgvClientes.Rows.Add(
                    c.Id,
                    c.Nombre,
                    c.Telefono);
            }
        }

        private void Form5Cliente_Load(object sender, EventArgs e)
        {
            dgvClientes.Columns.Add("Id", "ID");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Telefono", "Teléfono");
            ActualizarListaClientes();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Trim() == "" ||
         txtNombreCliente.Text.Trim() == "" ||
         txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Debe completar todos los campos");

                return;
            }

            int id;

            if (!int.TryParse(txtIdCliente.Text, out id))
            {
                MessageBox.Show(
                    "El ID debe ser numérico");

                return;
            }

            if (!long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show(
                    "El teléfono debe ser numérico");

                return;
            }

            if (txtNombreCliente.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "El nombre no puede contener números");

                return;
            }

            if (Sistema.Clientes.Any(c => c.Id == id))
            {
                MessageBox.Show(
                    "Ya existe un cliente con ese ID");

                return;
            }

            Cliente nuevo = new Cliente(
                id,
                txtNombreCliente.Text,
                txtTelefono.Text);

            Sistema.Clientes.Add(nuevo);

            menu.ActualizarContadorClientes();

            ActualizarListaClientes();

            txtIdCliente.Clear();
            txtNombreCliente.Clear();
            txtTelefono.Clear();

            MessageBox.Show(
                "Cliente agregado correctamente");
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int fila =
                    dgvClientes.SelectedRows[0].Index;

                Sistema.Clientes.RemoveAt(fila);
                menu.ActualizarContadorClientes();
                ActualizarListaClientes();
            }
        }



        private void panelTop_Paint(object sender, PaintEventArgs e)
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

        private void panelCliente_Paint(object sender, PaintEventArgs e)
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
