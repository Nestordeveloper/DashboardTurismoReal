using System;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class Provincia
    {
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public int RegionId { get; set; }
    }
}
