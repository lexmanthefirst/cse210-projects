using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base (name, description, points)
    {
        _shortName   = name;
        _description = description;
        _points      = points;
        _isComplete  = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        CongratsMessage(int.Parse(_points), 0);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

    public void SetIsComplete(string complete)
    {
        if (complete == "True")
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
    }
}