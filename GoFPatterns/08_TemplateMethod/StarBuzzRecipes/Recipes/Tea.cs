using System;

namespace StarBuzzRecipes.Recipes
{
    internal class Tea
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing a cup of tea...");

            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddLemon();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Steeping the tea");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        private void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}