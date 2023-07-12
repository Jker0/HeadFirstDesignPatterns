namespace Strategy.Fly
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am Fly!!!");
        }
    }
}
