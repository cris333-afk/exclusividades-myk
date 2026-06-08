using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exclusividades_myk
{
    public partial class Form7Usuarios : Form
    {
        public Form7Usuarios()
        {
            InitializeComponent();
            this.Load += Form7Usuarios_Load;
        }

        private void Form7Usuarios_Load(
     object sender,
     EventArgs e)
        {
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add(
                "Usuario",
                "Usuario");

            dgvUsuarios.Columns.Add(
                "Rol",
                "Rol");

            cmbRol.Items.Clear();

            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Vendedor");

            cmbRol.SelectedIndex = 0;

            MostrarUsuarios();


        }

        private void MostrarUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            foreach (Usuario u in Sistema.Usuarios)
            {
                dgvUsuarios.Rows.Add(
                    u.NombreUsuario,
                    u.Rol);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese usuario");
                return;
            }

            if (Sistema.Usuarios.Any(
    u => u.Contraseña == txtContraseña.Text))
            {
                MessageBox.Show(
                    "Esa contraseña no se puede utilizar");
                return;
            }

            Usuario nuevo =
                new Usuario(
                    txtUsuario.Text,
                    txtContraseña.Text,
                    cmbRol.Text);

            Sistema.Usuarios.Add(
                nuevo);

            MostrarUsuarios();

            MessageBox.Show(
                "Usuario registrado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un usuario");
                return;
            }

            string nombreUsuario =
                dgvUsuarios.SelectedRows[0]
                .Cells[0]
                .Value
                .ToString();

            Usuario usuario =
                Sistema.Usuarios
                .FirstOrDefault(
                    u => u.NombreUsuario ==
                         nombreUsuario);

            if (usuario != null)
            {
                if (usuario.NombreUsuario == "admin")
                {
                    MessageBox.Show(
                        "No se puede eliminar el administrador principal");
                    return;
                }

                Sistema.Usuarios.Remove(
                    usuario);

                MostrarUsuarios();

                MessageBox.Show(
                    "Usuario eliminado");
            }
        }
    }
}

