using System.IO;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace FluentThemeApp.ViewModels;

public class ImageViewerViewModel : ReactiveObject
{
    [Reactive] public ImageSource? Image { get; private set; }

    public ICommand OpenCommand { get; }

    public ImageViewerViewModel()
    {
        OpenCommand = ReactiveCommand.Create(Open);
    }

    private void Open()
    {
        var dialog = new OpenFileDialog();
        if (dialog.ShowDialog() == true)
        {
            Image = new BitmapImage(new Uri(dialog.FileName));
        }
    }
}
