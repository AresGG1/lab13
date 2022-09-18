using System;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace Task5
{
    public class TaskClass
    {
        public static string GetScore((string, (int, int, int, int, int, int), int) info)
        {
            var marks = info.Item2;
            int a = 0;

            int marksSum = marks.Item1 + marks.Item2 + marks.Item3 + marks.Item4 + marks.Item5 + marks.Item6;
            int mark = (int)Math.Round((marksSum / 6) * 0.4 + info.Item3 * 0.6);
            return $"Студент {info.Item1}, Ваша пiдсумкова оцiнка з iспит: {mark}";
        }

        public static (string, (int, int, int, int, int, int), int) InputData()
        {
            Console.WriteLine("Enter surname: ");
            string surname = Console.ReadLine();
            int[] marks = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Enter mark {i + 1}");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            var homeWork = (marks[0], marks[1], marks[2], marks[3], marks[4], marks[5]);
            int exam = Convert.ToInt32(Console.ReadLine());
            return (surname, homeWork, exam);
        }
    }
}