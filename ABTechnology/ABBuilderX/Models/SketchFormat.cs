
namespace Models;

/// <summary>
/// Record is designed to store information about a sketch that I'm working on.
/// </summary>
public record SketchFormat: JsonRecord
{
    public SketchFormat()
    {

    }

    public double Width { get; init; }
    
    public double Height { get; init; }
        



}
