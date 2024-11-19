using System.IO;
using System.Windows.Input;
using Microsoft.Win32;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace FluentThemeApp.ViewModels;

public class NotepadViewModel : ReactiveObject
{
    [Reactive] public string? Text { get; set; }

    public ICommand OpenCommand { get; }

    public NotepadViewModel()
    {
        OpenCommand = ReactiveCommand.Create(Open);
    }

    private void Open()
    {
        var dialog = new OpenFileDialog();
        if (dialog.ShowDialog() == true)
        {
            Text = File.ReadAllText(dialog.FileName);
        }
    }
}
