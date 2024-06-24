using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using System.Net.Security;

namespace GetStartedApp.Views;

public partial class MainView : UserControl
{ 
    public MainView()
    {
        InitializeComponent();
    }
    //public bool CanResize = false;
    public string HelloText => "Hello world!!!";
    public void NoButtonClicked(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Click!");
    }

    public void YesButtonClicked(object source, RoutedEventArgs args)
    {

    //Debug.WriteLine("Click!");
    }
}
