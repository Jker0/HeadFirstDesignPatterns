using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class Duck
    {
        public abstract void display();
        
        public void swim()
        {
            Console.WriteLine("All duck float, even decoys");
        }
    }
}
