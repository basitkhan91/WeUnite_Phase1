using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Reach.Entity.Classes.Common;

namespace Reach.Entity
{
    public class Tutee : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Contact { get; set; }

        [MaxLength(15)]
        public string AlternateContact { get; set; }
       
        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        public int AddressId { get; set; }
    }
}
