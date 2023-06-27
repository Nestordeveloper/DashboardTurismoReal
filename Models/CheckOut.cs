using System;
using System.ComponentModel;

namespace DashboardTurismoReal.Models
{
    public class CheckOut
    {
        [DisplayName("Código de Check-Out")]
        public int CheckOutId { get; set; }
        [DisplayName("Observaciones del Cliente")]
        public string CheckOutDescription { get; set; }
        [DisplayName("Código de Reserva")]
        public int BookingId { get; set; }
        [DisplayName("Código del Departamento")]
        public string DepartmentCode { get; set; }
        [DisplayName("Fecha de Salida")]
        public DateTime CheckOutDate { get; set; }
    }
}
