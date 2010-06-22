using System;
using Adapter.Animals;

namespace Adapter
{
    internal class TurkeyAdapter : IDuck
    {
        private readonly ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            turkey.Fly();
            turkey.Fly();
            turkey.Fly();
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}