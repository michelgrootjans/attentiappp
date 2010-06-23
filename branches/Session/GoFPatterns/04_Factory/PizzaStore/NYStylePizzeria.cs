using System;
using PizzaStore.Pizzas;

namespace PizzaStore
{
    internal class NYStylePizzeria : Pizzeria
    {
        private IPizzaIngredientsFactory factory = new NYStylePizzaIngredientFactory();

        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(factory);
                    break;
                //case "veggie":
                //    pizza = new NYStyleVeggiePizza();
                //    break;
                //case "clam":
                //    pizza = new NYStyleClamPizza();
                //    break;
                default:
                    throw new ArgumentException(string.Format("Unknown pizza type: {0}", type));
            }
            return pizza;

        }
    }
}