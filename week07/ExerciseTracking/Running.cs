using System;

public class Running : Activity
{
    private double _distance; // in miles or kilometers

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();

    public override string GetSummary()
    {
        return $"{Date} Running ({Minutes} min) - Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
