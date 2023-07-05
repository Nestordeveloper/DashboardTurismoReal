using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class ServicioDepartamento
    {
        [DisplayName("Código del Servicio")]
        public int? ServiceId { get; set; }
        [DisplayName("Nombre del Servicio")]
        public string? ServiceName { get; set; }
        [DisplayName("Tipo del Servicio")]
        public string? ServiceType { get; set; }
        [DisplayName("Rut del Proveedor")]
        public string? CompanyRut { get; set; }
        [Browsable(false)]
        [DisplayName("Código de la Comuna")]
        public int? ComunaId { get; set; }
        [DisplayName("Valor del Servicio")]
        public int? ServiceValue { get; set; }
        [Browsable(false)]
        [DisplayName("Código del Tipo de Servicio")]
        public int? ServiceTypeId { get; set; }
        [DisplayName("Comuna del Servicio")]
        public string? ComunaName { get; set; }
        [DisplayName("Código del Departamento")]
        public string? DepartmentId { get; set; }
        [Browsable(false)]
        [DisplayName("Código del Servicio del departamento")]
        public int? ServiceIdDepartment { get; set; }
    }
}
