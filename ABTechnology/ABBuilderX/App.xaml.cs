using Views;



namespace ABBuilderX;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{


    public static IHost? BuilderXHost { get; private set; }

    public App()
    {
        //Setup your Depdenciety Injection here 
        BuilderXHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                //Inject the Main SHell
                services.AddSingleton<MainShell>();
                
                // Inject the main ViewModel using MVVM Pattern 
                services.AddSingleton<BuilderXViewModel>();

                //Inject Page's
                services.AddSingleton<CodeBookPage>();
                services.AddSingleton<NotebookPage>();
                services.AddSingleton<MediaBookPage>();
                services.AddSingleton<SketchBookPage>();
                services.AddSingleton<VideoBookPage>();

            })
        .Build();

    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await BuilderXHost!.StartAsync();

        //Create the Main Shell
        MainShell shell = App.BuilderXHost.Services.GetRequiredService<MainShell>();
        
        // Show the Shell Winodw  
        shell.Show();

        base.OnStartup(e);
    }
    protected override async void OnExit(ExitEventArgs e)
    {
        await BuilderXHost!.StopAsync();
        base.OnExit(e);
    }

}
