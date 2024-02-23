using System; 

class URI 
{
    static void Main(string[] args) 
    {
        double x, x1, x2, y, y1, y2, distance;

        string[] p1 = Console.ReadLine().Split(' ');
        x1 = double.Parse(p1[0]);
        y1 = double.Parse(p1[1]);

        string[] p2 = Console.ReadLine().Split(' ');
        x2 = double.Parse(p2[0]);
        y2 = double.Parse(p2[1]);

        x = x2 - x1;
        y = y2 - y1;

        distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        Console.WriteLine(distance.ToString("F4"));
    }
}