using System.IO;

namespace LibTwo
{
    public interface IBinarySerializer
    {
        string Description { get; }

        Stream Serialize<T>(T obj);

        T Deserialize<T>(Stream stream);
    }
}