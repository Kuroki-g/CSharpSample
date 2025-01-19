```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish) WSL
Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK 8.0.112
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2


```
| Method                      | Mean     | Error    | StdDev   |
|---------------------------- |---------:|---------:|---------:|
| MeasureSampleClass          | 57.35 ns | 0.828 ns | 0.734 ns |
| MeasureSampleStruct         | 53.44 ns | 0.762 ns | 0.636 ns |
| MeasureSampleReadonlyStruct | 56.26 ns | 1.133 ns | 1.512 ns |
