using System.IO;
using BinarySerialization;

namespace LibTwo
{
    public class LibTwoBinarySerializer : IBinarySerializer
    {
        private readonly BinarySerializer _serializer;

        public LibTwoBinarySerializer()
        {
            _serializer = new BinarySerializer();
        }

        public string Description => "Binary serialization based on BinarySerializer";

        public Stream Serialize<T>(T obj)
        {
            var stream = new MemoryStream();
            _serializer.Serialize(stream, obj);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        public T Deserialize<T>(Stream stream)
        {
            var obj = _serializer.Deserialize<T>(stream);
            return obj;
        }
    }
}