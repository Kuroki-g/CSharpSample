using BenchmarkDotNet.Attributes;

namespace RefStructBenchmark.Measurements;

[MemoryDiagnoser]
public class InitializeMeasurement
{
    private const int N = 1000;

    [Benchmark(Baseline = true)]
    public void InitializeClass()
    {
        for (var i = 0; i < N; i++)
        {
            var sample = new SampleClass { X = 1, Y = 2 };
        }
    }

    [Benchmark]
    public void InitializeStruct()
    {
        for (var i = 0; i < N; i++)
        {
            var sample = new SampleStruct(1, 2);
        }
    }

    [Benchmark]
    public void InitializeStructRef()
    {
        for (var i = 0; i < N; i++)
        {
            var sample = new SampleStructRef(1, 2);
        }
    }

    [Benchmark]
    public void InitializeReadonlyStruct()
    {
        for (var i = 0; i < N; i++)
        {
            var sample = new SampleReadonlyStruct(1, 2);
        }
    }

    [Benchmark]
    public void InitializeReadonlyStructRef()
    {
        for (var i = 0; i < N; i++)
        {
            var sample = new SampleReadonlyStructRef(1, 2);
        }
    }
}
