using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class InventarioDepartamento
    {
        [DisplayName ("Código del Departamento")]
        public string DepartmentId { get; set; }
        [DisplayName("Código del Inventario")]
        public string InventoryId { get; set; }
    }
}
