using ActivityAnalyzer.Enums;
using System.Globalization;

namespace ActivityAnalyzer.Converters;

public class WheelOfLifeEnumConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is WheelOfLifeEnum perma)
        {
            return perma.GetString();
        }

        return "Ошибка конвертации";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
