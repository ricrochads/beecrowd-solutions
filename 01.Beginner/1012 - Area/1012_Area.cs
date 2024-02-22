using System; 

class URI 
{
    static void Main(string[] args) 
    {
        double a, b, c, triangle, circle, trapezium, square, rectangle;

        string[] values = Console.ReadLine().Split(' ');
        a = double.Parse(values[0]);
        b = double.Parse(values[1]);
        c = double.Parse(values[2]);

        triangle = a * c / 2;
        circle = 3.14159 * c * c;
        trapezium = (a + b) / 2 * c;
        square = b * b;
        rectangle = a * b;

        Console.WriteLine("TRIANGULO: " + triangle.ToString("F3"));
        Console.WriteLine("CIRCULO: " + circle.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + trapezium.ToString("F3"));
        Console.WriteLine("QUADRADO: " + square.ToString("F3"));
        Console.WriteLine("RETANGULO: " + rectangle.ToString("F3"));
    }
}