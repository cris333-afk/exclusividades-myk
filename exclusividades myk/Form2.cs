using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace exclusividades_myk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            EstiloBoton(btnClientes);
            EstiloBoton(btnProductos);
            EstiloBoton(btnVentas);
            EstiloBoton(btnReportes);
            EstiloBoton(btnInventario);
            EstiloBoton(btnSalir);
        }

        private void EstiloBoton(Button btn)
        {

            btn.UseVisualStyleBackColor = false;

            btn.FlatStyle = FlatStyle.Flat;

            btn.FlatAppearance.BorderSize = 0;

            btn.BackColor = Color.FromArgb(245, 245, 245);

            

            btn.Font = new Font("Segoe UI Semibold", 10);

            btn.Height = 42;
            btn.Width = 165;

            btn.Cursor = Cursors.Hand;

            btn.TextAlign = ContentAlignment.MiddleLeft;

            btn.Padding = new Padding(12, 0, 0, 0);

            btn.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(220, 255, 250);

            btn.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(200, 245, 245);
        }
    }
}
