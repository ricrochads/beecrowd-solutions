using System;

class URI 
{
    static void Main(string[] args) 
    {
        string eventDayStart = Console.ReadLine().Split(' ')[1];
        string[] eventTimeStart = Console.ReadLine().Trim().Split(':');
        string eventDayEnd = Console.ReadLine().Split(' ')[1];
        string[] eventTimeEnd = Console.ReadLine().Trim().Split(':');

        DateTime eventDateTimeStart = new DateTime(DateTime.Now.Year, 4, int.Parse(eventDayStart), int.Parse(eventTimeStart[0]), int.Parse(eventTimeStart[1]), int.Parse(eventTimeStart[2]));
        DateTime eventDateTimeEnd = new DateTime(DateTime.Now.Year, 4, int.Parse(eventDayEnd), int.Parse(eventTimeEnd[0]), int.Parse(eventTimeEnd[1]), int.Parse(eventTimeEnd[2]));

        TimeSpan eventDuration = eventDateTimeEnd - eventDateTimeStart;

        Console.WriteLine($"{eventDuration.Days} dia(s)");
        Console.WriteLine($"{eventDuration.Hours} hora(s)");
        Console.WriteLine($"{eventDuration.Minutes} minuto(s)");
        Console.WriteLine($"{eventDuration.Seconds} segundo(s)");
    }
}