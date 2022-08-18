

namespace Controls;

/// <summary>
/// Interaction logic for UserControl1.xaml
/// </summary>
public partial class CodeControl : XView
{
    public CodeControl()
    {
        InitializeComponent();
        Init();

    }


    public CodeControl(TabControl _tab)
    {
        InitializeComponent();
        Init();
        CreateTab($"CodeDocument{Count++}",_tab,Close);

    }

    public CodeControl(TabControl _tab, FileInfo _info)
    {
        InitializeComponent();
        Init();

        CreateTab(_info.Name, _tab, Close);

    }

    public override void Init()
    {
        base.Init();


    }



}
