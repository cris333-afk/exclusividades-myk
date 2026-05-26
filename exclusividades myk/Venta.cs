using System;
using System.Collections.Generic;
using System.Text;

namespace exclusividades_myk
{
    public class Venta
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }

        public Venta(int id, string cliente, string producto,
                     double total, DateTime fecha)
        {
            Id = id;
            Cliente = cliente;
            Producto = producto;
            Total = total;
            Fecha = fecha;
        }
    }
}
