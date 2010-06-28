using System;

namespace Composite
{
    internal class Program
    {
        private static void Main()
        {
            var menu = GetMenu();

            var waitress = new Waitress("Julie", menu);

            waitress.ShowMenu();

            Console.ReadLine();
        }

        private static Menu GetMenu()
        {
            var menu = new Menu("Full menu");
            var morningMenu = new Menu("Morning menu");
            var pancakes = new MenuItem("Pancakes", 2.99);
            morningMenu.Add(pancakes);
            morningMenu.Add(new MenuItem("Maple sirop", 0.99));
            menu.Add(morningMenu);

            var dinnerMenu = new Menu("Dinner menu");
            dinnerMenu.Add(new MenuItem("NY style pizza", 5.49));
            var desertsMenu = new Menu("Deserts");
            desertsMenu.Add(new MenuItem("Tiramisu", 9.99));
            dinnerMenu.Add(desertsMenu);
            menu.Add(dinnerMenu);

            var cafeMenu = new Menu("Cafe menu");
            cafeMenu.Add(new MenuItem("Darkroast", 1.29));
            cafeMenu.Add(new MenuItem("Whip", 0.49));
            cafeMenu.Add(pancakes);
            menu.Add(cafeMenu);
            return menu;
        }
    }
}