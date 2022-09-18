using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Xsl;
using Microsoft.SqlServer.Server;

namespace LAB13
{
    public class ConsoleInteract
    {
        public static Timetable[] InputTrain()
        {
            Console.WriteLine("Enter number array \"Train\" elements: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Timetable[] Train = new Timetable[number];
            for (int i = 0; i < number; i++)
            {
                var timeTable = new Timetable();
                Console.WriteLine("Enter name of destination place: ");
                timeTable.nazv = Console.ReadLine();
                Console.WriteLine("Enter train number: ");
                timeTable.numr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter date of depart: ");
                timeTable.date = Console.ReadLine();
                Console.WriteLine("Enter time of depart: ");
                timeTable.time = Console.ReadLine();
                Train[i] = timeTable;
            }
            return Train;
        }

        public static void Sort(Timetable[] Train)
        {
            for (int i = 0; i < Train.Length-1; i++)
            {
                for (int j = i; j < Train.Length-1; j++)
                {
                    if(Train[j].numr > Train[j+1].numr)
                        (Train[j], Train[j+1]) = (Train[j+1], Train[j]); 
                }
            }
        }

        private static string FormatDate(string date)
        {
            date = date.Replace(":", "");
            date = date.Replace("_", "");
            date = date.Replace("/", "");
            date = date.Replace("-", "");
            return date;
        }
        
        public static void Search(Timetable[] Train)
        {
            List<Timetable> Show = new List<Timetable>();
            Console.WriteLine("Enter required date: ");
            var date = Console.ReadLine();
            date = FormatDate(date);
            foreach (var timetable in Train)
            {
                if (FormatDate(timetable.date) == date)
                {
                    Show.Add(timetable);
                }
            }

            if (Show.Count == 0)
            {
                Console.WriteLine("There is no suitable train...");
            }
            else
            {
                foreach (var timetable in Show)
                {
                    Console.WriteLine(timetable.ToString());
                }
            }
        }
        public static void Save(Timetable[] Train)
        {
            StreamWriter writer = new StreamWriter("..\\..\\task1.txt", false, Encoding.UTF8);
            foreach (var timetable in Train)
            {
                writer.Write(timetable.ToString());
                writer.Write("\n");
            }

            writer.Close();
        }

        public static void Show(Timetable[] Train)
        {
            foreach (var timetable in Train)
            {
                Console.WriteLine(timetable.ToString());
            }
        }
    }
}