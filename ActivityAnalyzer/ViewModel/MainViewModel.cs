using ActivityAnalyzer.Enums;
using ActivityAnalyzer.Model;
using ActivityAnalyzer.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActivityAnalyzer.ViewModel;

public class MainViewModel : INotifyPropertyChanged
{
    private MainViewModel()
    {
    }

    public static async Task<MainViewModel> CreateViewModelAsync()
    {
        var viewModel = new MainViewModel();
        await viewModel.InitializeAsync();
        return viewModel;
    }

    private async Task InitializeAsync()
    {
        ActivityList = await ActivityService.GetActivitiesByDate(DateTime.Today);
        DeficitList = await ActivityService.GetDeficitesByDate(DateTime.Today);
    }

    public string CurrentDate => DateTime.Today.ToString("dd.MM.yyyy");

    private List<Activity> activityList;
    public List<Activity> ActivityList
    {
        get => activityList;
        set
        {
            activityList = value;
            RaisePropertyChanged();
        }
    }

    private List<Activity> deficitList;
    public List<Activity> DeficitList
    {
        get => deficitList;
        set
        {
            deficitList = value;
            RaisePropertyChanged();
        }
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
