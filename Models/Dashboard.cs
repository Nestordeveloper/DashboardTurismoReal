namespace DashboardTurismoReal.Models
{
    public class Dashboard
    {
        public int BookingTotal { get; set; }
        public int DepartmentTotal { get; set; }
        public string? PayValue { get; set; }
        public int BookingsDay { get; set; }
        public int BookingsWeek { get; set; }
        public int BookingsMonth { get; set; }
        public int BookingsYear { get; set; }
        public int IncomeDay { get; set; }
        public int IncomeWeek { get; set; }
        public int IncomeMonth { get; set; }
        public int IncomeYear { get; set; }
    }
}
