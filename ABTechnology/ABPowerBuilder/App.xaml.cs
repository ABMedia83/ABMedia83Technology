
namespace ABPowerBuilder;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    public static IHost? PowerHost { get; private set; }

    public App()
    {
        //Setup your Depdenciety Injection here 
        PowerHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                //Inject the Main SHell
                services.AddSingleton<MainShell>();
                // Inject the main ViewModel using MVVM Pattern 
                services.AddSingleton<PowerViewModel>();

                //Inject the Default Pages 
                services.AddSingleton<CodeBookPage>();
                services.AddSingleton<MediaBookPage>();
                services.AddSingleton<NotebookPage>();
                services.AddSingleton<SketchBookPage>();
                services.AddSingleton<VideoBookPage>();

            })
        .Build();

    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await PowerHost!.StartAsync();  

        MainShell shell = App.PowerHost.Services.GetRequiredService<MainShell>();
        // Show the Shell Winodw  
        shell.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {

        await PowerHost!.StopAsync();
        base.OnExit(e);
    }


}
