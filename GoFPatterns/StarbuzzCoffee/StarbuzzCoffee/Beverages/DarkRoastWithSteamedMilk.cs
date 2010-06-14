namespace StarbuzzCoffee.Beverages
{
    public class DarkRoastWithSteamedMilk : Beverage
    {
        public override string Description
        {
            get { return "Dark roast with steamed milk"; }
        }

        public override double Cost
        {
            get { return 6.5; }
        }
    }
}