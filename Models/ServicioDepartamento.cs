using System.ComponentModel;

namespace DashboardTurismoReal.Models
{
    public class ServicioDepartamento
    {
        [DisplayName("Código del Departamento")]
        public string DepartmentId { get; set; }
        [DisplayName("Código del Servicio")]
        public int ServiceId { get; set; }
    }
}
