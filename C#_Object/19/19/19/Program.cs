using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 抽象类-->接口
             * 当抽象类中所有的方法都是抽象方法的时候, 这个时候可以把这个抽象类用另外
             * 一种形式来表示, 这种形式叫接口.
             * 
             * 接口使用interface关键字定义, 没有class关键字, 接口名一般使用"IXxxx";
             * 接口中不能包含字段, 但是可以包含属性;
             * 接口中定义的方法不能有方法体, 全是抽象方法, 但又不需要用abstract修饰;
             * 接口中的成员不允许添加访问修饰符, 默认都是public;
             * 
             * 
             * 注意事项
             * 1. 接口中所有的方法都是抽象方法, 所以接口不能被实例化
             * 2. 一个类可以实现多个接口, 被实现的多个接口之间用逗号分隔开
             * 3.一个接口可以继承多个接口, 接口之间也要用逗号分隔
             * 
             * 使用场景
             * 接口是一种能力, 是一种规范, 当我们对现在已经存在的类继承关系进行功能
             * 扩展的时候, 就可以使用接口来完成相应的工作
             * 
             */

            BMWCar b1 = new BMWCar("宝马750");
            b1.Run();
            BMWCar b2 = new BMWCar("宝马740");
            b2.Run();

            Batmobile bat1 = new Batmobile("蝙蝠侠战车1");
            bat1.Run();
            bat1.Fly();

            Console.ReadKey();
        }
    }
}
