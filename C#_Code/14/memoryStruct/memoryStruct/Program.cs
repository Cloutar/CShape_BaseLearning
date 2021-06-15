using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoryStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.值类型
             * int, float, double, bool, char
             * 内存: 值类型的值存储在内存的栈中
             */

            /*
            //演示: int类型变量间传值
            int a = 10;
            int b = a;  //变量间的传值
            b = 20;
            Console.WriteLine("a的值是{0}, b的值是{1}", a, b);   //a:10   b:20
             */

            /*
             * 注意: 这个时候单独修改b的值, a的值不会发生改变, 这种传递叫做 值传递.
             * 这个时候变量之间的传递就是拷贝一个具体的值给对方.
             */


//--------------------------------------------------------------------

            /*
             * 2. 引用类型
             * 数组, 字符串
             * 内存: 引用类型的值存储在内存的堆中
             */

            //演示: int数组类型变量间传值
            int[] intA = new int[] { 111, 222, 333, 444 };
            int[] intB = intA;

            intB[0] = 100;
            intA[1] = 200;

            foreach (int i in intA) {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------------------");

            foreach (int j in intB)
            {
                Console.WriteLine(j);
            }

            /*
             * 注意: 这个时候单独修改intB中元素的值, intA的值是会发生改变, 这种传递叫做 引用传递
             * 这个时候变量之间的传递就是拷贝一个地址给对方.
             */

            Console.ReadKey();



            /*
             * 数组的内存结构
             * 数组在内存中是一块连续的存储空间存储的.
             * 最低的地址对应第一个元素, 最高的地址对应最后一个元素.
             */




        }
    }
}
