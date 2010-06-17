namespace PizzaStore.Pizzas
{
    internal class GreekPizza : Pizza
    {
        public GreekPizza()
        {
            Name = "Greek Pizza";
            dough = "Thin Crust Dough";
            sauce = "Tarama Sauce";

            toppings.Add("Feta Cubes");
        }
    }
}