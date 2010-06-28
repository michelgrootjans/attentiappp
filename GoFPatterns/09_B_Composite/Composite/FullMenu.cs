using System;

namespace Composite
{
    internal class FullMenu : MenuBase
    {
        internal override void Print(int level)
        {
            Console.WriteLine("All menus");
            Console.WriteLine("|- Pancake House Menu");
            Console.WriteLine("|  | Pancake");
            Console.WriteLine("|  | Maple sirop");
            Console.WriteLine("|  | Sugar");
            Console.WriteLine("|- Diner menu");
            Console.WriteLine("|  | Fresh salad");
            Console.WriteLine("|  | Jucy steak");
            Console.WriteLine("|  | French fries");
            Console.WriteLine("|  |- Desert menu");
            Console.WriteLine("|  |  | Dame blache");
            Console.WriteLine("|  |  | Apple pie");
            Console.WriteLine("|- Cafe menu");
            Console.WriteLine("|  | Home brew coffee");
            Console.WriteLine("|  | Espresso");
            Console.WriteLine("|  | Mint tea");
        }
    }
}