

namespace Views
{
    /// <summary>
    /// Interaction logic for NotebookPage.xaml
    /// </summary>
    public partial class NotebookPage : XPage
    {
        public NotebookPage()
        {
            InitializeComponent();
            Init();
        }
        public override void Init()
        {
            base.Init(); 

            Builder!.NoteTab = notebookTabControl;

        }
    }
}
