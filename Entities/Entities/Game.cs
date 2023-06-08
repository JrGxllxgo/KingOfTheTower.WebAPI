using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        public Team Team1 { get; set; }

        public Team Team2 { get; set; }

        public int Score1 { get; set; }

        public int Score2 { get; set; }

        public int Court { get; set; }

        public DateTime Schedule { get; set; }
        
        public User Staff { get; set; }

    }
}
