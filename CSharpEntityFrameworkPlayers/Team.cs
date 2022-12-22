using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    //Milestone 2
    //creare una seconda entità
    [Table("team")]
    public class Team
    {
        public int teamId { get; set; }

        [Required]
        [Column("nome")]
        public string name { get; set; }

        [Required]
        [Column("città")]
        public string city { get; set; }

        [Column("allenatore")]
        public string coach { get; set; }

        [Column("colori")]
        public string color { get; set; }

        //relazione 1-n con Player
        public List<Player> playersInTeam { get; set; } = new List<Player>();
    }
}
