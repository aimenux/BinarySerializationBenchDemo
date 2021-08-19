using ProtoBuf;

namespace LibFour.Models
{
    [ProtoContract]
    public class Employee
    {
        [ProtoMember(1)]
        public long Id { get; set; }

        [ProtoMember(2)]
        public string FirstName { get; set; }

        [ProtoMember(3)]
        public string LastName { get; set; }

        [ProtoMember(4)]
        public string Title { get; set; }

        [ProtoMember(5)]
        public Address Address { get; set; }
    }
}
