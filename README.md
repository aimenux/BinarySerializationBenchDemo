[![.NET](https://github.com/aimenux/BinarySerializationBenchDemo/actions/workflows/ci.yml/badge.svg)](https://github.com/aimenux/BinarySerializationBenchDemo/actions/workflows/ci.yml)

# BinarySerializationBenchDemo
```
Benchmarking various ways of binary serialization / deserialization
```

In this demo, i m using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library in order to benchmark binary serialization / deserialization base on :
>
> :one: Built-In Library [BinaryFormatter](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter)
>
> :two: Third-Party Library [BinarySerializer](https://github.com/jefffhaynes/BinarySerializer)
>
> :three: Third-Party Library [GroBuf](https://github.com/skbkontur/GroBuf)
>

In order to run benchmarks, type this command in your favorite terminal :
>
> :writing_hand: `.\App.exe`
>

```
|                       Method |       Categories | Length |         Mean |       Error |      StdDev |       Median |          Min |          Max | Rank |   Gen 0 |  Gen 1 | Allocated |
|----------------------------- |----------------- |------- |-------------:|------------:|------------:|-------------:|-------------:|-------------:|-----:|--------:|-------:|----------:|
| SerializeAndDeserializeThree |           GroBuf |     16 |     416.2 ns |     7.48 ns |     6.25 ns |     418.0 ns |     402.8 ns |     426.7 ns |    1 |  0.2732 |      - |      1 KB |
|   SerializeAndDeserializeOne |  BinaryFormatter |     16 |  13,532.8 ns |   269.52 ns |   264.71 ns |  13,491.9 ns |  13,186.4 ns |  14,108.9 ns |    2 |  3.0670 |      - |     13 KB |
|   SerializeAndDeserializeTwo | BinarySerializer |     16 |  35,633.3 ns |   689.89 ns | 1,011.23 ns |  35,356.2 ns |  34,077.6 ns |  37,958.8 ns |    3 | 16.6626 |      - |     68 KB |
|                              |                  |        |              |             |             |              |              |              |      |         |        |           |
| SerializeAndDeserializeThree |           GroBuf |     32 |     442.9 ns |     8.42 ns |    12.07 ns |     440.2 ns |     427.3 ns |     477.3 ns |    1 |  0.3877 |      - |      2 KB |
|   SerializeAndDeserializeOne |  BinaryFormatter |     32 |  13,821.7 ns |   273.62 ns |   355.78 ns |  13,714.4 ns |  13,312.7 ns |  14,646.1 ns |    2 |  3.3569 |      - |     14 KB |
|   SerializeAndDeserializeTwo | BinarySerializer |     32 |  53,454.8 ns | 1,056.91 ns | 2,839.33 ns |  52,893.1 ns |  48,752.3 ns |  62,086.4 ns |    3 | 21.2402 |      - |     87 KB |
|                              |                  |        |              |             |             |              |              |              |      |         |        |           |
| SerializeAndDeserializeThree |           GroBuf |     64 |     508.7 ns |    10.11 ns |    19.24 ns |     503.0 ns |     478.0 ns |     553.8 ns |    1 |  0.6170 |      - |      3 KB |
|   SerializeAndDeserializeOne |  BinaryFormatter |     64 |  13,784.1 ns |   272.84 ns |   563.47 ns |  13,585.5 ns |  12,960.8 ns |  15,378.3 ns |    2 |  3.4332 |      - |     14 KB |
|   SerializeAndDeserializeTwo | BinarySerializer |     64 |  83,415.0 ns | 1,624.19 ns | 1,667.92 ns |  83,652.9 ns |  79,561.0 ns |  85,660.4 ns |    3 | 30.5176 |      - |    125 KB |
|                              |                  |        |              |             |             |              |              |              |      |         |        |           |
| SerializeAndDeserializeThree |           GroBuf |    128 |     608.9 ns |    12.14 ns |    11.36 ns |     613.2 ns |     587.5 ns |     625.6 ns |    1 |  1.0767 |      - |      4 KB |
|   SerializeAndDeserializeOne |  BinaryFormatter |    128 |  13,998.9 ns |   263.34 ns |   233.45 ns |  13,943.7 ns |  13,557.2 ns |  14,491.6 ns |    2 |  4.0741 |      - |     17 KB |
|   SerializeAndDeserializeTwo | BinarySerializer |    128 | 146,299.3 ns | 2,035.32 ns | 1,589.04 ns | 146,414.2 ns | 143,933.0 ns | 149,390.3 ns |    3 | 49.0723 | 0.2441 |    201 KB |
|                              |                  |        |              |             |             |              |              |              |      |         |        |           |
| SerializeAndDeserializeThree |           GroBuf |    256 |   1,205.1 ns |    33.47 ns |    96.04 ns |   1,171.1 ns |     887.6 ns |   1,469.1 ns |    1 |  1.9941 |      - |      8 KB |
|   SerializeAndDeserializeOne |  BinaryFormatter |    256 |  15,265.2 ns |   297.64 ns |   292.32 ns |  15,205.7 ns |  14,907.2 ns |  15,952.1 ns |    2 |  4.3640 |      - |     18 KB |
|   SerializeAndDeserializeTwo | BinarySerializer |    256 | 272,081.7 ns | 5,303.47 ns | 6,707.19 ns | 272,137.0 ns | 261,672.5 ns | 286,464.2 ns |    3 | 86.4258 |      - |    354 KB |
```