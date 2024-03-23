using System;

class URI 
{
    static void Main(string[] args) 
    {
        int initialHour, finalHour, duration;

        string[] hours = Console.ReadLine().Split(' ');

        initialHour = int.Parse(hours[0]);
        finalHour = int.Parse(hours[1]);

        if (initialHour < finalHour)
            duration = finalHour - initialHour;
        else
            duration = 24 - initialHour + finalHour;

        Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
    }
}