using System;

namespace StarBuzzRecipes.Recipes
{
    internal class Coffee : Beverage
    {
        protected override void PrepareBeverage()
        {
            Console.WriteLine("Coffee is brewing...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}