using Microsoft.UI.Xaml;

namespace HelloXaml;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RecordButton_Click(object sender, RoutedEventArgs e)
    {
        recordTextBlock.Text = "Recording...";
    }
}
