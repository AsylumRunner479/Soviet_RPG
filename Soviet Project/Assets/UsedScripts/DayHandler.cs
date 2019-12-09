using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayHandler : MonoBehaviour
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    public enum WorkDays
    {
        Day1,
        Day2,
        Day3,
        Day4,
        BreakDay,
    }
    public WorkDays daywork;
    public WeekDays dayweek;
    // Start is called before the first frame update
    void Start()
    {
        daywork = WorkDays.Day1;
        dayweek = WeekDays.Monday;
    }
    public void ChangeDay()
    {
        ChangeWeek();
        ChangeWork();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void ChangeWork()
    {
       if (daywork == WorkDays.Day1)
        {
            daywork = WorkDays.Day2;
        }
        if (daywork == WorkDays.Day2)
        {
            daywork = WorkDays.Day3;
        }
        if (daywork == WorkDays.Day3)
        {
            daywork = WorkDays.Day4;
        }
        if (daywork == WorkDays.Day4)
        {
            daywork = WorkDays.BreakDay;
        }
        if (daywork == WorkDays.BreakDay)
        {
            daywork = WorkDays.Day1;
        }
    }
    private void ChangeWeek()
    {
        if (dayweek == WeekDays.Monday)
        {
            dayweek = WeekDays.Tuesday;
        }
        if (dayweek == WeekDays.Tuesday)
        {
            dayweek = WeekDays.Wednesday;
        }
        if (dayweek == WeekDays.Wednesday)
        {
            dayweek = WeekDays.Thursday;
        }
        if (dayweek == WeekDays.Thursday)
        {
            dayweek = WeekDays.Friday;
        }
        if (dayweek == WeekDays.Friday)
        {
            dayweek = WeekDays.Saturday;
        }
        if (dayweek == WeekDays.Saturday)
        {
            dayweek = WeekDays.Sunday;
        }
        if (dayweek == WeekDays.Sunday)
        {
            dayweek = WeekDays.Monday;
        }
    }

}
