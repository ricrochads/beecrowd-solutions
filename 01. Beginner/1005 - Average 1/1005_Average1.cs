using System; 

class URI 
{
    static void Main(string[] args) 
    { 
        double a, b, media;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        media = ((a * 3.5) + (b * 7.5)) / 11;

        Console.WriteLine("MEDIA = " + media.ToString("F5"));
    }
}