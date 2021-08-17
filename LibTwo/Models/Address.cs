using BinarySerialization;

namespace LibTwo.Models
{
    public class Address
    {
        [FieldOrder(0)]
        public string City { get; set; }

        [FieldOrder(1)]
        public string Country { get; set; }
    }
}