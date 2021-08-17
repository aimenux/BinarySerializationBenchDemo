using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibOne
{
    public class LibOneBinarySerializer : IBinarySerializer
    {
        private readonly IFormatter _formatter;

        public LibOneBinarySerializer()
        {
            _formatter = new BinaryFormatter();
        }

        public string Description => "Binary serialization based on BinaryFormatter";

        public Stream Serialize<T>(T obj)
        {
            var stream = new MemoryStream();
            _formatter.Serialize(stream, obj);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        public T Deserialize<T>(Stream stream)
        {
            var obj = (T)_formatter.Deserialize(stream);
            return obj;
        }
    }
}