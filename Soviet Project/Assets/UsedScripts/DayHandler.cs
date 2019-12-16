using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public int Day;
    public Text WorkText;
    public Text WeekText;
    public Text DayText;
    public WorkDays daywork;
    public WeekDays dayweek;
    // Start is called before the first frame update
    void Start()
    {
        daywork = WorkDays.Day1;
        dayweek = WeekDays.Monday;
        Day = 1;
    }
    public void ChangeDay()
    {
        ChangeWeek();
        ChangeWork();
        Day += 1;
    }
    // Update is called once per frame
    void Update()
    {
        WorkText.text = "" + daywork;
        WeekText.text = "" + dayweek;
        DayText.text = "Day" + "" + Day;
    }
    private void ChangeWork()
    {
       if (daywork == WorkDays.Day1)
        {
            daywork = WorkDays.Day2;
        }
       else if (daywork == WorkDays.Day2)
        {
            daywork = WorkDays.Day3;
        }
        else if (daywork == WorkDays.Day3)
        {
            daywork = WorkDays.Day4;
        }
        else if (daywork == WorkDays.Day4)
        {
            daywork = WorkDays.BreakDay;
        }
        else if (daywork == WorkDays.BreakDay)
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
        else if (dayweek == WeekDays.Tuesday)
        {
            dayweek = WeekDays.Wednesday;
        }
        else if (dayweek == WeekDays.Wednesday)
        {
            dayweek = WeekDays.Thursday;
        }
        else if (dayweek == WeekDays.Thursday)
        {
            dayweek = WeekDays.Friday;
        }
        else if (dayweek == WeekDays.Friday)
        {
            dayweek = WeekDays.Saturday;
        }
        else if (dayweek == WeekDays.Saturday)
        {
            dayweek = WeekDays.Sunday;
        }
        else if (dayweek == WeekDays.Sunday)
        {
            dayweek = WeekDays.Monday;
        }
    }

}
