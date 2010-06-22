namespace StarbuzzCoffee.Beverages
{
    public class Whip : Condiment
    {
        private readonly Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + " with whip"; }
        }

        public override double Cost
        {
            get { return  beverage.Cost + 0.1; }
        }
    }
}