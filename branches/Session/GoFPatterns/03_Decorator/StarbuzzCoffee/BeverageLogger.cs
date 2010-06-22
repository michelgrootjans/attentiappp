using System;
using System.Diagnostics;
using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee
{
    public class BeverageLogger : Beverage
    {
        private readonly Beverage beverage;

        public BeverageLogger(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get
            {
                Trace.WriteLine("Before calling description");
                var description = beverage.Description;
                Trace.WriteLine("After calling description");
                return description;
            }
        }

        public override double Cost
        {
            get { return beverage.Cost;}
        }
    }


}