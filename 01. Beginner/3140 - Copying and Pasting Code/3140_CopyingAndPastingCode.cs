using System;

class URI 
{
    static void Main(string[] args) 
    {
        bool insideBody = false;

        while (true)
        {
            string line = Console.ReadLine();

            if (line == null) break;

            if (line.Contains("<body>"))
            {
                insideBody = true;
                continue;
            }

            if (insideBody && line.Contains("</body>"))
                insideBody = false;

            if (insideBody)
                Console.WriteLine(line);
        }
    }
}