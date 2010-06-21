using System;

namespace PizzaStore.Ingredients
{
    internal abstract class Clams
    {
        protected Clams()
        {
            Console.WriteLine("Adding Clams ...");
        }
    }
    internal class FrozenClams : Clams
    {
    }
    internal class FreshClams : Clams
    {
    }

}