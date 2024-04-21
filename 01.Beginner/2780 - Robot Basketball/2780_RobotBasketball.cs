using System;

class URI 
{
    static void Main(string[] args) 
    {
        int d = int.Parse(Console.ReadLine());
        int points = 0;

        if (d <= 800)
            points += 1;
        else if (d <= 1400)
            points += 2;
        else
            points += 3;

        Console.WriteLine(points);
    }
}