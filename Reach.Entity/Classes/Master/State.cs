using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reach.Entity
{
    public class State : Master
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        public int CountryId { get; set; }

        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}
