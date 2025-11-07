using System;
using Avalonia.Controls;
using LibVLCSharp.Shared;

namespace AvaloniaApplication1.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly LibVLC _libVlc = new LibVLC();
        
    public MediaPlayer MediaPlayer { get; }
        
    public MainWindowViewModel()
    {
        MediaPlayer = new MediaPlayer(_libVlc);
        Play();
    }

    public void Play()
    {
        if (Design.IsDesignMode)
        {
            return;
        }
            
        using var media = new Media(_libVlc, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
        MediaPlayer.Play(media);
    }
        
    public void ToggleFullscreen()
    {
        MediaPlayer.ToggleFullscreen();
    }

}