using BenchmarkDotNet.Attributes;

namespace RefStructBenchmark.Measurements;

[MemoryDiagnoser]
public class CallOverrideMethod
{
    private const int N = 1000;

    private readonly SampleClass _sampleClass;

    private readonly SampleStruct _sampleStruct;

    private readonly SampleStructRef _sampleStructRef;

    private readonly SampleReadonlyStruct _sampleReadonlyStruct;

    private readonly SampleReadonlyStructRef _sampleReadonlyStructRef;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _sampleClass = new SampleClass { X = 1, Y = 2 };
        _sampleStruct = new SampleStruct(1, 2);
        _sampleStructRef = new SampleStructRef(1, 2);
        _sampleReadonlyStruct = new SampleReadonlyStruct(1, 2);
        _sampleReadonlyStructRef = new SampleReadonlyStructRef(1, 2);
    }

    [Benchmark]
    public void CallOverrideMethodClass()
    {
        for (var i = 0; i < N; i++)
        {
            _sampleClass.ToString();
        }
    }

    [Benchmark]
    public void CallOverrideMethodStruct()
    {
        for (var i = 0; i < N; i++)
        {
            _sampleStruct.ToString();
        }
    }

    [Benchmark]
    public void CallOverrideMethodStructRef()
    {
        for (var i = 0; i < N; i++)
        {
            _sampleStructRef.ToString();
        }
    }

    [Benchmark]
    public void CallOverrideMethodReadonlyStruct()
    {
        for (var i = 0; i < N; i++)
        {
            _sampleReadonlyStruct.ToString();
        }
    }

    [Benchmark]
    public void CallOverrideMethodReadonlyStructRef()
    {
        for (var i = 0; i < N; i++)
        {
            _sampleReadonlyStructRef.ToString();
        }
    }
}
