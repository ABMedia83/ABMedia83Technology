

namespace Views
{
    /// <summary>
    /// This Page is designed to do my Sketches and COncepts 
    /// </summary>
    public partial class SketchBookPage : XPage 
    {
        public SketchBookPage()
        {
            InitializeComponent();
            Init(); 
        }

        public override void Init()
        {
            base.Init();
            Builder!.SketchTab = sketchTabControl;
        }

    }
}
