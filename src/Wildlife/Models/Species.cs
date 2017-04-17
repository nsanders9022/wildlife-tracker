using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wildlife.Models
{
    [Table("Species")]
    public class Species
    {
        public Species()
        {
            this.Sighting = new HashSet<Sighting>();
        }

        [Key]
        public int SpeciesId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sighting> Sighting { get; set; }
    }
}
