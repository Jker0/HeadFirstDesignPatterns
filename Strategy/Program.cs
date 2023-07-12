
using Strategy.Fly;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rubber duck");
            Duck.Duck rubberDuck = new Duck.RubberDuck();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();
            rubberDuck.Display();
            rubberDuck.Swim();
            Console.WriteLine("--------");

            Console.WriteLine("Model duck");
            Duck.Duck modelDuck = new Duck.ModelDuck();
            modelDuck.PerformQuack();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavoir(new FlyRocketPowered());
            modelDuck.PerformFly();
            Console.WriteLine("--------");

            Console.WriteLine("Toy");
            Toy toy = new Toy();
            toy.ToyQuack();
            Console.WriteLine("--------");
        }
    }
}