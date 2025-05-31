
using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetTimes;
    private int _bonusPoints;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int targetTimes, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetTimes = targetTimes;
        _bonusPoints = bonusPoints;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _timesCompleted++;
            if (_timesCompleted >= _targetTimes)
            {
                _isComplete = true;
            }
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {Name}: {Description} ({Points} points each, {_bonusPoints} bonus at {_targetTimes}, Completed {_timesCompleted}/{_targetTimes})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{_targetTimes},{_bonusPoints},{_timesCompleted},{_isComplete}";
    }

    public int BonusPoints => _isComplete ? _bonusPoints : 0;
}