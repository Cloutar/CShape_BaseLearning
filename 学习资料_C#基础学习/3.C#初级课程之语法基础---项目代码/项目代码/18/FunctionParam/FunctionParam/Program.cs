using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParam
{
    class Program
    {
        static void Main(string[] args)
        {
            //演示：声明一个Add（int num）函数,将一个值自身加10。

            int num = 5;
            Add(num);
            Console.WriteLine("num:" + num);    //5.

            Console.ReadKey();
        }

        static void Add(int num)
        {
            Console.WriteLine("num_start:" + num);  //5.
            num += 10;
            Console.WriteLine("num_end:" + num);    //15.
        }
    }
}
