using System;

namespace StarBuzzRecipes.Recipes
{
    internal class Tea : Beverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void PrepareBeverage()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}