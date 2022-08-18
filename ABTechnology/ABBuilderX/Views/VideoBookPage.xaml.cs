

namespace Views
{
    /// <summary>
    /// This Page is used to work on  Youtube video's and Thumbnails 
    /// </summary>
    public partial class VideoBookPage : XPage
    {
        public VideoBookPage()
        {
            InitializeComponent();
            Init();
        }

        public override void Init()
        {
            base.Init();

            Builder!.VideoTab = videoTabControl;
        }

        public override void ImportSettings(string _filePath)
        {
            if(Exists(_filePath))
            {
                var youtubeFormat = ReadFromJsonFile<YouTubeFormat>(_filePath);

                (youtubeControl.Notes,youtubeControl.Description,youtubeControl.Tags)  = (youtubeFormat.Notes,youtubeFormat.Description,youtubeFormat.Tags);
            }
      
        }

        public override void ExportSettings(string _filePath)
        {
            var youtubeFormat = new YouTubeFormat
            {
                Notes = youtubeControl.Notes,
                Description = youtubeControl.Description,
                Tags = youtubeControl.Tags,
                FontFamily = youtubeControl.YoutubeFontFamily.ToString(),
                FontSize = youtubeControl.YoutubeFontSize

            };

            // Write to a Json File 
            WriteToJsonFile(youtubeFormat, _filePath);
 
        }

    }
}
