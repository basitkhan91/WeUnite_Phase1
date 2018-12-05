using Reach.Entity.Classes.Common;

namespace Reach.Entity
{
    public class Address : BaseEntity
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string LandMark { get; set; }
    }
}
