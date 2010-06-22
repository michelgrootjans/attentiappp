namespace StarbuzzCoffee.Beverages
{
    public class Mocha : Condiment
    {
        private Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + " with Mocha"; }
        }

        public override double Cost
        {
            get { return beverage.Cost + 0.2; }
        }
    }
}