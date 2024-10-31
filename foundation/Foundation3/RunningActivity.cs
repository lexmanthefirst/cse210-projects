// Derived Running Class
public class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / Minutes) * 60;

    public override double GetPace() => Minutes / distance;
}
