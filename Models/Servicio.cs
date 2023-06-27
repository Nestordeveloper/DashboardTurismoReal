using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class Servicio
    {
        [DisplayName("Código del Servicio")]
        public int? ServiceId { get; set; }
        [DisplayName("Nombre del Servicio")]
        public string? ServiceName { get; set; }
        [DisplayName("Tipo de Servicio")]
        public string? ServiceType { get; set; }
        [DisplayName("RUT Empresa")]
        public string? CompanyRut { get; set; }
        [Browsable(false)] // Ocultar este campo en el DataGrid
        public int? CommuneId { get; set; }
        [Browsable(false)] // Ocultar este campo en el DataGrid
        public int? ServiceTypeId { get; set; }
        [DisplayName("Valor del Servicio")]
        public int? ServiceValue { get; set; }
        [DisplayName("Nombre Comuna")]
        public string? CommuneName { get; set; }
    }
}
