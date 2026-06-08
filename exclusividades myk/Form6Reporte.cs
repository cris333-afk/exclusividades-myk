using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace exclusividades_myk
{
    public partial class Form6Reporte : Form
    {
        public Form6Reporte()
        {
            InitializeComponent();
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Archivo CSV|*.csv";
            sfd.FileName = "ReporteClientes.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw =
                    new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine(
                        "ID,Nombre,Telefono");

                    foreach (Cliente c in Sistema.Clientes)
                    {
                        sw.WriteLine(
                            $"{c.Id},{c.Nombre},{c.Telefono}");
                    }
                }

                MessageBox.Show(
                    "Reporte generado correctamente");
            }
        }

        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Archivo CSV|*.csv";
            sfd.FileName = "ReporteProductos.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw =
                    new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine(
                        "ID,Nombre,Precio,Stock");

                    foreach (Producto p in Sistema.Productos)
                    {
                        sw.WriteLine(
                            $"{p.Id},{p.Nombre},{p.Precio},{p.Stock}");
                    }
                }

                MessageBox.Show(
                    "Reporte generado correctamente");
            }
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Archivo CSV|*.csv";
            sfd.FileName = "ReporteVentas.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw =
                    new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine(
                        "ID,Cliente,Usuario,Total,Fecha");

                    foreach (Venta v in Sistema.Ventas)
                    {
                        string nombreCliente =
                            v.Cliente != null
                            ? v.Cliente.Nombre
                            : "Sin cliente";

                        sw.WriteLine(
                            $"{v.Id}," +
                            $"{nombreCliente}," +
                            $"{v.UsuarioVenta}," +
                            $"{v.Total}," +
                            $"{v.Fecha}");
                    }

                    sw.WriteLine("");

                    sw.WriteLine(
                        $"Cantidad de ventas,{Sistema.Ventas.Count}");

                    sw.WriteLine(
                        $"Monto total,{Sistema.Ventas.Sum(v => v.Total)}");
                }

                MessageBox.Show(
                    "Reporte generado correctamente");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (SolidBrush brush1 =
                new SolidBrush(Color.FromArgb(40, 255, 255, 255)))
            {
                g.FillEllipse(
                    brush1,
                    -80,
                    -50,
                    220,
                    220);
            }

            using (SolidBrush brush2 =
                new SolidBrush(Color.FromArgb(25, 255, 255, 255)))
            {
                g.FillEllipse(
                    brush2,
                    120,
                    200,
                    180,
                    180);
            }

            using (SolidBrush brush3 =
                new SolidBrush(Color.FromArgb(18, 255, 255, 255)))
            {
                g.FillEllipse(
                    brush3,
                    -50,
                    450,
                    250,
                    250);
            }
        }
    }
}
