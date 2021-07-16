using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    /// <summary>
    /// 定义一个抽象类
    /// </summary>
    abstract class FuLei
    {
        /// <summary>
        /// 定义一个抽象方法
        /// </summary>
        //public abstract void Hello();

        public void F()
        {
            Console.WriteLine("父类普通方法");
        }
    }
}
