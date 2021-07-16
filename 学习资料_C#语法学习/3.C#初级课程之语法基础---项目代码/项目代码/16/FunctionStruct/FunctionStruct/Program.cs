using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionStruct
{
    class Program
    {
        static void Main(string[] args)     //Main 入口函数.
        {
            //调用函数.
            //Hello();

            //string name1 = "mkCode.net";
            //int age1 = 1;
            //实际参数.
            //Hello_2(name1, age1);

            //Hello_2("MK",123);

            int age = Hello_3("LKK",100);
            Console.WriteLine(age);

            Console.ReadKey();
        }

        //演示：声明一个函数进行自我介绍(无参无返回值).

        //声明一个函数.
        static void Hello()
        {
            //参数.
            Console.WriteLine("大家好,我是Monkey,今年100岁啦!");
        }

        //演示：声明一个函数进行自我介绍(有参无返回值).
        //形式参数."占位符"。
        static void Hello_2(string name, int age)
        {
            Console.WriteLine("大家好,我是{0},今年{1}岁啦!",name,age);
        }

        //演示：声明一个函数进行自我介绍(有参有返回值).
        static int Hello_3(string name, int age)
        {
            Console.WriteLine("大家好,我是{0},今年{1}岁啦!", name, age);
            return age - 50;    //return.

            Console.WriteLine("我是后面的代码.");
        }

    }
}
