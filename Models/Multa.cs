namespace DashboardTurismoReal.Models
{
    public class Multa
    {
        public int MultaId { get; set; }
        public string Rut { get; set; }
        public string DepartmentCode { get; set; }
        public int ProductId { get; set; }
        public string Reason { get; set; }
        public decimal MultaValue { get; set; }
        public byte[] MultaPhoto { get; set; }
        public int CheckoutId { get; set; }
        public int BookingId { get; set; }
    }
}
