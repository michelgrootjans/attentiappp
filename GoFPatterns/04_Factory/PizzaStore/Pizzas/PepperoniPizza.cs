namespace PizzaStore.Pizzas
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IPizzaIngredientsFactory factory)
        {
            Name = "Spicy Pepperoni Pizza";
            dough = factory.CreateDough();
            sauce = factory.CreateSauce();

        }
    }
}