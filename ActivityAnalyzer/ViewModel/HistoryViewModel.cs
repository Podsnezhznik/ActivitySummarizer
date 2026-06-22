using ActivityAnalyzer.Enums;
using ActivityAnalyzer.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActivityAnalyzer.ViewModel;

public class HistoryViewModel : INotifyPropertyChanged
{
	private DateTime selectedDate = DateTime.Today;

	public DateTime SelectedDate
    {
		get { return selectedDate; }
		set 
		{
			selectedDate = value;
            RaisePropertyChanged();
		}
	}

    public List<Activity> ActivityList => [new Activity { Name = WheelOfLifeEnum.Health, Hours = 3 }, new Activity { Name = WheelOfLifeEnum.Finance, Hours = 1.5 },
        new Activity { Name = WheelOfLifeEnum.Family, Hours = 1.5}, new Activity { Name = WheelOfLifeEnum.Career, Hours = 8}];

    public double AverageSatisfaction { get; set; } = 7.5;

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
