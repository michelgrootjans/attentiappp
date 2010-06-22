using Sim_U_Duck.Behaviors;

namespace Sim_U_Duck.Ducks
{
    public abstract class Duck
    {
        protected readonly IWriter writer;
        private readonly IQuackBehavior quackBehavior;
        protected IFlyBehavior flyBehavior;

        protected Duck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior): 
            this(new ConsoleWriter(), quackBehavior, flyBehavior )
        {
        }

        protected Duck(IWriter writer, IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            this.writer = writer;
            this.quackBehavior = quackBehavior;
            this.flyBehavior = flyBehavior;
        }

        public abstract void Display();

        public void Quack()
        {
            quackBehavior.Quack();
        }

        public void Fly()
        {
            flyBehavior.Fly();
        }
    }
}