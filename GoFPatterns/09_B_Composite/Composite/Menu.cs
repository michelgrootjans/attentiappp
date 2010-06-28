using System;
using System.Collections.Generic;

namespace Composite
{
    internal class Menu : MenuBase
    {
        private readonly string name;
        private readonly List<MenuBase> subMenus = new List<MenuBase>();

        public Menu(string name)
        {
            this.name = name;
        }

        internal override void Print(int level)
        {
            //print self
            PrintSelf(level);
            //print subitems
            foreach (var subMenu in subMenus)
            {
                subMenu.Print(level + 1);
            }
        }

        protected virtual void PrintSelf(int level)
        {
            Console.WriteLine("{0} {1}", new string('*', level), name);
        }

        public void Add(MenuBase menu)
        {
            subMenus.Add(menu);
        }
    }
}