namespace PizzaStore.Pizzas
{
    internal class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Martinara Sauce";

            toppings.Add("Greated Reggiano Cheese");
        }
    }
}