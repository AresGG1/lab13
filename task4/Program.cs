using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number of clubs: "+TaskClass.TaskResult(TaskClass.TaskInit()));
        }
    }
}