using System;

namespace Composite
{
    internal class MenuItem : MenuBase
    {
        private readonly string name;
        private readonly double price;

        public MenuItem(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        internal override void Print(int level)
        {
            Console.WriteLine("{0}{1}\t{2}",new string('-', level), name, price);
        }
    }
}