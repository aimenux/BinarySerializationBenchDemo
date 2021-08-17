using App.Benchmarks;
using BenchmarkDotNet.Running;

namespace App
{
    public static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<BinarySerializationBench>();
        }
    }
}
