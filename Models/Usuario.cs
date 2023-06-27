using System.ComponentModel;

namespace DashboardTurismoReal.Models
{
    public class Usuario
    {
        [DisplayName("RUT")]
        public string? Rut { get; set; }

        [DisplayName("Primer Nombre")]
        public string? FirstName { get; set; }

        [DisplayName("Segundo Nombre")]
        public string? MiddleName { get; set; }

        [DisplayName("Apellido Paterno")]
        public string? LastName { get; set; }

        [DisplayName("Apellido Materno")]
        public string? MiddleLastName { get; set; }

        [DisplayName("Correo Electrónico")]
        public string? Email { get; set; }

        [DisplayName("Dirección")]
        public string? Address { get; set; }

        [DisplayName("Teléfono Celular")]
        public string? CellPhoneNumber { get; set; }

        [DisplayName("Teléfono Hogar")]
        public string? HomePhoneNumber { get; set; }

        [DisplayName("Comuna")]
        public string? Commune { get; set; }

        [DisplayName("Rol")]
        public string? Rol { get; set; }

        [Browsable(false)]
        [DisplayName("ID Rol")]
        public int? idRol { get; set; }

        [Browsable(false)]
        [DisplayName("Contraseña")]
        public string? Password { get; set; }
    }
}
