
using System.Collections.Generic;
using Inventario.API.Models;

namespace Inventario.API.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int StockActual { get; set; }
        public int StockMinimo { get; set; }

        public bool Reabastecer { get; set; }
        public bool Activo { get; set; }

        public List<MovimientoInventario> Movimientos { get; set; }
    }
}

