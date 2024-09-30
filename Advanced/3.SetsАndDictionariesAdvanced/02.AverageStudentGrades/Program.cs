using System;
using System.Diagnostics.Contracts;

namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> gradesByStudents = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string studentName = studentInfo[0];
                decimal grade = decimal.Parse(studentInfo[1]);
                if (!gradesByStudents.ContainsKey(studentName))
                {
                    gradesByStudents.Add(studentName,new List<decimal>());
                }

                gradesByStudents[studentName].Add(grade);
            }

            

            foreach (var (studentName, grades) in gradesByStudents)
            {
                Console.Write($"{studentName} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {grades.Average():f2})");
            }
        }
    }
}
