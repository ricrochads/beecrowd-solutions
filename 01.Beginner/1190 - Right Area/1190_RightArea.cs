using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string operation = Console.ReadLine().ToUpper();

        int count = 0;
        double sum = 0;
        double[,] m = new double[12, 12];

        for (int r = 0; r < 12; r++)
        {
            for (int c = 0; c < 12; c++)
            {
                m[r, c] = double.Parse(Console.ReadLine());

                if (c > r && c + r > 11)
                {
                    sum += m[r, c];
                    count++;
                }
            }
        }

        switch (operation)
        {
            case "S":
                Console.WriteLine($"{sum:F1}");
                break;
            case "N":
                double average = sum / count;
                Console.WriteLine($"{average:F1}");
                break;
            default:
                break;
        }
    }
}