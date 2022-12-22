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
    //creazione entità
    [Table("players")]
    public class Player
    {
        //proprietà e data annotations
        public int PlayerId { get; set; }

        [Required]
        [Column("nome")]
        public string name { get; set; }

        [Required]
        [Column("cognome")]
        public string surname { get; set; }

        [Column("punteggio")]
        public double score { get; set; }

        [Column("partite_giocate")]
        public int match { get; set; }

        [Column("partite_vinte")]
        public int win { get; set; }

        //relazione 1-n con Team
        public Team team { get; set; }
    }
}
