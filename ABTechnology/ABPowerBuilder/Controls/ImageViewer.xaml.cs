

namespace Controls;

/// <summary>
/// Interaction logic for ImageViewer.xaml
/// </summary>
public partial class ImageViewer : PowerView
{
    public ImageViewer(TabControl _tab, FileInfo _info)
    {
        InitializeComponent();
        Init();


        CreateTab(_info.Name, _tab, Close);


        ImageFile(img, _info.FullName, Stretch.Uniform);
    }
}
