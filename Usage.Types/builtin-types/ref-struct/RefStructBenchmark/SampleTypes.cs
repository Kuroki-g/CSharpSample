using BenchmarkDotNet.Attributes;

public class SampleClass(int x, int y)
{
    public int X { get; set; } = x;

    public int Y { get; set; } = y;

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

public ref struct SampleStructRef(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public override string ToString() => $"X: {X}, Y: {Y}";
}

public readonly ref struct SampleReadonlyStructRef(int x, int y)
{
    // public int X { get; set; } = x; // Error: Property or indexer cannot be assigned to -- it is read only
    public int X { get; init; } = x;

    public int Y { get; init; } = y;

    public override string ToString() => $"X: {X}, Y: {Y}";
}
