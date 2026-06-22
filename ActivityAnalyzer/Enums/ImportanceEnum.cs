namespace ActivityAnalyzer.Enums;

public enum ImportanceEnum
{
    VeryLow = -2,
    Low = -1,
    Middle = 0,
    High = 1,
    VeryHigh = 2
}

public static class ImportanceEnumExtensions
{
    public static string GetString(this ImportanceEnum perma)
    {
        return perma switch
        {
            ImportanceEnum.VeryLow => "Очень низкая",
            ImportanceEnum.Low => "Низкая",
            ImportanceEnum.Middle => "Средняя",
            ImportanceEnum.High => "Высокая",
            ImportanceEnum.VeryHigh => "Очень высокая",
        };
    }
}
