using Strategy.Fly;
using Strategy.Quack;

namespace Strategy.Duck
{
    internal abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }
        public abstract void Display();
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void SetFlyBehavoir(IFlyBehavior Fb)
        {
            FlyBehavior = Fb;
        }

        public void SetQuackBehavoir(IQuackBehavior Qb)
        {
            QuackBehavior = Qb;
        }

        public void Swim()
        {
            Console.WriteLine("All duck float, even decoys");
        }
    }
}
