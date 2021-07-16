using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.关系运算符
            //> <
            Console.WriteLine(5 > 3);
            Console.WriteLine(5 < 3);
            Console.WriteLine();
            //>= <=
            Console.WriteLine(10 >= 5);
            Console.WriteLine(10 >= 10);
            Console.WriteLine(10 >= 100);
            Console.WriteLine(10 <= 12);
            Console.WriteLine(10 <= 10);
            Console.WriteLine();
            //== !=
            Console.WriteLine(10 == 5);
            Console.WriteLine(10 == 10);
            Console.WriteLine(10 != 5);
            Console.WriteLine();
            */


            /*
            //2. 逻辑运算符
            //逻辑与 &&
            Console.WriteLine(10 > 5 && 10 < 20);
            Console.WriteLine(3 > 5 && 10 > 7);
            Console.WriteLine();
            //逻辑或 ||
            Console.WriteLine(5 > 3 || 3 > 10);
            Console.WriteLine(7 > 4 || 10 > 5);
            Console.WriteLine(5 < 2 || 9 < 1);
            Console.WriteLine();
            //逻辑非 !
            Console.WriteLine(!(5 > 3));
            Console.WriteLine(!(5 < 4));
            */ 


            //3.占位符
            string name = "Monkey";
            int age = 100;
            string gender = "男";

            Console.WriteLine("我的名字是: " + name + ", 我今年" + age + "岁了, 我的性别是" + gender);
            //Console.WriteLine("我的名字是{1}, 我今年{0}岁, 我的性别是{2}", name, age, gender);
            Console.WriteLine("我的名字是{0}, 我今年{1}岁, 我的性别是{2}", name, age, gender);
         
            Console.ReadKey();
        }
    }
}
