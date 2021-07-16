using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    /// <summary>
    /// 蝙蝠侠战车
    /// </summary>
    class Batmobile : Car, IFly
    {
        public Batmobile(string brand)
            : base(brand)
        {

        }

        public void Fly()
        {
            Console.WriteLine("{0}在飞行..", base.Brand);
        }
    }
}
