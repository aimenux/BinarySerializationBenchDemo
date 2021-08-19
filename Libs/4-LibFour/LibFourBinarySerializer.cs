using System.IO;
using ProtoBuf;

namespace LibFour
{
    public class LibFourBinarySerializer : IBinarySerializer
    {
        public string Description => "Binary serialization based on Protobuf";

        public Stream Serialize<T>(T obj)
        {
            var stream = new MemoryStream();
            Serializer.Serialize(stream, obj);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        public T Deserialize<T>(Stream stream)
        {
            var obj = Serializer.Deserialize<T>(stream);
            return obj;
        }
    }
}