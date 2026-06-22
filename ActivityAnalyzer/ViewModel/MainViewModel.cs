using ActivityAnalyzer.Enums;
using ActivityAnalyzer.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActivityAnalyzer.ViewModel;

public class MainViewModel : INotifyPropertyChanged
{
    public MainViewModel()
    {
    }

    public string CurrentDate => (new DateTime(2026, 6, 15)).ToString("dd.MM.yyyy");

    public List<Activity> ActivityList => [
        new Activity { Name = WheelOfLifeEnum.Health, Hours = 0.25, Satisfaction = 7}, 
        new Activity { Name = WheelOfLifeEnum.Career, Hours = 8, Satisfaction = 6},
        new Activity { Name = WheelOfLifeEnum.Friends, Hours = 0.5, Satisfaction = 9},
        new Activity { Name = WheelOfLifeEnum.Relaxation, Hours = 1.5, Satisfaction = 8},
        new Activity { Name = WheelOfLifeEnum.SelfDevelopment, Hours = 0.5, Satisfaction = 7},
        new Activity { Name = WheelOfLifeEnum.Family, Hours = 1, Satisfaction = 10},
    ];

    public List<Activity> DeficitList => [
        new Activity { Name = WheelOfLifeEnum.Health, Deficit = 0.32}, 
        new Activity { Name = WheelOfLifeEnum.Family, Deficit = 0.43},
        new Activity { Name = WheelOfLifeEnum.Friends, Deficit = 0.21},
        new Activity { Name = WheelOfLifeEnum.SelfDevelopment, Deficit = 0.21},
        new Activity { Name = WheelOfLifeEnum.Finance, Deficit = 0.29},
        new Activity { Name = WheelOfLifeEnum.Spirituality, Deficit = 0.29},
        ];


    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
