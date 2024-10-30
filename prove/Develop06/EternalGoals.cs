using System.ComponentModel;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base (name, description, points)
    {
        _shortName   = name;
        _description = description;
        _points      = points;
    }

    public override void RecordEvent()
    {
        CongratsMessage(int.Parse(_points), 0);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}