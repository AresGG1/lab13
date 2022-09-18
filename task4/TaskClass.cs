using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace task4
{
    public class TaskClass
    {
        public static (string, int, bool, string)[] TaskInit()
        {
            Console.WriteLine("Enter number of clubs: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var array = new (string, int, bool, string)[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter club name: ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter number of point: ");
                int Points = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Is world champion [YES/NO]: ");
                bool IsWorldCamp = Console.ReadLine().ToLower() == "yes";
                Console.WriteLine("Enter captain name: ");
                string CapName = Console.ReadLine();
                var club = (Name, Points, IsWorldCamp, CapName);
                array[i] = club;
            }
            return array;
        }

        public static int TaskResult((string, int, bool, string)[] array)
        {
            int sum = 0;
            foreach (var tuple in array)
            {
                sum += tuple.Item2;
            }
            double avg = sum / array.Length;
            int count = 0;
            foreach (var tuple in array)
            {
                if (tuple.Item2 > avg)
                    count++;
            }

            return count;
        }
    }
}