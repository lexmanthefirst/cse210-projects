using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points)
    {
        _shortName   = name;
        _description = description;
        _points      = points;
        _target      = target;
        _bonus       = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            CongratsMessage(int.Parse(_points), _bonus);
        }
        else
        {
            CongratsMessage(int.Parse(_points), 0);
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        // base.GetDetailsString() returns the default GetDetailsString() value
        // from the Goal base class and then I add the moreDetails string required
        // by the ChecklistGoal class.
        string moreDetails = $" -- Currently completed: {_amountCompleted}/{_target}";
        string detailsString = base.GetDetailsString() + moreDetails;
        return detailsString;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public void SetAmountCompleted(int complete)
    {
        _amountCompleted = complete;
    }
}