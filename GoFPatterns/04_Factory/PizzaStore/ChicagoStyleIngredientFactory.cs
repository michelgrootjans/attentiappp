using PizzaStore.Ingredients;

namespace PizzaStore
{
    internal class ChicagoStyleIngredientFactory : IPizzaIngredientsFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Veggie CreateMushrooms()
        {
            return new GrandChampignons();
        }
    }

    internal class GrandChampignons : Veggie
    {
    }
}