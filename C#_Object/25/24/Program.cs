using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * static关键字
             * static关键字, 用于修饰类, 字段, 属性, 方法, 构造方法等;
             * 被static修饰的类称之为"静态类";
             * 被static修饰的成员称之为"静态成员", 被修饰过的成员分别称为:
             * 静态字段, 静态属性, 静态方法, 静态构造方法
             * 
             * 
             * 静态字段
             * 被static关键字修饰的字段, 叫做"静态字段"
             * 静态字段不属于任何对象, 只属于类, 必须要用 类名.静态字段名 进行访问
             * 反过来通过 对象名.静态字段名 的方式是访问不到静态字段的
             * 注意
             * 静态字段是可以重新赋值的, 类名.静态字段名 = 新的值;
             * 静态字段存储的数据在内存中只有一份;
             * 示例(对象)字段在内存中会有N份, 有多少对象就会有多少示例字段;
             * 
             * 
             * 静态属性
             * 被static关键字修饰的属性, 叫做"静态属性".
             * 静态属性用于对静态字段进行封装, 并保证静态字段值的合法性
             * 静态属性使用 类名.静态属性名 进行访问
             * 注意
             * 静态属性不能用于封装非静态字段, 因为静态的类成员是先于非静态的类成员
             * 存在的. 在还没有对象之前, 静态类成员就已经存在了
             * 
             * 
             * 静态普通方法
             * 被static修饰的方法, 叫做静态方法
             * 直接使用 类名.静态方法名 进行访问
             * 注意
             * 控制台程序的Program入口类中的Main函数就是一个静态方法;
             * 在静态方法中不能调用非静态方法
             * 
             * 
             * 静态构造方法
             * 静态构造方法的作用是用于初始化静态成员.
             * 一个类只能有一个静态构造方法, 该静态构造方法没有任何访问修饰符, 也没有参数.
             * 可以定义在静态类中, 也可以定义在非静态类中.
             * 注意
             * 静态构造方法会在程序创建第一个实例, 或者引用任何静态成员之前, 完成类中
             * 静态成员的初始化
             * 
             * 
             * 静态类
             * 当类中的成员全部是静态成员的时候, 可以把这个类声明为静态类.
             * 声明静态类需要在class关键字前加静态关键字static
             * 注意
             * 静态类中不能存在非静态(实例)成员;
             * 静态类不能实例化对象.
             * 
             * 
             * 总结
             * 先有静态成员, 后有实例成员
             * 后出现的, 可以调用先出现的
             * 而先出现的则不能调用后出现的
             * 
             * 
             */

            Person p1 = new Person();
            p1.name = "lkk";
            //p1.address;    无法访问
            Person.address = "地址";
            Console.WriteLine(p1.name + "--" + Person.address + "--" + p1.Name + "--" + Person.Address);
            p1.P1();
            Person.P2();

            Person p2 = new Person();
            p2.name = "mkcode";
            Console.WriteLine(p2.name + "--" + Person.address + "--" + p1.Name + "--" + Person.Address);

            //静态方法直接访问~~
            //Monkey m1 = new Monkey();
            Console.WriteLine(Monkey.Name);
            Monkey.Hello();


            Console.ReadKey();
        }
    }
}
