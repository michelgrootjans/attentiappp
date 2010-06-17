using System;
using PizzaStore.Pizzas;

namespace PizzaStore
{
    internal class DependentPizzeria
    {
        public Pizza OrderPizza(string style, string type)
        {
            var pizza = CreatePizza(style, type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        private Pizza CreatePizza(string style, string type)
        {
            switch (style)
            {
                case "NY":
                    switch (type)
                    {
                        case "cheese":
                            return new NYStyleCheesePizza();
                        case "clam":
                            return new NYStyleClamPizza();
                        case "veggie":
                            return new NYStyleVeggiePizza();
                        case "pepperoni":
                            return new NYStylePepperoniPizza();
                    }
                    break;
                case "Chicago":
                    switch (type)
                    {
                        case "cheese":
                            return new ChicagoStyleCheesePizza();
                        case "clam":
                            return new ChicagoStyleClamPizza();
                        case "veggie":
                            return new ChicagoStyleVeggiePizza();
                        case "pepperoni":
                            return new ChicagoStylePepperoniPizza();
                    }
                    break;
            }
            throw new ArgumentException(string.Format("Unknown pizza: {0}.{1}", style, type));
        }
    }
}