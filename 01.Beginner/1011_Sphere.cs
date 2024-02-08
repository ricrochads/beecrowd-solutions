using System; 

class URI 
{
    static void Main(string[] args) 
    { 
        double r, pi, volume;
        
        pi = 3.14159;
        r = int.Parse(Console.ReadLine());

        volume = (4.0/3) * pi * Math.Pow(r, 3);

        Console.WriteLine("VOLUME = " + volume.ToString("F3"));
    }
}