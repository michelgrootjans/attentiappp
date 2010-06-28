using System;

namespace Composite
{
    internal class Waitress
    {
        private readonly string name;
        private readonly IMenu menu;

        public Waitress(string name, IMenu menu)
        {
            this.name = name;
            this.menu = menu;
        }

        public void ShowMenu()
        {
            Console.WriteLine("Hi, I'm {0}, and this is your menu:", name);
            menu.Print();
        }
    }
}