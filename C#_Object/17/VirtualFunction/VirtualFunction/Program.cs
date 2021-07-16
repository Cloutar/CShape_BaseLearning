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
             * 简介
             * 当我们父类中的方法已经虚到完全无法确定方法体的时候,
             * 就可以使用另外一种形式来表现, 这种形式叫抽象方法.
             * 
             * 抽象方法
             * 抽象方法的返回值类型前用关键字abstract修饰, 且无方法体
             * 抽象方法必须存在于抽象类中
             * 
             * 抽象类
             * 在定义类的关键字class前面加abstract修饰的类就是抽象类.
             * 子类继承抽象类, 使用override关键字重写父类中所有的抽象方法.
             * 
             * 注意
             * 1. 抽象类中不一定要有抽象方法, 但是抽象方法必须存在于抽象类中
             * 2. 抽象类不能被实例化, 因为抽象类中有抽象方法(无方法体), 如果真能实例
             * 化抽象类的话, 调用这些无方法体的方法是没有任何意义的, 所以无法实例化.
             * 
             * 使用场景
             * 1. 当父类中的方法不知道如何去实现的时候, 可以考虑将父类写成抽象类,将
             * 方法写成抽象方法
             * -
             * 2. 如果父类中的方法有默认实现,并且父类需要被实例化, 这时可以考虑将父
             * 类定义成一个普通类, 用虚方法实现多态
             * -
             * 3. 如果父类中的方法没有默认实现, 父类也不需要被实例化, 则可以将该类定
             * 义为抽象类
             * -
             * 
             */

            ZiLei z = new ZiLei();
            //z.Hello();

            z.F();
            z.Z();

            //不能实例化抽象类为对象
            //FuLei f = new FuLei();
            //f.F();

            Console.ReadKey();

        }
    }
}
