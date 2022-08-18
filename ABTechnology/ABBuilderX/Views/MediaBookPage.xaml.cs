

namespace Views
{
    /// <summary>
    /// This page is used to display media like Images and video's 
    /// </summary>
    public partial class MediaBookPage : XPage
    {
        public MediaBookPage()
        {
            InitializeComponent();
            Init();
        }

        public override void Init()
        {
            base.Init();
            Builder!.VMTab = mediaTabControl;

        }





    }
}
