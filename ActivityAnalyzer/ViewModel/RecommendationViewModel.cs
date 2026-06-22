using ActivityAnalyzer.Enums;
using ActivityAnalyzer.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActivityAnalyzer.ViewModel;

public class RecommendationViewModel : INotifyPropertyChanged
{
    private List<Recommendation> recommendationList = new() { 
        new Recommendation { Category = WheelOfLifeEnum.Health, Importance = ImportanceEnum.High, TimeSpent = new TimeSpan(0, 30, 0) },
        new Recommendation { Category = WheelOfLifeEnum.Family, Importance = ImportanceEnum.VeryHigh, TimeSpent = new TimeSpan(1, 0, 0) },
        new Recommendation { Category = WheelOfLifeEnum.Finance, Importance = ImportanceEnum.Middle, TimeSpent = new TimeSpan(0, 30, 0) },
        new Recommendation { Category = WheelOfLifeEnum.Friends, Importance = ImportanceEnum.Middle, TimeSpent = new TimeSpan(0, 15, 0) },
        new Recommendation { Category = WheelOfLifeEnum.Spirituality, Importance = ImportanceEnum.VeryLow, TimeSpent = new TimeSpan(0, 15, 0) },
    };

    public List<Recommendation> RecommendationList
    {
        get { return recommendationList; }
        set 
        {
            recommendationList = value;
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
