[![.NET](https://github.com/aimenux/BinarySerializationBenchDemo/actions/workflows/ci.yml/badge.svg)](https://github.com/aimenux/BinarySerializationBenchDemo/actions/workflows/ci.yml)

# BinarySerializationBenchDemo
```
Benchmarking various ways of binary serialization / deserialization
```

In this demo, i m using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library in order to benchmark binary serialization / deserialization based on :
>
> :one: Built-In Library [BinaryFormatter](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter)
>
> :two: Third-Party Library [BinarySerializer](https://github.com/jefffhaynes/BinarySerializer)
>
> :three: Third-Party Library [GroBuf](https://github.com/skbkontur/GroBuf)
>
> :four: Third-Party Library [ProtoBuf](https://github.com/protobuf-net/protobuf-net)
>

In order to run benchmarks, type this command in your favorite terminal :
>
> :writing_hand: `.\App.exe`
>

```
|                       Method |       Categories | Length |         Mean |       Error |       StdDev |       Median |          Min |          Max | Rank |   Gen 0 |  Gen 1 | Allocated |
|----------------------------- |----------------- |------- |-------------:|------------:|-------------:|-------------:|-------------:|-------------:|-----:|--------:|-------:|----------:|
| SerializeAndDeserializeThree |           GroBuf |     16 |     450.3 ns |    13.87 ns |     40.01 ns |     434.2 ns |     406.9 ns |     559.6 ns |    1 |  0.2732 |      - |   1,144 B |
|  SerializeAndDeserializeFour |         ProtoBuf |     16 |   1,236.8 ns |    24.51 ns |     63.71 ns |   1,220.6 ns |   1,144.5 ns |   1,410.3 ns |    2 |  0.1698 |      - |     712 B |
|   SerializeAndDeserializeOne |  BinaryFormatter |     16 |  14,622.9 ns |   290.52 ns |    599.96 ns |  14,517.3 ns |  13,641.9 ns |  16,208.4 ns |    3 |  3.0670 |      - |  12,848 B |
|   SerializeAndDeserializeTwo | BinarySerializer |     16 |  38,458.9 ns |   767.05 ns |  2,060.64 ns |  37,903.0 ns |  35,388.6 ns |  43,984.1 ns |    4 | 16.6626 |      - |  69,728 B |
|                              |                  |        |              |             |              |              |              |              |      |         |        |           |
| SerializeAndDeserializeThree |           GroBuf |     32 |     467.7 ns |     9.24 ns |     25.45 ns |     459.9 ns |     431.5 ns |     542.3 ns |    1 |  0.3877 |      - |   1,624 B |
|  SerializeAndDeserializeFour |         ProtoBuf |     32 |   1,278.6 ns |    20.93 ns |     16.34 ns |   1,280.1 ns |   1,240.6 ns |   1,298.5 ns |    2 |  0.2079 |      - |     872 B |
|   SerializeAndDeserializeOne |  BinaryFormatter |     32 |  14,235.0 ns |   274.15 ns |    662.10 ns |  13,992.1 ns |  13,438.8 ns |  16,078.3 ns |    3 |  3.3569 |      - |  14,057 B |
|   SerializeAndDeserializeTwo | BinarySerializer |     32 |  56,306.2 ns | 1,072.06 ns |  2,284.65 ns |  55,673.9 ns |  52,943.5 ns |  62,155.2 ns |    4 | 21.2402 |      - |  88,992 B |
|                              |                  |        |              |             |              |              |              |              |      |         |        |           |
| SerializeAndDeserializeThree |           GroBuf |     64 |     525.5 ns |    10.37 ns |     25.24 ns |     516.8 ns |     487.2 ns |     587.5 ns |    1 |  0.6170 |      - |   2,584 B |
|  SerializeAndDeserializeFour |         ProtoBuf |     64 |   1,373.4 ns |    29.51 ns |     84.67 ns |   1,343.1 ns |   1,253.6 ns |   1,604.3 ns |    2 |  0.3033 |      - |   1,272 B |
|   SerializeAndDeserializeOne |  BinaryFormatter |     64 |  14,290.0 ns |   281.82 ns |    575.69 ns |  14,165.9 ns |  13,170.8 ns |  15,699.2 ns |    3 |  3.4332 |      - |  14,377 B |
|   SerializeAndDeserializeTwo | BinarySerializer |     64 |  86,683.5 ns | 1,730.80 ns |  4,589.85 ns |  85,030.1 ns |  79,312.7 ns |  99,575.3 ns |    4 | 30.5176 |      - | 128,056 B |
|                              |                  |        |              |             |              |              |              |              |      |         |        |           |
| SerializeAndDeserializeThree |           GroBuf |    128 |     630.9 ns |    12.55 ns |     14.94 ns |     626.9 ns |     613.0 ns |     663.0 ns |    1 |  1.0767 |      - |   4,504 B |
|  SerializeAndDeserializeFour |         ProtoBuf |    128 |   1,594.5 ns |    43.35 ns |    127.13 ns |   1,575.5 ns |   1,406.4 ns |   1,969.3 ns |    2 |  0.5341 |      - |   2,240 B |
|   SerializeAndDeserializeOne |  BinaryFormatter |    128 |  14,171.3 ns |   276.76 ns |    454.73 ns |  14,073.8 ns |  13,502.3 ns |  15,347.4 ns |    3 |  4.0588 |      - |  17,089 B |
|   SerializeAndDeserializeTwo | BinarySerializer |    128 | 152,681.3 ns | 2,844.81 ns |  4,830.70 ns | 151,738.4 ns | 145,723.4 ns | 166,943.5 ns |    4 | 49.0723 | 0.2441 | 206,160 B |
|                              |                  |        |              |             |              |              |              |              |      |         |        |           |
| SerializeAndDeserializeThree |           GroBuf |    256 |     913.8 ns |    12.98 ns |     10.14 ns |     914.3 ns |     897.4 ns |     930.8 ns |    1 |  1.9932 |      - |   8,344 B |
|  SerializeAndDeserializeFour |         ProtoBuf |    256 |   1,967.4 ns |    36.16 ns |     60.41 ns |   1,968.9 ns |   1,847.6 ns |   2,098.1 ns |    2 |  0.9937 |      - |   4,160 B |
|   SerializeAndDeserializeOne |  BinaryFormatter |    256 |  15,954.0 ns |   315.77 ns |    585.31 ns |  15,765.1 ns |  14,973.8 ns |  17,435.6 ns |    3 |  4.3640 |      - |  18,369 B |
|   SerializeAndDeserializeTwo | BinarySerializer |    256 | 292,467.4 ns | 5,573.21 ns | 15,067.49 ns | 289,766.8 ns | 269,638.6 ns | 344,988.4 ns |    4 | 86.4258 |      - | 362,344 B |
```