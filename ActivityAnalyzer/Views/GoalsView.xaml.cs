using ActivityAnalyzer.Enums;
using ActivityAnalyzer.ViewModel;

namespace ActivityAnalyzer.Pages;

public partial class GoalsView : ContentView
{
    GoalsViewModel viewModel = new();
    public GoalsView()
	{
		InitializeComponent();
        BindingContext = viewModel;
	}
}