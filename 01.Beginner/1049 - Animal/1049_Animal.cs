using System;

class URI 
{
    static void Main(string[] args) 
    {
        string category = Console.ReadLine().ToLower();
        string group = Console.ReadLine().ToLower();
        string eatingHabit = Console.ReadLine().ToLower();

        string[,] animalData = new string[,]
        {
            { "vertebrado", "ave", "carnivoro", "aguia" },
            { "vertebrado", "ave", "onivoro", "pomba" },
            { "vertebrado", "mamifero", "onivoro", "homem" },
            { "vertebrado", "mamifero", "herbivoro", "vaca" },
            { "invertebrado", "inseto", "hematofago", "pulga" },
            { "invertebrado", "inseto", "herbivoro", "lagarta" },
            { "invertebrado", "anelideo", "hematofago", "sanguessuga" },
            { "invertebrado", "anelideo", "onivoro", "minhoca" }
        };

        for (int i = 0; i < animalData.GetLength(0); i++)
        {
            if (animalData[i, 0] == category && animalData[i, 1] == group && animalData[i, 2] == eatingHabit)
            {
                Console.WriteLine(animalData[i, 3]);
                break;
            }
        }
    }
}