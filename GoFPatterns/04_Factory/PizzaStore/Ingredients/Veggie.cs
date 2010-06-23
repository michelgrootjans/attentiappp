﻿using System;

namespace PizzaStore.Ingredients
{
    public abstract class Veggie
    {
        protected Veggie()
        {
            Console.WriteLine("- " + GetType().Name);
        }
    }
    internal class Onions : Veggie
    {
    }
    internal class SlicedOlives : Veggie
    {
    }
    internal class SlicedTomatoes : Veggie
    {
    }
}