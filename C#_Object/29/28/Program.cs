using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1. 预编译指令
             * 预编译指令也叫预处理指令, 在程序正式编译之前执行.
             * 这些指令不会转化为可执行代码中的命令, 但是会影响编译过程的各个方面
             * 
             * (1). 区域指令 (是预编译指令的其中一种)
             * #region Info
             * .....
             * #endregion
             * 作用:整理代码
             * 
             * 
             * 
             * 2. 对象初始化器
             * 在一个类中, 我们通常使用构造方法来对属性进行赋值, 完成对象的初始化.
             * 但是当一个类中的属性很多很多的时候, 不可能为各种情况都定义构造方法, 这
             * 个时候可以使用"对象初始化器"来完成属性的赋值.
             * 语法格式:
             * 类名 对象名 = new 类名(){属性名 = 值, 属性名 = 值};
             * 
             * 
             */


            //Person p = new Person("大佬", 100, "佛山");
            //p.Hello();

            //object b;     //F12调整都相应的类代码

            //Object mk;    //类
            //object mk_1;   //类型      小学是大学的别称
            //int a; 
            //float bb;

            //Console.WriteLine(p.ToString());


            Console.WriteLine("-----------------------------------------------");

            int aaa = 10;
            Console.WriteLine(aaa);
            object bbb = aaa;        //装箱操作   值类型-->引用类型
            Console.WriteLine(bbb);
            aaa = (int)bbb;         //拆箱操作    引用类型-->值类型
            Console.WriteLine(aaa);


            Person p1 = new Person() { Name = "abc", Age = 100 };
            Person p2 = new Person() { Name = "baidu" };
            Person p3 = new Person() { Age = 111, Address = "山东" };


            Console.ReadKey();



        }
    }
}
