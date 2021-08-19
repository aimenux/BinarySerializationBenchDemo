using ProtoBuf;

namespace LibFour.Models
{
    [ProtoContract]
    public class Address
    {
        [ProtoMember(1)]
        public string City { get; set; }

        [ProtoMember(2)]
        public string Country { get; set; }
    }
}