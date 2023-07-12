using Strategy.Fly;

namespace Strategy.Duck
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack.SayQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Display Redhead duck!");
        }
    }
}
