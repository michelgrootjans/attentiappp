﻿using System;

namespace Copy
{
    public class Keyboard : IReader
    {
        int IReader.Read()
        {
            return Console.Read();
        }
    }
}