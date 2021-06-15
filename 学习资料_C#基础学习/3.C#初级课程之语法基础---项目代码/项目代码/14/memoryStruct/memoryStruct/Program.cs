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
            //1.演示：int 类型变量间传值.
            int a = 10;
            int b = a;  //变量间的传值. b = 10; 值传递.

            b = 20;

            Console.WriteLine("a的值是{0}，b的值是{1}", a, b);  //a:10   b:20
            */


            //演示：int 数组类型变量间传值.
            int[] intA = new int[] { 111, 222, 333, 444 };
            int[] intB = intA; //变量间的传值. 引用.

            intB[0] = 100;
            intB[3] = 999;

            foreach(int i in intA)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------");

            foreach(int j in intB)
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();
        }
    }
}
