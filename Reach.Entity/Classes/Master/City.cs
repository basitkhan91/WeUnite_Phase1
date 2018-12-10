using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reach.Entity
{
    public class Master{

    }

    public class City : Master
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }

        public int StateId { get; set; }
    }
}
