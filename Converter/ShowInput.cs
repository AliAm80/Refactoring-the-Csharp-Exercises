using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter
{
    public static class ShowInput
    {
        static double _input;
        public static string Menu()
        {
            Console.WriteLine("1) Convert Miles To Kilometers");
            Console.WriteLine("2) Convert Kilometers To Miles");
            Console.WriteLine("3) Convert Number To Alphabet");
            Console.WriteLine("4) Convert Number To Day Of Week");
            Console.WriteLine("5) Exit");
            Console.Write("\nEnter a number to execute : ");
            var select = Console.ReadLine();
            return select;
        }

        public static void Choose(string select)
        {
            switch (select)
            {
                case "1":
                    _input = MilesShow();
                    Converter.MilesToKilometers(_input);
                    break;
                case "2":
                    _input = KilometersShow();
                    Converter.KilometersToMiles(_input);
                    break;
                case "3":
                    _input = AlphabetShow();
                    Converter.NumberToAlphabet((int)_input);
                    break;
                case "4":
                    _input = DayOfWeekShow();
                    Converter.NumberToDayOfWeek((int)_input);
                    break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Good Bye :)\n");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                default:
                    
                    throw new Exception("ERROR : You entered wrong item !!!");

            }
        }
        static double MilesShow()
        {
            Console.Write("Enter the distance in miles : ");
            _input = Convert.ToDouble(Console.ReadLine());
            return _input;
        }
        static double KilometersShow()
        {
            Console.Write("Enter the distance in kilometers : ");
            _input = Convert.ToDouble(Console.ReadLine());
            return _input;
        }
        static int AlphabetShow()
        {
            Console.Write("Enter a number between 0 to 10 : ");
            _input = Convert.ToInt32(Console.ReadLine());
            return (int)_input;
        }
        static int DayOfWeekShow()
        {
            Console.Write("Enter a number between 1 to 7 for day of the week : ");
            _input = Convert.ToInt32(Console.ReadLine());
            return (int)_input;
        }

    }
}