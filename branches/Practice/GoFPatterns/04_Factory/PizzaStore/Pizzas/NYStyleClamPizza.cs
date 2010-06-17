namespace PizzaStore.Pizzas
{
    internal class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            Name = "NY Style Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Souce";
            toppings.Add("Reggiano");
            toppings.Add("Fresh Clams");
        }
    }
}