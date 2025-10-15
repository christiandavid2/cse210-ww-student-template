using System;

public class Cycling : Activity
{
    private double _speed; // mph or kph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;
    public override double GetDistance() => (GetSpeed() * Minutes) / 60;
    public override double GetPace() => 60 / GetSpeed();

    public override string GetSummary()
    {
        return $"{Date} Cycling ({Minutes} min) - Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
