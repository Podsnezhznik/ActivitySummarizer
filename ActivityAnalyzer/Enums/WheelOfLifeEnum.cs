namespace ActivityAnalyzer.Enums;

public enum WheelOfLifeEnum
{
    Health,
    Career,
    Family,
    Friends,
    Relaxation,
    SelfDevelopment,
    Finance,
    Spirituality
}

public static class PermaEnumExtensions
{
    public static string GetString(this WheelOfLifeEnum perma)
    {
        return perma switch
        {
            WheelOfLifeEnum.Health => "Здоровье",
            WheelOfLifeEnum.Career => "Карьера и работа",
            WheelOfLifeEnum.Family => "Семья",
            WheelOfLifeEnum.Friends => "Друзья и общение",
            WheelOfLifeEnum.Relaxation => "Отдых и развлечения",
            WheelOfLifeEnum.SelfDevelopment => "Саморазвитие",
            WheelOfLifeEnum.Finance => "Финансы",
            WheelOfLifeEnum.Spirituality => "Духовность и смыслы",
            _ => "Ошибка конвертации",
        };
    }
}
