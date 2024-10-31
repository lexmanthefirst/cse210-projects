// Derived Cycling Class
public class CyclingActivity : Activity
{
    private double speed;

    public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * Minutes) / 60;

    public override double GetSpeed() => speed;

    public override double GetPace() => 60 / speed;
}
