using System;

class URI 
{
    static void Main(string[] args) 
    {
        double a, b, c;

        string[] triangleSides = Console.ReadLine().Split(' ');
        double[] sides = Array.ConvertAll(triangleSides, double.Parse);
        
        Array.Sort(sides);
        Array.Reverse(sides);

        a = sides[0];
        b = sides[1];
        c = sides[2];

        if (a >= b + c) 
            Console.WriteLine("NAO FORMA TRIANGULO");
        else if (a * a == b * b + c * c)
            Console.WriteLine("TRIANGULO RETANGULO");
        else if (a * a > b * b + c * c)
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        else if (a * a < b * b + c * c)
            Console.WriteLine("TRIANGULO ACUTANGULO");
        
        if (a == b && b == c)
            Console.WriteLine("TRIANGULO EQUILATERO");
        else if (a == b || b == c || c == a)
            Console.WriteLine("TRIANGULO ISOSCELES"); 
    }
}