using System; 

class URI 
{
    static void Main(string[] args) 
    { 
        int a, b, c, greatest, greatestAB;

        string[] inputNumbers = Console.ReadLine().Split(' ');
        a = int.Parse(inputNumbers[0]);
        b = int.Parse(inputNumbers[1]);
        c = int.Parse(inputNumbers[2]);

        greatestAB = (a + b + Math.Abs(a - b)) / 2;
        greatest = (greatestAB + c + Math.Abs(greatestAB - c)) / 2;

        Console.WriteLine(greatest + " eh o maior");
    }
}