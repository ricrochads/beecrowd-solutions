using System;

class URI 
{
    static void Main(string[] args) 
    {
        char operation = char.Parse(Console.ReadLine());
        operation = char.ToUpper(operation);

        double[,] m = new double[12, 12];
        
        for (int r = 0; r < 12; r++)
        {
            for (int c = 0; c < 12; c++)
            {
                m[r, c] = double.Parse(Console.ReadLine());
            }
        }
        
        double result = 0;
        int count = 0;

        switch (operation)
        {
            case 'S':
                for (int r = 7; r <= 11; r++)
                {
                    for (int c = 12 - r; c < r; c++)
                        result += m[r, c];
                }
                Console.WriteLine($"{result:F1}");
                break;
            case 'M':
                for (int r = 7; r <= 11; r++)
                {
                    for (int c = 12 - r; c < r; c++)
                    {
                        result += m[r, c];
                        count++;
                    }
                }
                result /= count;
                Console.WriteLine($"{result:F1}");
                break;
        }
    }
}