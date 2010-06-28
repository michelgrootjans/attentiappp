using System;

namespace Copy
{
    public class Printer : IWriter
    {
        void IWriter.Write(int c)
        {
            Console.WriteLine("Printer Prints: " + c);
        }
    }
}