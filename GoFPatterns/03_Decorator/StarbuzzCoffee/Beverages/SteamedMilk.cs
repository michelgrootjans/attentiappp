namespace StarbuzzCoffee.Beverages
{
    public class SteamedMilk : Condiment
    {
        private readonly Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + " with steamed milk"; }
        }

        public override double Cost
        {
            get { return beverage.Cost + 0.1; }
        }
    }
}