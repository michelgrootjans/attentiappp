namespace PizzaStore.Pizzas
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientsFactory factory)
        {
            Name = "Sauce and Cheese Pizza";
            dough = factory.CreateDough();
            sauce = factory.CreateSauce();
            cheese = factory.CreateCheese();

            Add(factory.CreateMushrooms());
        }
    }
}