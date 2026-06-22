using ActivityAnalyzer.Pages;

namespace ActivityAnalyzer;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationContainer();
    }
}