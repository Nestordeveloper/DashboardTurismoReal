using Newtonsoft.Json;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class Departamento
    {
        [DisplayName("Código del Departamento")]
        public string? DepartmentCod { get; set; }

        [DisplayName("Nombre del Departamento")]
        public string? DepartmentName { get; set; }

        [DisplayName("Descripción del Departamento")]
        public string? DepartmentDesc { get; set; }

        [DisplayName("Inventario del Departamento")]
        public string? DepartmentInventory { get; set; }

        [DisplayName("Valor Diario del Departamento")]
        public int DepartmentDailyValue { get; set; }

        [Browsable(false)] // Ocultar este campo en el DataGrid
        public int? DepartmentCommune { get; set; }

        [Browsable(false)] // Ocultar este campo en el DataGrid
        public int? DepartmentRegion { get; set; }

        [Browsable(false)] // Ocultar este campo en el DataGrid
        public int? DepartmentIdStatus { get; set; }

        [JsonProperty("DepartmentStatus")]
        [DisplayName("Estado del Departamento")]
        public string? DepartmentStatus { get; set; }

        [DisplayName("Valor Reserva del Departamento")]
        public int? DepartmentValueBooking { get; set; }

        [DisplayName("Comuna del Departamento")]
        public string? DepartmentCommuneName { get; set; }

        [DisplayName("Región del Departamento")]
        public string? DepartmentRegionName { get; set; }
    }
}
