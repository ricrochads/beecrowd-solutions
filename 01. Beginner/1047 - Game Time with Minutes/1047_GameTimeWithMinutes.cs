using System;

class URI 
{
    static void Main(string[] args) 
    {
        int initialHour, initialMinute, finalHour, finalMinute, durationHour, durationMinute;

        string[] gameTime = Console.ReadLine().Split(' ');

        initialHour = int.Parse(gameTime[0]);
        initialMinute = int.Parse(gameTime[1]);
        finalHour = int.Parse(gameTime[2]);
        finalMinute = int.Parse(gameTime[3]);

        int initialTimeInMinutes = initialHour * 60 + initialMinute;
        int finalTimeInMinutes = finalHour * 60 + finalMinute;

        int durationInMinutes = finalTimeInMinutes - initialTimeInMinutes;
        
        if (initialHour == finalHour && initialMinute == finalMinute)
        {
            Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
        }
        else if (durationInMinutes > 0)
        {
            durationHour = durationInMinutes / 60;
            durationMinute = durationInMinutes % 60;
            Console.WriteLine($"O JOGO DUROU {durationHour} HORA(S) E {durationMinute} MINUTO(S)");
        }
        else
        {
            durationHour = 23 + (durationInMinutes / 60);
            durationMinute = 60 + (durationInMinutes % 60);
            Console.WriteLine($"O JOGO DUROU {durationHour} HORA(S) E {durationMinute} MINUTO(S)");
        }
    }
}