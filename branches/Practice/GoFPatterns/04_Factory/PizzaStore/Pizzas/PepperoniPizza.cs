namespace PizzaStore.Pizzas
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Spicy Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Spicy Salsa";
            toppings.Add("Slices of chorizo");
            toppings.Add("Small olives");

        }
    }
}