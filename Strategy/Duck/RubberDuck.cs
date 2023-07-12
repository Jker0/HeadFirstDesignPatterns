using Strategy.Fly;

namespace Strategy.Duck
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack.SayQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Display rubber duck");
        }
    }
}
