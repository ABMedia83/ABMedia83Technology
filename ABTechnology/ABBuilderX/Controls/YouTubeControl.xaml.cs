

namespace Controls
{
    /// <summary>
    /// Interaction logic for YouTubeControl.xaml
    /// </summary>
    public partial class YouTubeControl : XView
    {
        /// <summary>
        /// Constructor for Set Control
        /// </summary>
        public YouTubeControl()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// Constructor for New Document
        /// </summary>
        /// <param name="_tab"></param>
        public YouTubeControl(TabControl _tab)
        {
            InitializeComponent();
            Init();
            CreateTab($"YoutubeProject{Count++}", _tab, Close);

            //Load some seettings 
     
            var settings = ReadFromJsonFile<YouTubeFormat>(videoSettings);

            //Load Description and Tags for every new project
            (descriptionText.Text, tagsText.Text) = (settings.Description, settings.Tags);
        }

        /// <summary>
        /// Constructor for Loading a Document 
        /// </summary>
        /// <param name="_tab"></param>
        /// <param name="_info"></param>
        public YouTubeControl(TabControl _tab,FileInfo _info)
        {
            InitializeComponent();
            Init();
            //Create the TabItem
            CreateTab(_info.Name , _tab, Close);
        }


        public override void Init()
        {
            base.Init();

            //fontComboBox Selection Change Lamba 
            fontComboBox.SelectionChanged += (sender, e) =>
            {
                FontItem? item = (FontItem)fontComboBox.SelectedItem;

                notesText.FontFamily = item.FontFamily;
                descriptionText.FontFamily = item.FontFamily;
                tagsText.FontFamily = item.FontFamily;
            };

            //fontSizeSlider Value Change Lamba 
            fontSizeSlider.ValueChanged += (sender, e) =>
            {
                notesText.FontSize = e.NewValue;
                descriptionText.FontSize = e.NewValue;
                tagsText.FontSize = e.NewValue;
            };


      


        }



        public string? Notes
        {
            get => notesText.Text;
            set => notesText.Text = value;

        }

        public string? Description
        {
            get => descriptionText.Text;
            set => descriptionText.Text = value;  
        }

        public string? Tags
        {
            get => tagsText.Text;
            set => tagsText.Text = value;
        }

        public FontFamily YoutubeFontFamily
        {
            get => notesText.FontFamily;
            set => notesText.FontFamily = value;
        }

        public double YoutubeFontSize
        {
            get => notesText.FontSize;
            set => notesText.FontSize = value;
        }


    }
}
