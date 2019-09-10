using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectMVC.Models
{
    public class VentasProducto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int  CantidadVenta { get; set; }
        public decimal Total { get; set; }
    }
}