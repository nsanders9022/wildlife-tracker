using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wildlife.Models
{
    [Table ("Sighting")]
    public class Sighting
    {
        [Key]
        public int SightingId { get; set; }
        public string date { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public int SpeciesId { get; set; }
        public virtual Species Species { get; set; }
    }
}
