using System;

class URI 
{
    static void Main(string[] args) 
    {
        string[] hp = Console.ReadLine().Split(' ');
        var (h, p) = (float.Parse(hp[0]), float.Parse(hp[1]));

        float avgHotDogsPerParticipant = h / p;

        Console.WriteLine($"{avgHotDogsPerParticipant:F2}");
    }
}