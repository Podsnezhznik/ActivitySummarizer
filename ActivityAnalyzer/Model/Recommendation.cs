using ActivityAnalyzer.Enums;

namespace ActivityAnalyzer.Model;

public class Recommendation
{
    public WheelOfLifeEnum Category { get; set; }

    public ImportanceEnum Importance { get; set; }

    public TimeSpan TimeSpent { get; set; }

    public string TimeSpentString => GetCorrectTimePhrase(TimeSpent);

    private string GetCorrectTimePhrase(TimeSpan time)
    {
        var hoursPhrase = time.Hours switch
        {
            1 => "час",
            2 => "часа",
            3 => "часа",
            4 => "часа",
            _ => "часов"
        };

        var minutesPhrase = time.Minutes switch
        {
            1 => "минута",
            2 => "минуты",
            3 => "минуты",
            4 => "минуты",
            _ => "минут"
        };

        var finalPhrase = (time.Hours == 0 ? string.Empty : $"{time.Hours} {hoursPhrase}")
            + (time.Minutes == 0 ? string.Empty : $"{time.Minutes} {minutesPhrase}");
        return finalPhrase;
    }
}
