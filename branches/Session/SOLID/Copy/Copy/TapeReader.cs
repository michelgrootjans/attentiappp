using System;

namespace Copy
{
    public class TapeReader : IReader
    {
        int IReader.Read()
        {
            return Console.Read();
        }
    }
}