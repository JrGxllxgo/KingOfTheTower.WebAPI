using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public bool Pay { get; set; }

        public int wins { get; set; }
        public int defeats { get; set; }
        public int points_diff { get; set; }
        public int classification_points { get; set;}
    }
}
