using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class Producto
    {
        [DisplayName ("Código del Producto")]
        public int ProductId { get; set; }
        [DisplayName("Código de Inventario")]
        public string? InventoryId { get; set; }
        [DisplayName("Categoría")]
        public string? CategoryName { get; set; }
        [DisplayName("Nombre del Producto")]
        public string? ProductName { get; set; }
    }
}
