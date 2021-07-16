using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    class CatType
    {
        public virtual void Cry() {
            Console.WriteLine("深呼吸, 张开嘴巴, 发出:");
        }

        public void MKCODE()
        {
            Console.WriteLine("我是父类");
        }
    }
}
