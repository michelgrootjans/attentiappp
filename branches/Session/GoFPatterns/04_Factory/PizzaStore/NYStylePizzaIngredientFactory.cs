using System;
using PizzaStore.Ingredients;

namespace PizzaStore
{
    internal class NYStylePizzaIngredientFactory : IPizzaIngredientsFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomateSauce();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Veggie CreateMushrooms()
        {
            return new KleineChampignons();
        }
    }

    internal class KleineChampignons : Veggie
    {
    }
}