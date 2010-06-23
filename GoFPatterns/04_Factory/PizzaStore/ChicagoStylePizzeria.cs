using System;
using PizzaStore.Pizzas;

namespace PizzaStore
{
    internal class ChicagoStylePizzeria : Pizzeria
    {
        protected override Pizza CreatePizza(string type)
        {
            IPizzaIngredientsFactory factory = new ChicagoStyleIngredientFactory();
            Pizza pizza;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    break;
                //case "pepperoni":
                //    pizza = new PepperoniPizza();
                //    break;
                //case "veggie":
                //    pizza = new VeggiePizza();
                //    break;
                //case "clam":
                //    pizza = new ClamPizza();
                //    break;
                default:
                    throw new ArgumentException(string.Format("Unknown pizza type: {0}", type));
            }
            return pizza;
        }
    }
}