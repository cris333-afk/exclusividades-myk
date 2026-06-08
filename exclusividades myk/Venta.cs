using System;
using System.Collections.Generic;
using System.Text;

namespace exclusividades_myk
{

    public class Venta
    {
        public int Id { get; set; }

        public Cliente Cliente { get; set; }

        public List<DetalleVenta> Detalles { get; set; }

        public double Total { get; set; }

        public DateTime Fecha { get; set; }

        public string UsuarioVenta { get; set; }

        public Venta(
            int id,
            Cliente cliente,
            List<DetalleVenta> detalles,
            double total,
            DateTime fecha,
            string usuarioVenta)
        {
            {
                Id = id;
                Cliente = cliente;
                Detalles = detalles;
                Total = total;
                Fecha = fecha;
                UsuarioVenta = usuarioVenta;
            }
        }
    }
}


