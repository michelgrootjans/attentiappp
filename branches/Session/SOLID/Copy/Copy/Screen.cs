using System;

namespace Copy
{
    public class Screen : IWriter
    {
        void IWriter.Write(int i)
        {
            Console.WriteLine(i);
        }
    }
}