using System;

class URI
{
    static void Main(string[] args) 
    {
        int[] n = new int[20];

        for (int i = 0; i < 20; i++)
        {
            int y = int.Parse(Console.ReadLine());
            n[i] = y;
        }
        
        Array.Reverse(n);

        int index = 0;

        Array.ForEach(n, value => {
            Console.WriteLine($"N[{index}] = {value}");
            index++;
        });
    }
}