using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class Proveedor
    {
        [DisplayName ("RUT Empresa")]
        public string CompanyId { get; set; }
        [DisplayName("Nombre Empresa")]
        public string CompanyName { get; set; }
        [DisplayName("Dirección Empresa")]
        public string Address { get; set; }
        [DisplayName("Nombre Comuna")]
        public string CommuneName { get; set; }
    }
}