

using Strategy.Fly;

namespace Strategy.Duck
{
    internal class ModelDuck:Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack.MuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Display model duck");
        }
    }
}
