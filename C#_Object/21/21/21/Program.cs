using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 虚方法
             * 父类中的个别方法用虚方法实现, 然后允许子类在有需要的情况下重写这些虚方法
             * 
             * 抽象类
             * 父类定义一系列的规范, 子类去把父类里面定义的这些规范全部实现
             * 
             * 接口
             * 是一种功能的扩展, 是在原有的类的继承关系以外的新功能的扩展
             * 
             */


            Zi z = new Zi();
            z.Hello();
            z.World();

            //Fu f = new Fu();
            //f.Hello();

            z.B1();

            Console.ReadKey();
        }
    }
}
