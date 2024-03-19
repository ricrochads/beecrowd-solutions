using System; 

class URI 
{
    static void Main(string[] args) 
    {
        string[] inputGrades = Console.ReadLine().Split(' ');

        double n1 = double.Parse(inputGrades[0]);
        double n2 = double.Parse(inputGrades[1]);
        double n3 = double.Parse(inputGrades[2]);
        double n4 = double.Parse(inputGrades[3]);

        double weight1 = 2.0;
        double weight2 = 3.0;
        double weight3 = 4.0;
        double weight4 = 1.0;

        double weightedSum = n1 * weight1 + n2 * weight2 + n3 * weight3 + n4 * weight4;
        double totalWeight = weight1 + weight2 + weight3 + weight4;
        double average = weightedSum / totalWeight;

        if (average >= 7.0)
        {
            Console.WriteLine($"Media: {average:F1}");
            Console.WriteLine("Aluno aprovado.");
        }
        else if (average < 5.0)
        {
            Console.WriteLine($"Media: {average - 0.01:F1}");
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine($"Media: {average - 0.01:F1}");
            Console.WriteLine("Aluno em exame.");

            double examGrade =  double.Parse(Console.ReadLine());

            Console.WriteLine($"Nota do exame: {examGrade:F1}");

            double finalAverage  = (average + examGrade) / 2.0;
            string result = finalAverage >=  5.0 ? "Aluno aprovado." : "Aluno reprovado.";
            Console.WriteLine(result);
            Console.WriteLine($"Media final: {finalAverage:F1}");
        }
    }
}
