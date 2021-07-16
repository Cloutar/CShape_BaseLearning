using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. 函数的声明:
             * 
             * static 返回值类型 函数名([参数列表]) {
             *  函数代码体;
             * }
             * 
             * 
             * 2. 函数的调用:
             * 
             * 函数名([实际参数]);
             * 
             * 
             * 3. 函数的参数与返回值
             *
             * 形参与实参
             * 形参: 形式参数 在定义函数的时候, 在参数列表中定义的参数.
             * 实参: 实际参数, 在调用函数的时候, 传递给函数的具体参数.
             * 
             * 
             * 返回值
             * 
             * return
             * 1. 在函数中返回要返回的值;
             * 2. 立即结束函数
             * 
             * 
             */

            Hello();

            Hello_2("Cloutar", 25);   //实际参数

            Console.WriteLine( Hello_3("Feng", 100) );


            Console.ReadKey();

        }


        //声明一个无参无返回值函数
        static void Hello() {
            Console.WriteLine("大家好");
        }


        //声明一个有参无返回值的函数
        static void Hello_2(string name, int age) {   //形式参数
            Console.WriteLine("大家好, 我是{0}, 今年{1}岁啦!", name, age);
        }


        //声明一个有参有返回值得函数
        static int Hello_3(string name, int age) {
            Console.WriteLine("大家好, 我是{0}, 今年{1}岁啦!", name, age);
            return 1;
            Console.WriteLine("我是后面的代码");
        }



    }
}
