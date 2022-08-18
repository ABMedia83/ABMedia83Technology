
namespace Views;

/// <summary>
/// Main Shell of the Application AB PowerBuilder 
/// </summary>
public partial class MainShell : PowerShell
{

    PowerBuilderState state;

    public MainShell()
    {
        InitializeComponent();
        Init();
    }
    public override void Init()
    {
        base.Init();
        //Set default frame 
        Builder!.VMFrame = mainFrame;

        Builder.Title = "AB PowerBuilder 1.0";

        State = PowerBuilderState.VideoBook;


        #region Commands 
        //New Command 
        AddCommand(ApplicationCommands.New, (sender, e) =>
        {
            //Quick check on Log Dialog
            if (logDialog.Visibility == Visibility.Visible)
                logDialog.Visibility = Visibility.Collapsed;

            newDialog.Show("New Project", "Select a New Project");
        });
        //LogINfo Command 
        AddCommand(DesktopCommands.LogInfo, (sender, e) =>
        {
            //Quick Check 
            if (newDialog.Visibility == Visibility.Visible) 
                newDialog.Visibility = Visibility.Collapsed;
            

            logDialog.Show("Logs", "VIew Recent Files.");
        });
            

        //Open Command
        AddCommand(ApplicationCommands.Open, (sender, e) =>
        {
            OpenDialogTask("Op,zen a File", filterAllFormats, (o, i) =>
            {
                var extension = i.Extension;

                switch (extension)
                {
                    default:
                        
                        break;
                    case ".png" or ".jpg" or ".jiff" or ".jpeg" or ".tiff" or ".gif":
                        ImageViewer? img = new ImageViewer(Builder.VMTab!, i);
                        State = PowerBuilderState.MediaBook;
                        break;
                    case ".pdf":
                        PDFViewer? pdf = new PDFViewer(Builder.VMTab!, i);
                        State = PowerBuilderState.MediaBook;
                        break;
                }

            });

        });

        //quit Command Closes the Document 
        AddCommand(DesktopCommands.Quit, (sender, e) => Close());
      
        #endregion 

        //Import Settings here 
        ImportSettings(settingsFile);
   

        //Save your settings here
        Closed += (sender, e) =>
        {
            ExportSettings(settingsFile);

        };


    }

    public override void ImportSettings(string _filePath)
    {
        if (Exists(_filePath))
        {
            var settings = ReadFromJsonFile<PowerBuilderSettings>(_filePath);


            (WindowState, State) = (settings.WindowState, settings.State );

            if (settings.HideStatusBar == true)
            {
                mnuHideStatusBar.IsChecked = true;
                statusBar.Visibility = Visibility.Collapsed;
            }
            else if (settings.HideStatusBar == false)
            {
                mnuHideStatusBar.IsChecked = false;
                statusBar.Visibility = Visibility.Visible;
            }

          

        }
        VideoView!.ImportSettings(videoSettings);

    }
    public override void ExportSettings(string _filePath)
    {
        var settings = new PowerBuilderSettings()
        {
            WindowState = WindowState,
            HideStatusBar = mnuHideStatusBar.IsChecked,
            State = State
        };

        WriteToJsonFile(settings, _filePath);

        VideoView!.ExportSettings(videoSettings);

    }

    void mnuHideStatusBar_Click(object sender, RoutedEventArgs e)
    {
        bool hideBool = mnuHideStatusBar!.IsChecked;

        if (hideBool == true)
        {
            statusBar.Visibility = Visibility.Collapsed;
        }
        else if (hideBool == false)
        {
            statusBar.Visibility = Visibility.Visible;
        }

    }

    void Log_Click(object sender, RoutedEventArgs e)
    {
        PushButton? push = sender as PushButton;
    }

    void New_Click(object sender,RoutedEventArgs e)
    {
        OptionButton? opt = sender as OptionButton;


        switch(opt!.Tag)
        {
            case "Code":

                break;
            case "HtmlBuilder":

                break;
            case "YouTube":
                var youtube = new YouTubeControl(Builder!.VideoTab!);
                State = PowerBuilderState.VideoBook;
                break;
        }

        newDialog.Hide();
    }


    void Mode_Click(object sender, RoutedEventArgs e)
    {
        MenuItem? mnu = sender! as MenuItem;

        switch (mnu!.Tag)
        {
            case "Code":
                State = PowerBuilderState.CodeBook;
                break;
            case "Media":
                State = PowerBuilderState.MediaBook;
                break;
            case "Note":
                State = PowerBuilderState.NoteBook;
                break;
            case "Sketch":
                State = PowerBuilderState.SketchBook;
                break;
            case "Video":
                State = PowerBuilderState.VideoBook;
                break;
        }

    }

    public PowerBuilderState State
    {
        get => state;
        set
        {
            state = value;
            switch (value)
            {
                case PowerBuilderState.MediaBook:
                    Builder!.NavigateVMFrame(MediaView!);
                    Builder.Title = "ABPowerBuilder - MediaBook";
                    break;
                case PowerBuilderState.CodeBook:
                    Builder!.NavigateVMFrame(CodeView!);
                    Builder.Title = "ABPowerBuilder - Codebook";
                    break;
                case PowerBuilderState.NoteBook:
                    Builder!.NavigateVMFrame(NoteView!);
                    Builder.Title = "ABPowerBuilder - NoteBook";
                    break;
                case PowerBuilderState.SketchBook:
                    Builder!.NavigateVMFrame(SketchVIew!);
                    Builder.Title = "ABPowerBuilder - SketchBook";
                    break;
                case PowerBuilderState.VideoBook:
                    Builder!.NavigateVMFrame(VideoView!);
                    Builder.Title = "ABPowerBuilder - VideoBook";
                    break;

            }
        }
    }
}

public enum PowerBuilderState
{
    MediaBook, CodeBook, NoteBook, SketchBook, VideoBook
}
