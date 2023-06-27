using Oracle.ManagedDataAccess.Client;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class Region
    {
        [DisplayName("Código Región")]
        public int RegionId { get; set; }
        [DisplayName("Nombre Región")]
        public string RegionName { get; set; }
        
    }
}
