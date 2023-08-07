using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tWelcome To Converter :)\n");
            Console.ResetColor();
            while (true)
            {
                try
                {
                    var menu = ShowInput.Menu();
                    Console.Clear();
                    ShowInput.Choose(menu);
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                }
            }

        }
    }
}