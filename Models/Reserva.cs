using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class Reserva
    {
        [DisplayName ("ID Reserva")]
        public int? BookingId { get; set; }
        [DisplayName("RUT")]
        public string? RUT { get; set; }
        [DisplayName("Código del Departamento")]
        public string? DepartmentId { get; set; }
        [DisplayName("Estado Reserva")]
        public string? BookingStatus { get; set; }
        [DisplayName("Estado de Pago")]
        public string? PayStatus { get; set; }
        [DisplayName("Fecha de Ingreso")]
        public DateTime EntryDate {  get; set; }
        [DisplayName("Fecha de Salida")]
        public DateTime DepartureDate { get; set; }
        [DisplayName("Valor de Reserva")]
        public int? BookingValue { get; set; }
        [DisplayName("Valor Restante")]
        public string? remainingValue { get; set; }
        [DisplayName("Valor Pagado")]
        public string? paidValue { get; set; }
    }
}
