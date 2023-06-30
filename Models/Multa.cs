using System.ComponentModel;

namespace DashboardTurismoReal.Models
{
    public class Multa
    {
        [DisplayName("Código de Multa")]
        public int? MultaId { get; set; }
        [DisplayName("RUT Usuario")]
        public string? Rut { get; set; }
        [DisplayName("Código de Departamento")]
        public string DepartmentCode { get; set; }
        [DisplayName("Código del Producto")]
        public int? ProductId { get; set; }
        [DisplayName("Razón de Multa")]
        public string? Reason { get; set; }
        [DisplayName("Valor de Multa")]
        public decimal? MultaValue { get; set; }
        [DisplayName("Foto de Multa")]
        public byte[]? MultaPhoto { get; set; }
        [DisplayName("Código del Check-Out")]
        public int CheckoutId { get; set; }
        [DisplayName("Código de Reserva")]
        public int? BookingId { get; set; }
    }
}
