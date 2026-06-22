using ActivityAnalyzer.ViewModel;
using ActivityAnalyzer.Views;
using CommunityToolkit.Maui.Extensions;
using System.Diagnostics;

namespace ActivityAnalyzer;

public partial class MainPage : ContentPage
{
    private MainViewModel viewModel = new();
    public MainPage()
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void AddActivityButton_Clicked(object sender, EventArgs e)
    {
        var popup = new AddActivityPopup();
        await Shell.Current.CurrentPage.ShowPopupAsync(popup);
    }
}