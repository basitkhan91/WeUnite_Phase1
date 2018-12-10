using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Reach.Entity
{
    public class Country : Master
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<State> States { get; set; } = new List<State>();
    }
}
