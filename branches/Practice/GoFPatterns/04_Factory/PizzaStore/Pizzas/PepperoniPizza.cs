namespace PizzaStore.Pizzas
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Spicy Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Reggiano");
            toppings.Add("Mushrooms");
            toppings.Add("Onions");
            toppings.Add("Red Peppers");
            toppings.Add("Pepperoni");
        }
    }
}