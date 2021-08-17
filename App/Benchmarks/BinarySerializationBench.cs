using App.Helpers;
using BenchmarkDotNet.Attributes;
using LibOne;
using LibTwo;
using EmployeeOne = LibOne.Models.Employee;
using EmployeeTwo = LibTwo.Models.Employee;

namespace App.Benchmarks
{
    [Config(typeof(BenchConfig))]
    public class BinarySerializationBench
    {
        private static readonly LibOneBinarySerializer SerializerOne = new ();
        private static readonly LibTwoBinarySerializer SerializerTwo = new ();

        public EmployeeOne EmployeeOne { get; private set; }
        public EmployeeTwo EmployeeTwo { get; private set; }

        [Params(16, 32, 64, 128, 256)]
        public int Length { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            EmployeeOne = RandomHelper.RandomEmployeeOne(Length);
            EmployeeTwo = RandomHelper.RandomEmployeeTwo(Length);
        }

        [Benchmark]
        [BenchmarkCategory(nameof(BenchCategory.BinaryFormatter))]
        public EmployeeOne SerializeAndDeserializeOne()
        {
            using var stream = SerializerOne.Serialize(EmployeeOne);
            return SerializerOne.Deserialize<EmployeeOne>(stream);
        }

        [Benchmark]
        [BenchmarkCategory(nameof(BenchCategory.BinarySerializer))]
        public EmployeeTwo SerializeAndDeserializeTwo()
        {
            using var stream = SerializerTwo.Serialize(EmployeeTwo);
            return SerializerTwo.Deserialize<EmployeeTwo>(stream);
        }
    }
}