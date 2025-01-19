using BenchmarkDotNet.Attributes;

namespace Benchmark;

public class StructMeasurement
{
    [Benchmark]
    public string MeasureSampleClass()
    {
        var sample = new SampleClass { X = 1, Y = 2 };
        return sample.ToString();
    }

    [Benchmark]
    public string MeasureSampleStruct()
    {
        var sample = new SampleStruct(1, 2);
        return sample.ToString();
    }

    [Benchmark]
    public string MeasureSampleReadonlyStruct()
    {
        var sample = new SampleReadonlyStruct(1, 2);
        return sample.ToString();
    }
}

public class SampleClass()
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString() => $"X: {X}, Y: {Y}";
}

public struct SampleStruct(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public override string ToString() => $"X: {X}, Y: {Y}";
}

public readonly struct SampleReadonlyStruct(int x, int y)
{
    // public int X { get; set; } = x; // Error: Property or indexer cannot be assigned to -- it is read only
    public int X { get; init; } = x;

    public int Y { get; init; } = y;

    public override string ToString() => $"X: {X}, Y: {Y}";
}
