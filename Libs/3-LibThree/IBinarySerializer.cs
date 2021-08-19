using System.IO;

namespace LibThree
{
    public interface IBinarySerializer
    {
        string Description { get; }

        Stream Serialize<T>(T obj);

        T Deserialize<T>(Stream stream);
    }
}