namespace PizzaStore.Pizzas
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Garlic");
        }
    }
}