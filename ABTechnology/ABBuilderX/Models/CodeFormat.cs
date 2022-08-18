

namespace Models
{
    public record CodeFormat: JsonRecord
    {
        public CodeFormat()
        {
            FormatName = "Code Format";
            FormatDescription = "Format is designed to store Code information";
            FormatAuthor = "Albert M. byrd";
        }
        public string? Code { get; init; }
        public string? FontFamily { get; init; }
        public double FontSize { get; init; }
    }
}
