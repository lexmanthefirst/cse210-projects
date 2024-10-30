using System.Security.Cryptography;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score, _cnt, _bonusValue, _ninjaLevel = 0, _remaining = 0;
    private string _response, _goalResponse, _shortName, _description, _points;
    private const int _ninjaGoal1 = 1000, _ninjaGoal2 = 2000, _ninjaGoal3 = 3000, _ninjaGoal4 = 4000;
    private SimpleGoal _simple;
    private EternalGoal _eternal;
    private ChecklistGoal _check;

    public GoalManager() => _score = 0;

    public void Start()
    {
        while (_response != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            _response = Console.ReadLine();

            switch (_response)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\n*** You have {_score} points ***");
        if (_score < _ninjaGoal1) NinjaMessage(_ninjaGoal1 - _score, 0);
        else if (_score < _ninjaGoal2) NinjaMessage(_ninjaGoal2 - _score, 1);
        else if (_score < _ninjaGoal3) NinjaMessage(_ninjaGoal3 - _score, 2);
        else if (_score < _ninjaGoal4) NinjaMessage(_ninjaGoal4 - _score, 3);
        else NinjaMessage(0, 4);
    }

    private void NinjaMessage(int remainder, int level)
    {
        _remaining = remainder;
        _ninjaLevel = level;
        int next = level + 1;
        string string1 = $"!!! You are a Ninja Goal Warrior Level {_ninjaLevel} !!!";
        string string2 = $"*** You have {_remaining} points left until you are Ninja Goal Warrior Level {next} ***\n";

        Console.WriteLine(_ninjaLevel == 0 ? string2 : $"{string1}\n{string2}");
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?: ");
        _goalResponse = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Console.ReadLine();

        switch (_goalResponse)
        {
            case "1":
                _simple = new SimpleGoal(_shortName, _description, _points);
                _goals.Add(_simple);
                break;
            case "2":
                _eternal = new EternalGoal(_shortName, _description, _points);
                _goals.Add(_eternal);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                _cnt = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                _bonusValue = int.Parse(Console.ReadLine());
                _check = new ChecklistGoal(_shortName, _description, _points, _cnt, _bonusValue);
                _goals.Add(_check);
                break;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
                outputFile.WriteLine(g.GetStringRepresentation());
        }
    }

    public void LoadGoals()
    {
        _goals = new List<Goal>();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string[] fields = parts[1].Split(",");

            switch (goalType)
            {
                case "SimpleGoal":
                    _simple = new SimpleGoal(fields[0], fields[1], fields[2]);
                    _simple.SetIsComplete(fields[3]);
                    _goals.Add(_simple);
                    break;
                case "EternalGoal":
                    _eternal = new EternalGoal(fields[0], fields[1], fields[2]);
                    _goals.Add(_eternal);
                    break;
                case "ChecklistGoal":
                    _check = new ChecklistGoal(fields[0], fields[1], fields[2], int.Parse(fields[4]), int.Parse(fields[5]));
                    _check.SetAmountCompleted(int.Parse(fields[3]));
                    _goals.Add(_check);
                    break;
            }
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish: ");
        int goalNumber = int.Parse(Console.ReadLine());
        _goals[goalNumber - 1].RecordEvent();
        _score += _goals[goalNumber - 1].GetPoints();
    }
}