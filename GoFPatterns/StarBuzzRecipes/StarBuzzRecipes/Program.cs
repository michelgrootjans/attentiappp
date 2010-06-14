using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarBuzzRecipes.Recipes;

namespace StarBuzzRecipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Coffee();
            coffee.Prepare();

            var tea = new Tea();
            tea.Prepare();

            Console.ReadLine();
        }
    }
}
