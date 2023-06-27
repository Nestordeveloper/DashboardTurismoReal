using System;
using System.ComponentModel;

namespace DashboardTurismoReal.Models
{
    public class CheckIn
    {
        [DisplayName("Código de Check-In")]
        public int CheckInId { get; set; }
        [DisplayName("Código de Reserva")]
        public int BookingId { get; set; }
        [DisplayName("Cantidad de Personas Ingresaron")]
        public int NumPersons { get; set; }
        [DisplayName("Código del Departamento")]
        public string? DepartmentCode { get; set; }
        [DisplayName("Fecha de Ingreso")]
        public DateTime CheckInDate { get; set; }
    }
}
