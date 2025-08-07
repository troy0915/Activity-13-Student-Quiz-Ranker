using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_13_Student_Quiz_Ranker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>();
            List<int> quizScores = new List<int>();
            Console.WriteLine("Enter names and quiz scores for 10 students:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Student {i + 1} name: ");
                string name = Console.ReadLine();

                Console.Write($"{name}'s quiz score (0-100): ");
                int score;
                while (!int.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a score between 0-100.");
                    Console.Write($"{name}'s quiz score (0-100): ");
                }

                studentNames.Add(name);
                quizScores.Add(score);
            }
            for (int i = 0; i < quizScores.Count - 1; i++)
            {
                for (int j = i + 1; j < quizScores.Count; j++)
                {
                    if (quizScores[i] < quizScores[j])
                    {
                        int tempScore = quizScores[i];
                        quizScores[i] = quizScores[j];
                        quizScores[j] = tempScore;

                        string tempName = studentNames[i];
                        studentNames[i] = studentNames[j];
                        studentNames[j] = tempName;
                    }
                }
            }
            Console.WriteLine("\nTop 3 Performers:");
            for (int i = 0; i < 3 && i < studentNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {studentNames[i]} - {quizScores[i]}");
            }
        }
    }
}




