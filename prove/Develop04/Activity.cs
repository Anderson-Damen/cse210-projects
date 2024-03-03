using System;

public class Activity
{
     private string _startMessage;
    private string _endMessage;
    private string _activityName;
    private string _activityDescription;
    private int _timeDuration;

    public Activity (string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcom to the {_activityName} Activity");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
    }

    public void PauseAndShowAnimation()
    {
        
    }
    public void GetAndSetTimeDuration()
    {
        
    }
}