using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private readonly int _month;
    private readonly int _year;

    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        DateTime date;

        if (schedule == Schedule.Teenth)
        {
            date = new DateTime(_year, _month, 13);
            while (date.DayOfWeek != dayOfWeek)
                date = date.AddDays(1);

            return date;
        }
        else if (schedule == Schedule.Last)
        {
            int lastDay = DateTime.DaysInMonth(_year, _month);
            date = new DateTime(_year, _month, lastDay);
            while (date.DayOfWeek != dayOfWeek)
                date = date.AddDays(-1);

            return date;
        }
        else
        {
            date = new DateTime(_year, _month, 1);
            while (date.DayOfWeek != dayOfWeek)
                date = date.AddDays(1);

            int offset = schedule switch
            {
                Schedule.First => 0,
                Schedule.Second => 1,
                Schedule.Third => 2,
                Schedule.Fourth => 3,
                _ => throw new ArgumentOutOfRangeException(nameof(schedule))
            };

            return date.AddDays(7 * offset);
        }
    }
}
