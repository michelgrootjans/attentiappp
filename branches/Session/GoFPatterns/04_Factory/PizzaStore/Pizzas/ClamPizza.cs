namespace PizzaStore.Pizzas
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Souce";

            toppings.Add("Reggiano");
            toppings.Add("Fresh Clams");
        }
    }
}