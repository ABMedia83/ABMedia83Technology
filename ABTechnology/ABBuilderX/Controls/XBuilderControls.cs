
using ABBuilderX;

namespace Controls;

#region  ViewModel Controls 
/// <summary>
/// Interface designed to implment 
/// </summary>
public interface IBuilderXViewModel
{
    public BuilderXViewModel? Builder { get; }
}

/// <summary>
/// Main Shell of Appliction 
/// </summary>
public class XShell : ViewShell, IBuilderXViewModel
{
    public override void Init()
    {
        DataContext = App.BuilderXHost!.Services.GetService<BuilderXViewModel>();
    }

    public BuilderXViewModel? Builder => App.BuilderXHost!.Services.GetRequiredService<BuilderXViewModel>();
}


/// <summary>
/// Default View for this Application
/// </summary>
public class XView : ViewControl, IBuilderXViewModel
{ 
    public override void Init()
    {
        //Set the Default DataContext of the Control
        DataContext = App.BuilderXHost!.Services.GetService<BuilderXViewModel>();
    }

    public override void Close()
    {
        if (CanQucckCloseTab == false)
        {
            //Show Dialog 
            TabDialog.Show("Closing Tab", "Do you want to remove this Tab?", "Close", "Cancel", () =>
            {
                RemoveTab();
            });
        }
        else if(CanQucckCloseTab == true)
        {
            base.Close();
        }
    }

    public bool CanQucckCloseTab { get; set; } = false;

    public BuilderXViewModel? Builder => App.BuilderXHost!.Services!.GetRequiredService<BuilderXViewModel>();
}

/// <summary>
/// Default Frame Page for this Application 
/// </summary>
public class XPage : ViewPage, IBuilderXViewModel
{
    public override void Init()
    {
        DataContext = App.BuilderXHost!.Services.GetService<BuilderXViewModel>();
    }

    public BuilderXViewModel? Builder => App.BuilderXHost!.Services.GetRequiredService<BuilderXViewModel>();
}

#endregion


#region TextEditor Controls 
/// <summary>
/// Default TextEditor of the Applicaton 
/// </summary>
public class XTextEditor : TextEditor, IAddCommand
{

    public XTextEditor()
    {
        //Export Command 
        AddCommand(DesktopCommands.Export, (sender, e) =>
        {
            SaveDialogTask("Expot Text Document", filterAllFiles, (s, i) =>
            {
                WriteAllText(s.FileName, Text);
            });

        });


        //Import Command 
        AddCommand(DesktopCommands.Import, (sender, e) =>
        {
            OpenDialogTask("Import Text Document", filterAllFiles, (o, i) =>
            {
                Text = ReadAllText(o.FileName);
            });
        });


    }




    public void AddCommand(ICommand _command, ExecutedRoutedEventHandler _method)
    {
        CommandBindings.Add(new CommandBinding(_command, _method));
    }
}

public class XWriterBox : WriterBox
{
    public XWriterBox()
    {
        //Export Command 
        AddCommand(DesktopCommands.Export, (sender, e) =>
        {
            SaveDialogTask("Expot Text Document", filterAllFiles, (s, i) =>
            {
                WriteAllText(s.FileName, Text);
            });

        });


        //Import Command 
        AddCommand(DesktopCommands.Import, (sender, e) =>
        {
            OpenDialogTask("Import Text Document", filterAllFiles, (o, i) =>
            {
                Text = ReadAllText(o.FileName);
            });
        });
    }
}


#endregion 

