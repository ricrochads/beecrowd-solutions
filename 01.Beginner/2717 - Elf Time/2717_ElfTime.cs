using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        int[] minutes = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int a = minutes[0];
        int b = minutes[1];

        int totalTime = a + b;

        if (totalTime <= n)
            Console.WriteLine("Farei hoje!");
        else
            Console.WriteLine("Deixa para amanha!");
    }
}