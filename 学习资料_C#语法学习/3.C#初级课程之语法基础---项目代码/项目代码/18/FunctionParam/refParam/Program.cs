using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refParam
{
    class Program
    {
        static void Main(string[] args)
        {
            //演示：声明一个Add（int num）函数,将一个值自身加10。
            int num = 5;
            Add(ref num);

            Console.WriteLine("num:" + num);    //15.
            Console.ReadKey();
        }

        static void Add(ref int num)
        {
            num += 10;
            Console.WriteLine(num); //15.
        }
    }
}
