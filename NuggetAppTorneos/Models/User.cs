using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuggetAppTorneos.Models
{
    [Table("Usuario")]
    public class User
    {
        [Key]
        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [Column("UsuarioTag")]
        public string UsuarioTag { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Contrasenia")]
        public string Contrasenia { get; set; }
    }
}
