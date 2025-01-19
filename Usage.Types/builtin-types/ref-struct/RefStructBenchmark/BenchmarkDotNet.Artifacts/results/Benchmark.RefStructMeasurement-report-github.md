```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish) WSL
Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK 8.0.112
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2


```
| Method                         | Mean     | Error    | StdDev   | Gen0   | Allocated |
|------------------------------- |---------:|---------:|---------:|-------:|----------:|
| MeasureSampleClass             | 55.73 ns | 1.156 ns | 1.237 ns | 0.0114 |      72 B |
| MeasureSampleStruct            | 53.56 ns | 0.585 ns | 0.489 ns | 0.0076 |      48 B |
| MeasureSampleStructRef         | 55.47 ns | 1.115 ns | 1.284 ns | 0.0076 |      48 B |
| MeasureSampleReadonlyStruct    | 53.59 ns | 0.657 ns | 0.582 ns | 0.0076 |      48 B |
| MeasureSampleReadonlyStructRef | 51.01 ns | 0.733 ns | 0.686 ns | 0.0076 |      48 B |
