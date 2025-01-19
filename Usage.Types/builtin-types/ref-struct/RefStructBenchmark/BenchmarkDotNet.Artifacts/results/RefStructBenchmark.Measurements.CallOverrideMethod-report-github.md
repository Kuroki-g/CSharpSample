```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish) WSL
Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK 8.0.112
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2


```
| Method                              | Mean     | Error    | StdDev   | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------------ |---------:|---------:|---------:|------:|-------:|----------:|------------:|
| CallOverrideMethodClass             | 47.00 μs | 0.305 μs | 0.271 μs |  1.00 | 7.6294 |   46.9 KB |        1.00 |
| CallOverrideMethodStruct            | 45.84 μs | 0.615 μs | 0.576 μs |  0.98 | 7.6294 |  46.88 KB |        1.00 |
| CallOverrideMethodStructRef         | 46.67 μs | 0.318 μs | 0.281 μs |  0.99 | 7.6294 |  46.88 KB |        1.00 |
| CallOverrideMethodReadonlyStruct    | 46.14 μs | 0.279 μs | 0.261 μs |  0.98 | 7.6294 |  46.88 KB |        1.00 |
| CallOverrideMethodReadonlyStructRef | 45.56 μs | 0.273 μs | 0.242 μs |  0.97 | 7.6294 |  46.88 KB |        1.00 |
