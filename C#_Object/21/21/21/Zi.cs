using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Zi : Fu, IBBB
    {
        public void World()
        {
            Console.WriteLine("我是子类");
        }

        public override void Hello()
        {
            Console.WriteLine("Hello");
        }


        public void B1()
        {
            Console.WriteLine("B1");
        }
    }
}
