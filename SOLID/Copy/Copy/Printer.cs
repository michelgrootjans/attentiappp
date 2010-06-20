using System;

namespace Copy
{
    public static class Printer
    {
        public static void Write(int c)
        {
            var previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(c);
            Console.ForegroundColor = previousColor;
        }
    }
}