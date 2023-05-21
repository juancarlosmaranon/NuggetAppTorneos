﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuggetAppTorneos.Models
{
    [Table("EquipoLiga")]
    public class EquipoLiga
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("IdLiga")]
        public int IdLiga { get; set; }

        [Column("IdEquipo")]
        public int IdEquipo { get; set; }

        [Column("Victorias")]
        public int Ganados { get; set; }

        [Column("Derrotas")]
        public int Perdidos { get; set; }

        [Column("EMPATES")]
        public int Empates { get; set; }

        [Column("Inscrito")]
        public bool Inscrito { get; set; }
    }
}
