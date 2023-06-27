using System;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class Rol
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public int IsActive { get; set; }
    }
}
