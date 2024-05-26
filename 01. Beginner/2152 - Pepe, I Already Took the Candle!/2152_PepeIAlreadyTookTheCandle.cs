using System;

class URI 
{
    static void Main(string[] args) 
    {
        int number = int.Parse(Console.ReadLine());
        int logCount = 0;

        while (logCount < number)
        {
            string[] log = Console.ReadLine().Split(' ');
            (int h, int m, string o) = (int.Parse(log[0]), int.Parse(log[1]), log[2]);

            o = (int.Parse(log[2]) == 0) ? "A porta fechou" : "A porta abriu";

            Console.WriteLine($"{h:D2}:{m:D2} - {o}!");
            logCount++;
        }
    }
}