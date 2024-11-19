using ReactiveUI;

namespace FluentThemeApp.ViewModels;

public class MainViewModel : ReactiveObject
{
    public NotepadViewModel Notepad { get; }
    public ImageViewerViewModel ImageViewer { get; }

    public MainViewModel()
    {
        Notepad = new();
        ImageViewer = new();
    }
}
