namespace Record.Sample;

/// <summary>
/// <see href="https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/record"/>
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
public class SampleClass(int x, int y)
{
    public int X { get; set; } = x;

    public int Y { get; set; } = y;

    public override string ToString() => $"X: {X}, Y: {Y}";
}

public record class SampleRecordClass(int X, int Y)
{
    public override string ToString() => $"X: {X}, Y: {Y}";
}

/// <summary>
///
/// </summary>
/// <param name="X"></param>
/// <param name="Y"></param>
public record struct SampleRecordStruct(int X, int Y)
{
    public override string ToString() => $"X: {X}, Y: {Y}";
}
