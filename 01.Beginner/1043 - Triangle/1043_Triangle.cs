using System;

class URI 
{
    static void Main(string[] args) 
    {
        float a, b, c, trianglePerimeter, trapeziumArea;

        string[] numbers = Console.ReadLine().Split(' ');

        a = float.Parse(numbers[0]);
        b = float.Parse(numbers[1]);
        c = float.Parse(numbers[2]);

        if (a + b > c && a + c > b && c + b > a)
        {
            trianglePerimeter = a + b + c;
            Console.WriteLine($"Perimetro = {trianglePerimeter:F1}");
        }
        else
        {
            trapeziumArea = (a + b) * c / 2;
            Console.WriteLine($"Area = {trapeziumArea:F1}");
        }
    }
}