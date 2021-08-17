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

In order to run benchmarks, type this command in your favorite terminal :
>
> :writing_hand: `.\App.exe`
>

```
|                     Method |       Categories | Length |      Mean |    Error |    StdDev |    Median |       Min |       Max | Rank |   Gen 0 |  Gen 1 | Allocated |
|--------------------------- |----------------- |------- |----------:|---------:|----------:|----------:|----------:|----------:|-----:|--------:|-------:|----------:|
| SerializeAndDeserializeOne |  BinaryFormatter |     16 |  14.14 μs | 0.349 μs |  0.991 μs |  13.78 μs |  12.94 μs |  17.11 μs |    1 |  3.0518 |      - |     13 KB |
| SerializeAndDeserializeTwo | BinarySerializer |     16 |  35.35 μs | 0.702 μs |  1.248 μs |  35.12 μs |  33.01 μs |  37.56 μs |    2 | 16.6626 |      - |     68 KB |
|                            |                  |        |           |          |           |           |           |           |      |         |        |           |
| SerializeAndDeserializeOne |  BinaryFormatter |     32 |  13.73 μs | 0.269 μs |  0.441 μs |  13.69 μs |  12.80 μs |  14.69 μs |    1 |  3.3569 |      - |     14 KB |
| SerializeAndDeserializeTwo | BinarySerializer |     32 |  51.26 μs | 1.016 μs |  1.753 μs |  50.87 μs |  47.43 μs |  54.91 μs |    2 | 21.2402 |      - |     87 KB |
|                            |                  |        |           |          |           |           |           |           |      |         |        |           |
| SerializeAndDeserializeOne |  BinaryFormatter |     64 |  13.59 μs | 0.262 μs |  0.257 μs |  13.54 μs |  13.23 μs |  14.09 μs |    1 |  3.4332 |      - |     14 KB |
| SerializeAndDeserializeTwo | BinarySerializer |     64 |  82.46 μs | 1.646 μs |  3.471 μs |  81.33 μs |  75.48 μs |  91.25 μs |    2 | 30.5176 |      - |    125 KB |
|                            |                  |        |           |          |           |           |           |           |      |         |        |           |
| SerializeAndDeserializeOne |  BinaryFormatter |    128 |  14.06 μs | 0.266 μs |  0.284 μs |  14.01 μs |  13.60 μs |  14.69 μs |    1 |  4.0741 |      - |     17 KB |
| SerializeAndDeserializeTwo | BinarySerializer |    128 | 143.50 μs | 2.593 μs |  3.882 μs | 142.34 μs | 138.86 μs | 153.89 μs |    2 | 49.0723 | 0.2441 |    201 KB |
|                            |                  |        |           |          |           |           |           |           |      |         |        |           |
| SerializeAndDeserializeOne |  BinaryFormatter |    256 |  15.39 μs | 0.269 μs |  0.320 μs |  15.39 μs |  14.63 μs |  15.84 μs |    1 |  4.3640 |      - |     18 KB |
| SerializeAndDeserializeTwo | BinarySerializer |    256 | 284.41 μs | 7.486 μs | 21.719 μs | 274.92 μs | 257.41 μs | 343.50 μs |    2 | 86.4258 |      - |    354 KB |
```