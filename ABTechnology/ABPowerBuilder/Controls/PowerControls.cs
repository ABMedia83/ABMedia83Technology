
namespace Controls;

#region  ViewModel Controls 
/// <summary>
/// Interface designed to implment 
/// </summary>
public interface IPowerViewModel
{
    public PowerViewModel? Builder { get; }
}
/// <summary>
/// Main Shell of Appliction 
/// </summary>
public class PowerShell : ViewShell, IPowerViewModel
{
    public override void Init()
    {
        DataContext = App.PowerHost!.Services.GetService<PowerViewModel>();
    }

    public PowerViewModel? Builder => App.PowerHost!.Services.GetRequiredService<PowerViewModel>();
}


/// <summary>
/// Default View for this Application
/// </summary>
public class PowerView : ViewControl, IPowerViewModel
{ 
    public override void Init()
    {
        //Set the Default DataContext of the Control
        DataContext = App.PowerHost!.Services.GetService<PowerViewModel>();
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

    public PowerViewModel? Builder => App.PowerHost!.Services!.GetRequiredService<PowerViewModel>();
}

/// <summary>
/// Default Frame Page for this Application 
/// </summary>
public class PowerPage : ViewPage, IPowerViewModel
{
    public override void Init()
    {
        DataContext = App.PowerHost!.Services.GetService<PowerViewModel>();
    }

    public PowerViewModel? Builder => App.PowerHost!.Services.GetRequiredService<PowerViewModel>();
}

#endregion


#region TextEditor Controls 

public class PowerTextEditor : TextEditor, IAddCommand
{

    public PowerTextEditor()
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

public class PowerWriterBox : WriterBox
{
    public PowerWriterBox()
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

