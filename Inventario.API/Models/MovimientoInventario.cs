using Inventario.API.Models;


namespace Inventario.API.Models
{
    public class MovimientoInventario
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }

        public DateTime Fecha { get; set; }
    }
}

