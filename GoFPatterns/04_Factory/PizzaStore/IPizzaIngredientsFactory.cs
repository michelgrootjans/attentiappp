using PizzaStore.Ingredients;

namespace PizzaStore
{
    internal interface IPizzaIngredientsFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggie CreateMushrooms();
    }
}