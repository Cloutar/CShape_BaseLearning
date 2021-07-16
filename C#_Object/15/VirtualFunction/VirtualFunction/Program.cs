using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 在继承关系的前提下, 实例化出不同的对象, 这些对象调用相同的方法, 但是却
             * 表现出不同的行为, 这就叫做多态
             * 
             * 在c#语言中体现多态有三种方式: 虚方法, 抽象类, 接口
             * 
             * 虚方法
             * 在父类中使用virtual关键字修饰的方法, 就是虚方法(表示该方法可以重写)
             * 在子类中可以使用override关键字对该虚方法进行重写
             * 
             */

            Tiger t = new Tiger();
            t.Cry();

            Console.WriteLine();

            Cat c = new Cat();
            c.Cry();

            Console.ReadKey();

        }
    }
}
