using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    //Milestone 0
    [Table("players")]
    public class Player
    {
        public int PlayerId { get; set; }

        [Required]
        [Column("nome")]
        public string Name { get; set; }

        [Required]
        [Column("cognome")]
        public string Surname { get; set; }

        [Column("punteggio")]
        public int Score { get; set; }

        [Column("partite_giocate")]
        public int Match { get; set; }

        [Column("partite_vinte")]
        public int Win { get; set; }
    }
}
