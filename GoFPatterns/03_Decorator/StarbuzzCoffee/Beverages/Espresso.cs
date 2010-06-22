namespace StarbuzzCoffee.Beverages
{
    public class Espresso : Beverage
    {
        public override string Description
        {
            get { return "Espresso"; }
        }

        public override double Cost
        {
            get { return 1.99; }
        }
    }
}