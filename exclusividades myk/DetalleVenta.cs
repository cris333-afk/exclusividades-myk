using System;
using System.Collections.Generic;
using System.Text;

namespace exclusividades_myk
{
    public class DetalleVenta
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public double Subtotal
        {
            get
            {
                return Producto.Precio * Cantidad;
            }
        }

        public DetalleVenta(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
    }
}
