using System;

namespace PizzaStore.Pizzas
{
    internal class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "Chicago Style Deep Dish Clam Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Marinara Souce";
            toppings.Add("Reggiano");
            toppings.Add("Fresh Clams");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}