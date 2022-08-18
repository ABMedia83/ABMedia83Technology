

namespace Models
{
    /// <summary>
    /// Record is designed to save informatio from the HtmlBuilder
    /// </summary>
    public record HtmlBuilderFormat: JsonRecord
    {
        public HtmlBuilderFormat()
        {
            FormatName = "Html Builder Format";
            FormatDescription = "Designed to save information from the html builder format";
            FormatAuthor = "Albert M. Byrd";
        }


        public ViewModelList<HtmlModel>? HtmlModel { get; init; }


    }
}
