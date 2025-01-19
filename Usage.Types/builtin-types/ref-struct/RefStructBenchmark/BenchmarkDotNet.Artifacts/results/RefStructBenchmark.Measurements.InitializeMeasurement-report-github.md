```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish) WSL
Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK 8.0.112
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2


```
| Method                      | Mean     | Error   | StdDev  | Ratio | Allocated | Alloc Ratio |
|---------------------------- |---------:|--------:|--------:|------:|----------:|------------:|
| InitializeClass             | 241.4 ns | 1.72 ns | 1.52 ns |  1.00 |         - |          NA |
| InitializeStruct            | 241.5 ns | 1.98 ns | 1.65 ns |  1.00 |         - |          NA |
| InitializeStructRef         | 240.8 ns | 1.92 ns | 1.80 ns |  1.00 |         - |          NA |
| InitializeReadonlyStruct    | 241.3 ns | 1.43 ns | 1.27 ns |  1.00 |         - |          NA |
| InitializeReadonlyStructRef | 241.5 ns | 2.62 ns | 2.33 ns |  1.00 |         - |          NA |
