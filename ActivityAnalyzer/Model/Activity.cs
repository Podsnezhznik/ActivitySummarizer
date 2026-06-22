using ActivityAnalyzer.Enums;

namespace ActivityAnalyzer.Model;

public class Activity
{
    public WheelOfLifeEnum Name { get; set; }

    public double Hours { get; set; }

    public double Deficit { get; set; }

    public int Satisfaction { get; set; }
}
