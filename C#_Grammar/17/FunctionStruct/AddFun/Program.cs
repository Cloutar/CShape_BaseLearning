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

        /*
         * 函数重载
         * 
         * 函数的名称相同, 但是参数列表不同
         * 调用该函数时候, 会根据不同的参数, 自动选择合适的函数重载形式.
         * 
         * 
         * 参数不同的情况
         * 1. 如果参数的个数相同, 那么参数的类型就不能相同;
         * 2. 如果参数的类型相同, 那么参数的个数就不能相同.
         * 另: 函数的返回值和重载没有关系
         * 
         */

            //例: 定义一个Add 方法, 实现整数, 小数相加操作
            int a  = Add1(10, 5);

            Console.WriteLine(a);
            Console.WriteLine(Add2(1.235, 4.666));
            Console.WriteLine(Add3(1.235, 4));


            Console.WriteLine("重载: ");

            Console.WriteLine(Add(1, 3));
            Console.WriteLine(Add(1.565, 3.48));
            Console.WriteLine(Add(1.56, 3));

            Console.ReadKey();


        }

        /// <summary>
        /// 两个int相加
        /// </summary>
        /// <param name="a">int数据</param>
        /// <param name="b">int数据</param>
        /// <returns>两个int数据的和</returns>
        static int Add1(int a, int b) {
            return a + b;
        }

        /// <summary>
        /// 两个double相加
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Add2(double a, double b) {
            return a + b;
        }

        /// <summary>
        /// double和int相加
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Add3(double a, int b) {
            return a + b;
        }


        //重载
        static int Add(int a, int b) {
            return a + b;
        }

        static double Add(double a, double b) {
            return a + b;
        }

        static double Add(double a, int b) {
            return a + b;
        }


    }
}
