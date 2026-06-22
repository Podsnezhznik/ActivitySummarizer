using ActivityAnalyzer.Enums;
using System.Globalization;

namespace ActivityAnalyzer.Converters;

public class ImportanceEnumConverter : IValueConverter
{
    private readonly List<string> _displayNames =
    [
        "Очень низкая",
        "Низкая",
        "Средняя",
        "Высокая",
        "Очень высокая"
    ];

    private readonly List<ImportanceEnum> _values =
    [
        ImportanceEnum.VeryLow,
        ImportanceEnum.Low,
        ImportanceEnum.Middle,
        ImportanceEnum.High,
        ImportanceEnum.VeryHigh
    ];

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ImportanceEnum enumValue)
        {
            return enumValue.GetString();
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string selectedDisplayName)
        {
            int index = _displayNames.IndexOf(selectedDisplayName);
            return index >= 0 ? _values[index] : ImportanceEnum.Middle;
        }
        return ImportanceEnum.Middle;
    }
}
