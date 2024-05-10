using System;

class URI 
{
    static void Main(string[] args) 
    {
        string[] values = Console.ReadLine().Split(' ');

        int a = int.Parse(values[0]);

        for (int i = 1; i <= values.Length; i++)
        {
            if (int.Parse(values[i]) > 0)
            {
                values[1] = values[i];
                break;
            }
        }

        int n = int.Parse(values[1]);

        int sum = 0;

        for (int i = 0; i < n; i++)
            sum += a + i;

        Console.WriteLine(sum);
    }
}