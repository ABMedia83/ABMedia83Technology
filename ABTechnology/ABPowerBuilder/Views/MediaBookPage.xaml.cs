

namespace Views
{
    /// <summary>
    /// This page is used to display media like Images and video's 
    /// </summary>
    public partial class MediaBookPage : PowerPage
    {
        public MediaBookPage()
        {
            InitializeComponent();
            Init();
        }

        public override void Init()
        {
            base.Init();
            Builder.VMTab = tabMedia;

        }





    }
}
