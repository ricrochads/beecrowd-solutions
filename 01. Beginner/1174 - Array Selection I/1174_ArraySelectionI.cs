using System;

class URI
{
    static void Main(string[] args) 
    {
        float[] a = new float[100];

        for (int i = 0; i < 100; i++)
        {
            float x = float.Parse(Console.ReadLine());

            if (!IsNumberTenOrLess(x))
                continue;
            
            a[i] = x;            
            Console.WriteLine($"A[{i}] = {a[i]:F1}");
        }
    }

    static bool IsNumberTenOrLess(float number)
    {
        return number <= 10;
    }
}