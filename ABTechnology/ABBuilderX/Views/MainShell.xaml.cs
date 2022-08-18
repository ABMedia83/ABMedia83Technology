

namespace Views;

/// <summary>
/// Interaction logic for MainShell.xaml
/// </summary>
public partial class MainShell : XShell
{


    BuilderXState state;

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

        //On Log Lamba 
        Builder.OnLog += (str) =>
        {
            statusTextBlock.Text = str;

            //Notify and Hide 
            NotifyHide(statusTextBlock, 7);
        };


        Builder.Title = "AB Builder X 1.0";

        


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
                        
                        // Load Image to the Image Viewer 
                        var img = new ImageViewer(Builder.VMTab!, i);
                        break;
                    case ".pdf":
                        
                        //Load PDF to PDF Viewer
                        var pdf = new PDFViewer(Builder!.VMTab!, i);
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


    }
    public override void ExportSettings(string _filePath)
    {
      

   

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

    void New_Click(object sender, RoutedEventArgs e)
    {
        OptionButton? opt = sender as OptionButton;


        switch (opt!.Tag)
        {
            case "Code":

                break;
            case "HtmlBuilder":

                break;
            case "YouTube":
       
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
              
                break;
            case "Media":
                
                break;
            case "Note":
              
                break;
            case "Sketch":
              
                break;
            case "Video":
              
                break;
        }

    }

    public BuilderXState State
    {
        get => state;
        set
        {
            state = value;  

            switch(value)
            {
                case BuilderXState.Code:

                    break;
                case BuilderXState.Media:

                    break;
                case BuilderXState.Note:

                    break;
                case BuilderXState.Sketch:

                    break;
                case BuilderXState.Video:

                    break;
            }
        }
    }




}

public enum BuilderXState
{
    Code,
    Note,
    Media,
    Sketch,
    Video
}