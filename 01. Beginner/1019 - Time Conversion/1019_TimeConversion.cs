using System; 

class URI 
{
    static void Main(string[] args) 
    {
        int seconds, minutes, hours;

        seconds = int.Parse(Console.ReadLine());

        hours = seconds / 3600;
        seconds %= 3600;
        minutes = seconds / 60;
        seconds %= 60;
                   
        Console.WriteLine(hours + ":" + minutes + ":" + seconds);
    }
}