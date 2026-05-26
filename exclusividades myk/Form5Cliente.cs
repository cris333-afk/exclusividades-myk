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
           menu=frm;
            
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
            Cliente nuevo = new Cliente(
        int.Parse(txtIdCliente.Text),
        txtNombreCliente.Text,
        txtTelefono.Text);

            Sistema.Clientes.Add(nuevo);
            menu.ActualizarContadorClientes();
            ActualizarListaClientes();

            txtIdCliente.Clear();
            txtNombreCliente.Clear();
            txtTelefono.Clear();
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
    }
}
