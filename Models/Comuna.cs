using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DashboardTurismoReal.Models
{
    public class Comuna
    {
        [DisplayName("Código de Comuna")]
        public int ComunneId { get; set; }
        [DisplayName("Nombre Comuna")]
        public string ComunneName { get; set; }
        [DisplayName("Código de Provincia")]
        public int ProvinceId { get; set; }
    }

}