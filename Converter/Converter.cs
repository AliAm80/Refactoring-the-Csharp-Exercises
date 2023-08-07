using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter
{
    public static class Converter
    {
        static double _result;
        
        public static void MilesToKilometers(double mile)
        {
            _result = mile * 1.60934;
            Console.WriteLine($"\n{mile} miles is equal to {_result} kilometers\n");
        }
        public static void KilometersToMiles(double kilometer)
        {
            _result = kilometer / 1.60934;
            Console.WriteLine($"\n{kilometer} kilometers is equal to {_result} miles\n");
        }
        public static void NumberToAlphabet(int number)
        {
            var input = (Numbers)number;

            switch (input)
            {
                case (Numbers)0:
                    Console.WriteLine($" Result --> {Numbers.Zero} ");
                    break;
                case (Numbers)1:
                    Console.WriteLine($" Result --> {Numbers.One} ");
                    break;
                case (Numbers)2:
                    Console.WriteLine($" Result --> {Numbers.Two} ");
                    break;
                case (Numbers)3:
                    Console.WriteLine($" Result --> {Numbers.Three} ");
                    break;
                case (Numbers)4:
                    Console.WriteLine($" Result --> {Numbers.Four} ");
                    break;
                case (Numbers)5:
                    Console.WriteLine($" Result --> {Numbers.Five} ");
                    break;
                case (Numbers)6:
                    Console.WriteLine($" Result --> {Numbers.Six} ");
                    break;
                case (Numbers)7:
                    Console.WriteLine($" Result --> {Numbers.Seven} ");
                    break;
                case (Numbers)8:
                    Console.WriteLine($" Result --> {Numbers.Eight} ");
                    break;
                case (Numbers)9:
                    Console.WriteLine($" Result --> {Numbers.Nine} ");
                    break;
                case (Numbers)10:
                    Console.WriteLine($" Result --> {Numbers.Ten} ");
                    break;

                default:
                    throw new Exception("ERROR : You entered out of range !!!");


            }
        }

        public static void NumberToDayOfWeek(int number)
        {
            var input = (DaysOfWeek)number;
            switch (input)
            {
                case (DaysOfWeek)1:
                    Console.WriteLine($"Today is {DaysOfWeek.Saturday} :)");
                    break;
                case (DaysOfWeek)2:
                    Console.WriteLine($"Today is {DaysOfWeek.Sunday} :)");
                    break;
                case (DaysOfWeek)3:
                    Console.WriteLine($"Today is {DaysOfWeek.Monday} :)");
                    break;
                case (DaysOfWeek)4:
                    Console.WriteLine($"Today is {DaysOfWeek.Tuesday} :)");
                    break;
                case (DaysOfWeek)5:
                    Console.WriteLine($"Today is {DaysOfWeek.Wednesday} :)");
                    break;
                case (DaysOfWeek)6:
                    Console.WriteLine($"Today is {DaysOfWeek.Thursday} :)");
                    break;
                case (DaysOfWeek)7:
                    Console.WriteLine($"Today is {DaysOfWeek.Friday} :)");
                    break;
                default:
                    throw new Exception("ERROR : You entered out of range !!!");

            }

        }
    }
}