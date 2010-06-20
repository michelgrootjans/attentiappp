namespace PizzaStore.Pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Reggiano");
            toppings.Add("Mushrooms");
            toppings.Add("Onions");
            toppings.Add("Red Peppers");
        }
    }
}