using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Toy
    {
        IQuackBehavior quackBehavior { get; set; }
        public Toy()
        {
            quackBehavior = new SayQuack();
        }
        public void ToyQuack()
        {
            quackBehavior.Quack();
        }
    }
}
