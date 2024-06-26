using System;

class URI
{
    static void Main(string[] args) 
    {
        string input = Console.ReadLine();
        var rods = ProcessFourValues(input);
        string isTriangle = IsTriangle(rods.Item1, rods.Item2, rods.Item3, rods.Item4);
        Console.WriteLine(isTriangle);
    }

    static (int, int, int, int) ProcessFourValues(string input)
    {
        string[] values = input.Split(' ');

        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);
        int c = int.Parse(values[2]);
        int d = int.Parse(values[3]);

        return (a, b, c, d);    
    }

    static string IsTriangle(int a, int b, int c, int d)
    {
        if (IsTrianglePossible(a, b, c) ||
            IsTrianglePossible(a, b, d) ||
            IsTrianglePossible(a, c, d) ||
            IsTrianglePossible(b, c, d))
        {
            return "S";
        }
        return "N";
    }

    static bool IsTrianglePossible(int x, int y, int z)
    {
        return x + y > z && 
               y + z > x && 
               z + x > y;
    } 
}