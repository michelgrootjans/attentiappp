using System;
using Sim_U_Duck.Ducks;

namespace Sim_U_Duck.Behaviors
{
    public class NormalQuack : IQuackBehavior
    {
        private readonly IWriter writer;

        public NormalQuack() : this(new ConsoleWriter())
        {
        }

        public NormalQuack(IWriter writer)
        {
            this.writer = writer;
        }

        public void Quack()
        {
            writer.Write("Quack!");
        }
    }
}