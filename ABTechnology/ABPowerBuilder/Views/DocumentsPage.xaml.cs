
namespace Views;

/// <summary>
/// Interaction logic for DocumentsPage.xaml
/// </summary>
public partial class DocumentsPage : PowerPage
{
    public DocumentsPage()
    {
        InitializeComponent();
        Init();
    }

    public override void Init()
    {
        base.Init();
        Builder!.VMTab = tabDoc!;
    }
}
