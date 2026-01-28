using System;

public static class DateTimes
{
    // creation of DateTime objects
    public static void DateTimeObjects()
    {
        // birthday date (example)
        DateTime geburtstag = new DateTime(1980, 7, 23);

        // meeting date and time
        DateTime meeting = new DateTime(2023, 3, 22, 15, 30, 0);

        // 1 millisecond before year change 2022 -> 2023
        DateTime jahreswechsel = new DateTime(2023, 1, 1).AddMilliseconds(-1);

        Console.WriteLine(geburtstag);
        Console.WriteLine(meeting);
        Console.WriteLine(jahreswechsel);
    }

    // DateTime properties and methods
    public static void DateTimePropertiesAndMethods()
    {
        // current date and time
        Console.WriteLine(DateTime.Now);

        // current date without time (00:00:00)
        Console.WriteLine(DateTime.Today);

        DateTime meeting = new DateTime(2023, 3, 22, 15, 30, 0);

        // day of week of meeting
        Console.WriteLine(meeting.DayOfWeek);

        DateTime geburtstag = new DateTime(1980, 7, 23);

        // short date format
        Console.WriteLine(geburtstag.ToString("dd.MM.yyyy"));
    }
}
