using ActivityAnalyzer.Enums;
using ActivityAnalyzer.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActivityAnalyzer.ViewModel;

public class GoalsViewModel : INotifyPropertyChanged
{
    private List<GoalSetting> goalSettingList;
    public List<GoalSetting> GoalSettingList 
    {
        get => goalSettingList;
        set
        {
            goalSettingList = value;
            RaisePropertyChanged();
        }
    }

    public ImportanceEnum[] ImportanceList => Enum.GetValues<ImportanceEnum>();

    public GoalsViewModel()
    {
        GoalSettingList = new GoalSetting().CreateListOfGoalSettings();
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
