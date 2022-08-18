
namespace ABPowerBuilder;

/// <summary>
/// The ViewModel that runs AB PowerBuilder 
/// </summary>
public class PowerViewModel: ViewModel
{

    #region Tabs 

    public TabControl? CodeTab { get; set; }
    public TabControl? NoteTab { get; set; }
    public TabControl? SketchTab { get; set; }
    public TabControl? VideoTab { get; set; }



    #endregion


    #region PreMade Lists 




    /// <summary>
    /// Prest FontFamiles to use in Application 
    /// </summary>
    public ViewModelList<FontItem> NoteFontPresets => new ViewModelList<FontItem>
    {
        new("Calibri"),
        new("Courier New"),
        new("Consolas"),
        new("DejaVu Serif"),
        new("Georgia"),
        new("Segoe Print"),
        new("Segoe UI")

    };




    public ViewModelList<FontItem> WriterFontPrests => new()
    {
        new("Arial"),
        new("Calibri"),
        new("DejaVu Serif"),
        new("Georgia"),
        new("Segoe Print"),
        new("Segoe UI")
    };

    public ViewModelList<FontItem> CodeFontPrests => new()
    {
        new("Consolas"),
        new("Courier New"),
         new("Segoe Print")
    };
    /// <summary>
    /// Preset DrawCanvas Colors 
    /// </summary>
    public ViewModelList<InkItem> PresetDrawCanvasList => new()
    {
        new("ChaulkBoard", HexColor("#ffffff"), HexColor("#FF046318")),
        new("BlackBoard", HexColor("#ffffff"), HexColor("#FF232323")),
        new("BlueBoard", HexColor("#ffffff"), HexColor("#FF161479")),
        new("WhiteBoard", HexColor("#0000000"), HexColor("#FFA7A7A7")),
        new("WhiteBoardBlue", HexColor("#FF161479"), HexColor("#FFA7A7A7"))

    };
    /// <summary>
    /// Preset DrawCanvas Formats 
    /// </summary>
    public ViewModelList<FormatItem> PresetFormats => new()
    {
        new("HD Standard", 1920, 1080),
        new("HD Square", 1080, 1080),
        new("Character Sheet", 1080, 1440),
        new("Comic Strip", 1274,1966),
        new("Screen", 1365, 768),
        new("720p", 1240, 768),
        new("Medium Square", 504, 504),
        new("Small Square", 300, 300),
        new("Small Square", 100, 100)
    };



    public ViewModelList<BrushItem> PresetBackgroundBrushes => new()
    {
        new("Accent", (SolidColorBrush)App.Current.Resources["abAccent"]),
        new("Accent2", (SolidColorBrush)App.Current.Resources["abAccent2"]),
        new("Accent3", (SolidColorBrush)App.Current.Resources["abAccent3"]),
        new("LightBlue", (SolidColorBrush)App.Current.Resources["abAccent4"]),
        new("LihtBlue2", (SolidColorBrush)App.Current.Resources["abAccent5"]),
        new("ChaulkBoard", (SolidColorBrush)App.Current.Resources["abChulkBoard"]),
        new("BlackBoard", (SolidColorBrush)App.Current.Resources["abBlackBoard"]),
        new("BlueBoard", (SolidColorBrush)App.Current.Resources["abBlueBoard"]),
        new("RadialChrome", (RadialGradientBrush)App.Current.Resources["abRadialChrome"]),
        new("RadialChrome2", (RadialGradientBrush)App.Current.Resources["abRadialChrome2"]),
        new("RadialChrome3", (RadialGradientBrush)App.Current.Resources["abRadialChrome3"]),
        new("RadialChrome4", (RadialGradientBrush)App.Current.Resources["abRadialChrome4"]),
        new("RadialChromeRed", (RadialGradientBrush)App.Current.Resources["abRadialChromeRed"]),
        new("RadialChromeGreen", (RadialGradientBrush)App.Current.Resources["abRadialChromeGreen"]),
    };



    #endregion


    #region Dynamic List 

    /// <summary>
    /// Get or set the list of Colors saved from the Color Mixer 
    /// </summary>
    public ViewModelList<ColorItem> Colors { get; set; } = new ViewModelList<ColorItem>();
    /// <summary>
    /// Get or set the List of Themes you have created 
    /// </summary>
    public ViewModelList<ThemeItem> Themes { get; set; } = new ViewModelList<ThemeItem>();



    #endregion


    #region Filters 
    /// <summary>
    /// Get a simple All Files Filter 
    /// </summary>
    public static string filterAllFiles => "All Files(.)|*.*";
    /// <summary>
    /// Get a advance All Files Filter with Category's to select
    /// </summary>
    public static string filterAllFormats => "All Fomrats(.)|*.*|AB Files(.absketch,.abcode,.abenote,.abtube)|*.abnote;*.absketch;*abcode;*.abtube|Code Files(.json,.abjson,.html,.htm,.css,.js,.scss,.ts,.php,.cs,.py,.cpp,.h,.cshtml,.razor)|*.html;*.htm;*.css;*.scss;*.js;*.ts;*.php;*.cpp;*.h;*.cs;*.py;*.cshtml;*.json;*.abjson|Image Files(.png,.jpg,.jpeg,.jiff,.tiff,.gif)|*.png;*.jpg;*.jpeg;*.jiff;*.tiff;*.gif; | PDF Format(.pdf) | *.pdf|Video FOrmat(.mp4)|*.mp4";
    /// <summary>
    /// Get Filter for exporting Images 
    /// </summary>
    public static string filterImages => "All Image(.png,.jpeg,.jpg,.jiff,.tiff,.gif) | *.png;*.jpg;*.jpeg;*.jiff;*.tiff;*.gif|Png Format(.png)|*.png| Jpeg Format(.jpg,.jpeg,.jiff)|*.jpg;*.jpeg;*.jiff|Tiff Format(.tiff)|*.tiff|Gif Format (.gif)|*.gif";
    
    /// <summary>
    /// Gets a PDF Filter for reading PDF FIles
    /// </summary>
    public static string filterPDF => "PDF Format(.pdf) | *.pdf";
    /// <summary>
    /// Get's a Filter for reading Video 
    /// </summary>
    public static string filterVideo => "Video Format(.mp4)|*.mp4";

    #endregion 


    #region Settings Strings 


    public static string settingsFile => "setttings.json";
    public static string codeSettings = "code.json";
    public static string noteSettings = "note.json";
    public static string sketchsettings = "sketch.json";
    public static string videoSettings => "video.json";


    #endregion

    #region Page's 

    public static CodeBookPage? CodeView { get; set; } = App.PowerHost!.Services.GetService<CodeBookPage>();
    public static NotebookPage? NoteView { get; set; } = App.PowerHost.Services.GetService<NotebookPage>();
    public static SketchBookPage? SketchVIew { get; set; } = App.PowerHost.Services.GetService<SketchBookPage>();
    public static MediaBookPage? MediaView { get; set; } = App.PowerHost.Services.GetService<MediaBookPage>();
    public static VideoBookPage? VideoView { get; set; } = App.PowerHost.Services.GetService<VideoBookPage>();

    #endregion


}
