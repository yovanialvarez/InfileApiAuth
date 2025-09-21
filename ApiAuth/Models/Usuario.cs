using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAuth.Models
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Column("usuario")]
        public string NombreUsuario { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("apellido")]
        public string Apellido { get; set; }

        [Column("activo")]
        public bool Activo { get; set; }
    }
}
