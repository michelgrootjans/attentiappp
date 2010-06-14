using System;

namespace StarBuzzRecipes.Recipes
{
    internal class Coffee
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing a cup of coffee...");

            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        private void AddSugarAndMilk()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}