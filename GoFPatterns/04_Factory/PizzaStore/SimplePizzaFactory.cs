//using System;
//using PizzaStore.Pizzas;

//namespace PizzaStore
//{
//    internal class SimplePizzaFactory
//    {
//        public Pizza CreatePizza(string type)
//        {
//            Pizza pizza;
//            switch (type)
//            {
//                case "cheese":
//                        pizza = new CheesePizza(TODO);
//                    break;
//                //case "greek":
//                //    pizza = new GreekPizza();
//                //    break;
//                case "pepperoni":
//                    pizza = new PepperoniPizza();
//                    break;
//                case "veggie":
//                    pizza = new VeggiePizza();
//                    break;
//                case "clam":
//                    pizza = new ClamPizza();
//                    break;
//                default:
//                    throw new ArgumentException(string.Format("Unknown pizza type: {0}", type));
//            }
//            return pizza;

//        }
//    }
//}