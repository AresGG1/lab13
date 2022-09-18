using System;
using System.Runtime.CompilerServices;

namespace task2
{
    public class Task
    {
        public static void TaskFunction()
        {
            bool run = true;
            while(run)
            {
                Console.WriteLine("Enter number of required option: ");
                Console.WriteLine("        Exit = 0,\n        Oven = 1,\n        Bull = 2, \n        Twins = 3,\n        Crawfish = 4,\n        Lion = 5,\n        Virgo = 6,\n        Libra = 7,\n        Scorpion = 8,\n        Sagittarius = 9,\n        Ibex = 10,\n        Aquarius = 11,\n        Fish = 12");
                ZodiacSigns zodiacSigns = (ZodiacSigns) Convert.ToInt32(Console.ReadLine());
                switch (zodiacSigns)
                {
                    case ZodiacSigns.Exit:
                        Console.WriteLine("Exit...");
                        run = false;
                        break;
                    case ZodiacSigns.Oven:
                        Console.WriteLine("стихія вогню (активність, починання)");
                        break;
                    case ZodiacSigns.Bull:
                        Console.WriteLine("стихія землі (наполегливість, накопичення)");
                        break;
                    case ZodiacSigns.Twins:
                        Console.WriteLine("стихія повітря (рух, комунікація)");
                        break;
                    case ZodiacSigns.Crawfish:
                        Console.WriteLine("стихія води (система, інтуїція)");
                        break;
                    case ZodiacSigns.Lion:
                        Console.WriteLine("стихія вогню (індивідуалізація, творче самовираження)");
                        break;
                    case ZodiacSigns.Virgo:
                        Console.WriteLine("стихія землі (служіння, деталізація)");
                        break;
                    case ZodiacSigns.Libra:
                        Console.WriteLine("стихія повітря (врівноважування, дуальність)");
                        break;
                    case ZodiacSigns.Scorpion:
                        Console.WriteLine("стихія води (трансформація, інстинктивність)");
                        break;
                    case ZodiacSigns.Sagittarius:
                        Console.WriteLine("стихія вогню (світоглядність, духовність)");
                        break;
                    case ZodiacSigns.Ibex:
                        Console.WriteLine("стихія землі (відповідальність, цілеспрямованість)");
                        break;
                    case ZodiacSigns.Aquarius:
                        Console.WriteLine("стихія повітря (незалежність, новаторство)");
                        break;
                    case ZodiacSigns.Fish:
                        Console.WriteLine("стихія води (відречення, глибинність)");
                        break;
                }
                
            }
        }
    }
}