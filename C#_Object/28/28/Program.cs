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
             * 1. Object类
             * 在C#语言中, Object类是所有类的父类, 在C#中所有的类(内置的, 我们
             * 自己创建的)都直接或间接继承自Object类
             * Object是类, object是类型.(类与系统关键字的语法颜色区别)
             * 
             * 我们经常会在自己的类中重写ToString方法, 将类中的信息打印输出.
             * 目的是: 辅助调试和开发
             * 
             * 
             * 
             * 2. 装箱与拆箱
             * 装箱: 值类型-->引用类型
             * 拆箱: 引用类型-->值类型
             * 两种类型只有存在继承关系的时候, 才可能出现装箱和拆箱操作
             * 注意
             * 装箱和拆箱本质上是数据存储在栈空间与堆空间之间变更, 因此频繁的装箱或拆
             * 箱会降低代码运行速度, 所以尽量少用装箱和拆箱操作.
             * 
             */


            Person p = new Person("大佬", 100, "佛山");
            p.Hello();

            object b;     //F12调整都相应的类代码

            Object mk;    //类
            object mk_1;   //类型      小学是大学的别称
            int a; 
            float bb;

            Console.WriteLine(p.ToString());


            Console.WriteLine("-----------------------------------------------");

            int aaa = 10;
            Console.WriteLine(aaa);
            object bbb = aaa;        //装箱操作   值类型-->引用类型
            Console.WriteLine(bbb);
            aaa = (int)bbb;         //拆箱操作    引用类型-->值类型
            Console.WriteLine(aaa);




            Console.ReadKey();



        }
    }
}
