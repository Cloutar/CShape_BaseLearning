using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    class Tiger : CatType
    {
        public override void Cry()
        {
            base.Cry();
            Console.WriteLine("咆哮");
        }
    }
}
