

namespace Views
{
    /// <summary>
    /// This Page is used to work on  Youtube video's and Thumbnails 
    /// </summary>
    public partial class VideoBookPage : PowerPage
    {
        public VideoBookPage()
        {
            InitializeComponent();
            Init();
        }

        public override void Init()
        {
            base.Init();

            Builder!.VideoTab = tabvideo;
        }

        public override void ImportSettings(string _filePath)
        {
             if(Exists(_filePath))
            {
                var youtube = ReadFromJsonFile<YouTubeFormat>(_filePath);

                //Pattern Matching 
                (ytControl.Notes,ytControl.Description,ytControl.Tags) = (youtube.Notes,youtube.Description,youtube.Tags);
            }
        }

        public override void ExportSettings(string _filePath)
        {
            var youtube = new YouTubeFormat
            {
                Notes = ytControl.Notes,
                Description = ytControl.Description,
                Tags = ytControl.Tags
            };

            WriteToJsonFile(youtube, _filePath);
        }

    }
}
