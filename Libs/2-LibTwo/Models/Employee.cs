using BinarySerialization;

namespace LibTwo.Models
{
    public class Employee
    {
        [FieldOrder(0)]
        public long Id { get; set; }

        [FieldOrder(1)]
        public string FirstName { get; set; }

        [FieldOrder(2)]
        public string LastName { get; set; }

        [FieldOrder(3)]
        public string Title { get; set; }

        [FieldOrder(4)]
        public Address Address { get; set; }
    }
}
