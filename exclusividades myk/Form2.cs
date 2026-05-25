using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

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
            this.DoubleBuffered = true;
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

