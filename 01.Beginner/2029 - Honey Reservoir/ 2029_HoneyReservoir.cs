using System;

class URI 
{
    static void Main(string[] args) 
    {
        const double pi = 3.14;

        while (true)
        {
            try
            {
                double v = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
    
                double radius = d / 2;
                double height = v / (pi * Math.Pow(radius, 2));
                double area = pi * Math.Pow(radius, 2);
    
                Console.WriteLine($"ALTURA = {height:F2}");
                Console.WriteLine($"AREA = {area:F2}");
            }
            catch (Exception)
            {
                break;
            }
        }
    }
}