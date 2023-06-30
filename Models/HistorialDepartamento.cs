using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DashboardTurismoReal.Models
{
    public class HistorialDepartamento
    {
        [DisplayName("ID")]
        public int HistoryId { get; set; }
        [DisplayName("Código departamento")]
        public string? DepartmentCode { get; set; }
        [DisplayName("Anterior estado")]
        public string? PreviousState { get; set; }
        [DisplayName("Nuevo estado")]
        public string? NewState { get; set; }
        [DisplayName("Fecha modificación")]
        public DateTime ModificationDate { get; set; }
    }
}