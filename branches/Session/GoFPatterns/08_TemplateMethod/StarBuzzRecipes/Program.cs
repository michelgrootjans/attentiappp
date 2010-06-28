using System;
using StarBuzzRecipes.Recipes;

namespace StarBuzzRecipes
{
    internal class Program
    {
        private static void Main()
        {
            var coffee = new Coffee();
            coffee.Prepare();

            Console.WriteLine();
            
            var tea = new Tea();
            tea.Prepare();

            Console.ReadLine();
        }
    }
}