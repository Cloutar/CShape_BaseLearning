using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFun
{
    class Program
    {
        static void Main(string[] args)
        {
            //例：定义一个Add 方法，实现整数,小数相加操作.
            /*
            int a = Add1(10, 5);
            Console.WriteLine(a);

            Console.WriteLine(Add2(1.234, 4.5678));
            Console.WriteLine(Add3(3.1415926, 10));
            */
            Console.WriteLine(Add(1.3333, 3.54654564));
            Console.WriteLine(Add(3,6));
            Console.WriteLine(Add(4.23423,10));

            Console.ReadKey();
        }
        /*
        /// <summary>
        /// 两个int相加.
        /// </summary>
        static int Add1(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// 两个double相加.
        /// </summary>
        static double Add2(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// double 和 int 相加.
        /// </summary>
        static double Add3(double a, int b)
        {
            return a + b;
        }*/

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Add(double a, int b)
        {
            return a + b;
        }
    }
}
