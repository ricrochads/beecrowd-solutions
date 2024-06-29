using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args) 
    {
        int studentCount = GetStudentCount();
        Dictionary<string, double> students = ReadStudentGrades(studentCount);
        string chosen = SelectStudentByGrade(students);
        Console.WriteLine(chosen);
    }

    static int GetStudentCount()
    {
        int studentCount;

        do
            studentCount = int.Parse(Console.ReadLine());
        while (studentCount < 3 || studentCount > 100);

        return studentCount;
    }

    static Dictionary<string, double> ReadStudentGrades(int studentCount)
    {
        var studentGrades = new Dictionary<string, double>();
        string registrationNumber;
        double grade;

        for (int i = 0; i < studentCount; i++)
        {
            do
            {   
                string[] registrationAndGrade = Console.ReadLine().Split(' ');
                registrationNumber = registrationAndGrade[0];
                grade = double.Parse(registrationAndGrade[1]);
            } while (grade < 0 || grade > 10.0);

            studentGrades[registrationNumber] = Math.Round(grade, 1);
        }

        return studentGrades;
    }

    static string SelectStudentByGrade(Dictionary<string, double> students)
    {
        double maxGrade = 0;
        string studentWithMaxGrade = null;

        foreach (var student in students)
        {
            if (student.Value >= 8.0 && student.Value > maxGrade)
            {
                maxGrade = student.Value;
                studentWithMaxGrade = student.Key;
            }
        }

        if (studentWithMaxGrade != null)
            return $"{studentWithMaxGrade}";
        else
            return "Minimum note not reached";
    }
}