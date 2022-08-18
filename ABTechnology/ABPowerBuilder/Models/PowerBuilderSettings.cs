

namespace Models
{
    public record PowerBuilderSettings: JsonRecord
    {
        public PowerBuilderSettings()
        {
            FormatName = "AB PowerBuilder Setttings";
            FormatDescription = "Basic AB PowerBulder Settings";
            FormatAuthor = "Albert M. Byrd";
        }

        public bool HideStatusBar { get; init; }
        public WindowState WindowState { get; init; }
        public PowerBuilderState State { get; init; }    
    }
}
