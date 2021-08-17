using System.IO;
using GroBuf;
using GroBuf.DataMembersExtracters;

namespace LibThree
{
    public class LibThreeBinarySerializer : IBinarySerializer
    {
        private readonly Serializer _serializer;

        public LibThreeBinarySerializer()
        {
            _serializer = new Serializer(new PropertiesExtractor());
        }

        public string Description => "Binary serialization based on GroBuf";

        public Stream Serialize<T>(T obj)
        {
            var bytes = _serializer.Serialize(obj);
            var stream = new MemoryStream(bytes);
            return stream;
        }

        public T Deserialize<T>(Stream stream)
        {
            var bytes = ConvertStreamToBytes(stream);
            var obj = _serializer.Deserialize<T>(bytes);
            return obj;
        }

        private byte[] ConvertStreamToBytes(Stream stream)
        {
            if (stream is MemoryStream memoryStream)
            {
                return memoryStream.ToArray();
            }

            using var streamReader = new MemoryStream();
            stream.CopyTo(streamReader);
            return streamReader.ToArray();
        }
    }
}