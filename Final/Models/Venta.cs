using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Venta
    {
        public int Id { get; set; }

        public String NumeroComprobante { get; set; }

        public DateTime FechaComprobante { get; set; }

        public int ClienteId { get; set; }

        public IList<DetalleVenta> Detalle { get; set; } 
    }
}