

namespace Controls;

/// <summary>
/// Interaction logic for MediaPlayerControl.xaml
/// </summary>
public partial class MediaPlayerControl : PowerView
{
    public MediaPlayerControl()
    {
        InitializeComponent();
        Init();
       
    }

    public MediaPlayerControl(TabControl _tab, FileInfo _info)
    {
        InitializeComponent();
        Init();
        CreateTab(_info.Name, _tab, Close);
        mediaPlayer.Source = new Uri(_info.FullName);
    }

    void Media_Click(object sender, RoutedEventArgs e)
    {
        PushButton push = (PushButton)sender;

        switch(push.Tag)
        {
            case "FastRewind":
                mediaPlayer.FastRewind();
                break;
            case "Rewind":
                mediaPlayer.Rewind();
                break;
            case "Stop":
                mediaPlayer.Stop();
                break;
            case "Play":
                mediaPlayer.Play();
                break;
            case "Pause":
                mediaPlayer.Pause();
                break;
            case "Forward":
                mediaPlayer.Forward();
                break;
            case "FastForward":
                mediaPlayer.FastRForward();
                break;

        }
    }


}
