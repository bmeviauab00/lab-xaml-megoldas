using HelloXaml.Models;

using Microsoft.UI.Xaml;

namespace HelloXaml;

public sealed partial class MainWindow : Window
{
    public Person NewPerson { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        NewPerson = new Person()
        {
            Name = "Eric Cartman",
            Age = 8
        };

        rootGrid.DataContext = NewPerson;
    }
}
