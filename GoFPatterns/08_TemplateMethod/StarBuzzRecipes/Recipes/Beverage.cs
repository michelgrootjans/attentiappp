using System;

namespace StarBuzzRecipes.Recipes
{
    internal abstract class Beverage
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing a cup of coffee...");

            BoilWater();
            PrepareBeverage();
            PourInCup();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void PrepareBeverage();


        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected abstract void AddCondiments();
    }
}