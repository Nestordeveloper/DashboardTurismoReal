using System;

namespace DashboardTurismoReal.Models
{
    public class ReservaTransporte
    {
        public int TransportReservationId { get; set; }
        public int TransportId { get; set; }
        public DateTime TransportDate { get; set; }
        public DateTime TransportTime { get; set; }
        public decimal Price { get; set; }
        public int BookingId { get; set; }
    }

}
