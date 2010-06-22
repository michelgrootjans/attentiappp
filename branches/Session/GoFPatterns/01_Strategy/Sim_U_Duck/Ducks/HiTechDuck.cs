using Sim_U_Duck.Behaviors;

namespace Sim_U_Duck.Ducks
{
    public class HiTechDuck : Duck
    {
        public HiTechDuck() : base(new ElectronicQuack(), new FlyNoWay())
        {
        }

        public override void Display()
        {
            writer.Write("I'm a fancy hi-tech duck");
        }

        public void Attach(IFlyBehavior newFlyBehavior)
        {
            flyBehavior = newFlyBehavior;
        }
    }
}