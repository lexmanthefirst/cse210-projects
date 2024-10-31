// Derived Swimming Class
public class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000 * 0.62;

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();
}
