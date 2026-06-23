using ActivityAnalyzer.ViewModel;
using ActivityAnalyzer.Views;
using CommunityToolkit.Maui.Extensions;

namespace ActivityAnalyzer.Pages;

public partial class MainView : ContentView
{
    private MainViewModel viewModel;

    public MainView()
	{
		InitializeComponent();
        CreateViewModelAsync();
    }

    private async void CreateViewModelAsync()
    {
        viewModel = await MainViewModel.CreateViewModelAsync();
        BindingContext = viewModel;
    }   

    private async void AddActivityButton_Clicked(object sender, EventArgs e)
    {
        var popup = new AddActivityPopup();
        var page = Application.Current.MainPage;
        if (page != null)
        {
            await page.ShowPopupAsync(popup);
        }
    }

    private async void DataGrid_ItemSelected(object sender, SelectionChangedEventArgs e)
    {
        var popup = new ShowActivityMessagePopup();
        var page = Application.Current.MainPage;
        if (page != null)
        {
            await page.ShowPopupAsync(popup);
        }
    }
}