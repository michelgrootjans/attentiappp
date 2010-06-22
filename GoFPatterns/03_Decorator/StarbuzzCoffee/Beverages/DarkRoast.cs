namespace StarbuzzCoffee.Beverages
{
    public class DarkRoast : Beverage
    {
        public override string Description
        {
            get { return "Dark roast"; }
        }

        public override double Cost
        {
            get { return 0.99; }
        }
    }
}