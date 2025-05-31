
using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    protected Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected DateTime Date => _date;
    protected int Minutes => _minutes;

    public abstract double GetDistance(); 
    public abstract double GetSpeed(); 
    public abstract double GetPace(); 

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name.Replace("Activity", "")} ({_minutes} min)- " +
               $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}