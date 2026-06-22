using ActivityAnalyzer.Enums;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActivityAnalyzer.ViewModel;

public class ActivityPopupViewModel : INotifyPropertyChanged
{
    public WheelOfLifeEnum[] CategoryList => Enum.GetValues<WheelOfLifeEnum>();

    private WheelOfLifeEnum selectedCategory = WheelOfLifeEnum.Health;
    public WheelOfLifeEnum SelectedCategory
    {
        get => selectedCategory;
        set
        {
            selectedCategory = value;
            RaisePropertyChanged();
        }
    }

    public List<int> SatisfactionList => Enumerable.Range(1, 10).ToList();

    private byte satisfaction = 5;

    public byte Satisfaction
    {
        get { return satisfaction; }
        set 
        {
            satisfaction = value;
            RaisePropertyChanged();
        }
    }

    private double hours;

    public double Hours
    {
        get { return hours; }
        set 
        {
            hours = value;
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
