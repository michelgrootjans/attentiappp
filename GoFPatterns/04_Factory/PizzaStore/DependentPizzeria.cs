using System;
using PizzaStore.Pizzas;

namespace PizzaStore
{
    internal class DependentPizzeria
    {
        public Pizza OrderPizza(string style, string type)
        {
            Pizza pizza = null;
            if (style == "NY")
            {
                if (type == "cheese")
                {
                    pizza = new NYStyleCheesePizza();
                }
                else if (type == "clam")
                {
                    pizza = new NYStyleClamPizza();
                }
                else if (type == "veggie")
                {
                    pizza = new NYStyleVeggiePizza();
                }
                else if (type == "pepperoni")
                {
                    pizza = new NYStylePepperoniPizza();
                }
            }
            else if (style == "Chicago")
            {
                if (type == "cheese")
                {
                    pizza = new ChicagoStyleCheesePizza();
                }
                else if (type == "clam")
                {
                    pizza = new ChicagoStyleClamPizza();
                }
                else if (type == "veggie")
                {
                    pizza = new ChicagoStyleVeggiePizza();
                }
                else if (type == "pepperoni")
                {
                    pizza = new ChicagoStylePepperoniPizza();
                }
            }
            if (pizza == null)
            {
                throw new ArgumentException(string.Format("Unknown pizza: {0}.{1}", style, type));
            }
            return pizza;
        }
    }
}