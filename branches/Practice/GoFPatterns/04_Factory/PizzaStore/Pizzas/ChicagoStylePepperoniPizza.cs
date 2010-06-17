using System;

namespace PizzaStore.Pizzas
{
    internal class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            Name = "Chicago Style Deep Dish Pepperoni Pizza";
            dough = "Extra Thick Crust Dough";

            sauce = "Marinara Sauce";
            toppings.Add("Reggiano");
            toppings.Add("Mushrooms");
            toppings.Add("Onions");
            toppings.Add("Red Peppers");
            toppings.Add("Pepperoni");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}