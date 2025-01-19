using BenchmarkDotNet.Attributes;

namespace RefStructBenchmark.Measurements;

[MemoryDiagnoser]
/// <summary>
/// NOTE: 厳密に言えばインスタンス作成のコストがかかるが、ToStringメソッドの呼び出しによるものに比べれば小さいため無視する。
/// </summary>
public class CallOverrideMethod
{
    private const int N = 1000;

    [Benchmark(Baseline = true)]
    public void CallOverrideMethodClass()
    {
        var sampleClass = new SampleClass(1, 2);
        for (var i = 0; i < N; i++)
        {
            sampleClass.ToString();
        }
    }

    [Benchmark]
    public void CallOverrideMethodStruct()
    {
        var sampleStruct = new SampleStruct(1, 2);
        for (var i = 0; i < N; i++)
        {
            sampleStruct.ToString();
        }
    }

    [Benchmark]
    public void CallOverrideMethodStructRef()
    {
        var sampleStructRef = new SampleStructRef(1, 2);
        for (var i = 0; i < N; i++)
        {
            sampleStructRef.ToString();
        }
    }

    [Benchmark]
    public void CallOverrideMethodReadonlyStruct()
    {
        var sampleReadonlyStruct = new SampleReadonlyStruct(1, 2);
        for (var i = 0; i < N; i++)
        {
            sampleReadonlyStruct.ToString();
        }
    }

    [Benchmark]
    public void CallOverrideMethodReadonlyStructRef()
    {
        var sampleReadonlyStructRef = new SampleReadonlyStructRef(1, 2);
        for (var i = 0; i < N; i++)
        {
            sampleReadonlyStructRef.ToString();
        }
    }
}
