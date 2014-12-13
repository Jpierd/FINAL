using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;

namespace Final.ViewModels.Ventas
{
    public class CrearVentaViewModel
    {
        public int Id { get; set; }
        public string NumeroComprobante { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public IList<CrearVentaProductsViewModel> Products { get; set; }

        public IList<CrearVentaClienteViewModel> Clientes { get; set; } 
    }

    public class CrearVentaProductsViewModel
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
    }

    public class CrearVentaClienteViewModel
    {
        public int Id { get; set; }
        public String Name { get ; set; }
    }
}