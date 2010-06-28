namespace Composite
{
    internal abstract class MenuBase : IMenu
    {
        public void Print()
        {
            Print(0);
        }

        internal abstract void Print(int level);
    }
}