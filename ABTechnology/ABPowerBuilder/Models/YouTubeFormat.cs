

namespace Models
{
    /// <summary>
    /// Record is deisnged to stor information to set a YouTube video or livestream
    /// </summary>
    public record YouTubeFormat: JsonRecord
    {
        public YouTubeFormat()
        {
            FormatName = "YouTube Format";
            FormatDescription = "Format is designed to store information to setup a YouTube video's and Livestreams";
            FormatAuthor = "Albert M. Byrd";
        }

        public string? Notes { get; init; }
        public string? Description { get; init; }
        public string? Tags { get; init; }
        public double FontSize { get; init; }
        public string? FontFamily { get; init; }


    }
}
