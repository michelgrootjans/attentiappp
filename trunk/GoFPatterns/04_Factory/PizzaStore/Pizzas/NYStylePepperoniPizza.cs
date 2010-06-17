namespace PizzaStore.Pizzas
{
    internal class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            Name = "NY Style Sauce and Pepperoni Pizza";
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