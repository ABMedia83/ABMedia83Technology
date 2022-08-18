

namespace Controls;

/// <summary>
/// Interaction logic for PDFViewer.xaml
/// </summary>
public partial class PDFViewer : PowerView
{
    public PDFViewer(TabControl _tab, FileInfo _info)
    {
        InitializeComponent();
        Init();

        CreateTab(_info.Name, _tab, Close);

        //Load PDF into the WebView
        webView.Source = new Uri(_info.FullName);



    }
    public override void Init()
    {
        base.Init();
     
    }

    void open_Click(object sender, RoutedEventArgs e)
    {
        OpenDialogTask("Open PDF", filterPDF, (o, i) =>
        {
            //Load PDF into the WebView
            webView.Source = new Uri(o.FileName);
        });
    }
}