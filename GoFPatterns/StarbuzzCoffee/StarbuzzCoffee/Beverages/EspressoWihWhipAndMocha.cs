namespace StarbuzzCoffee.Beverages
{
    public class EspressoWihWhipAndMocha : Beverage
    {
        public override string Description
        {
            get { return "Espresso with whip and mocha"; }
        }

        public override double Cost
        {
            get { return 3.5; }
        }
    }
}