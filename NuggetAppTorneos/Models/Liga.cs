using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuggetAppTorneos.Models
{
    [Table("Liga")]
    public class Liga
    {
        [Key]
        [Column("IdLiga")]
        public int IdLiga { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [Column("FechaFin")]
        public DateTime? FechaFin { get; set; }

        [Column("Estado")]
        public int Estado { get; set; }

        [Column("Creador")]
        public int Creador { get; set; }
    }
}
