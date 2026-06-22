using ActivityAnalyzer.Enums;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActivityAnalyzer.Model;

public class GoalSetting : INotifyPropertyChanged
{
    private double _targetHours;
    private double _importance;
    private ImportanceEnum _personalGoals = ImportanceEnum.Middle;

    public WheelOfLifeEnum Category { get; set; }

    public double TargetHours
    {
        get => _targetHours;
        set
        {
            if (_targetHours != value)
            {
                _targetHours = value;
                OnPropertyChanged();
            }
        }
    }

    public double Importance
    {
        get => _importance;
        set
        {
            if (_importance != value)
            {
                _importance = value;
                OnPropertyChanged();
            }
        }
    }

    public ImportanceEnum PersonalGoals
    {
        get => _personalGoals;
        set
        {
            if (_personalGoals != value)
            {
                _personalGoals = value;
                OnPropertyChanged();
            }
        }
    }

    public List<GoalSetting> CreateListOfGoalSettings()
    {
        var resultList = new List<GoalSetting>();
        foreach (var category in Enum.GetValues<WheelOfLifeEnum>())
        {
            if (category == WheelOfLifeEnum.Health)
                resultList.Add(new GoalSetting { Category = category, Importance = 3, PersonalGoals = ImportanceEnum.VeryHigh, TargetHours = 4 });
            else if (category == WheelOfLifeEnum.Career)
                resultList.Add(new GoalSetting { Category = category, Importance = 2, PersonalGoals = ImportanceEnum.High, TargetHours = 40 });
            else
                resultList.Add(new GoalSetting { Category = category });
        }

        return resultList;
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    #endregion
}
