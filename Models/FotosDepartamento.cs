using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DashboardTurismoReal.Models
{
    internal class FotosDepartamento
    {
        [DisplayName("Código del Álbum")]
        public int AlbumId { get; set; }
        [DisplayName("Código del Departamento")]
        public string? DepartmentCod { get; set; }
        [DisplayName("Foto #1")]
        public byte[]? Photo1 { get; set; }
        [DisplayName("Foto #2")]
        public byte[]? Photo2 { get; set; }
        [DisplayName("Foto #3")]
        public byte[]? Photo3 { get; set; }
        [DisplayName("Foto #4")]
        public byte[]? Photo4 { get; set; }
    }
}
