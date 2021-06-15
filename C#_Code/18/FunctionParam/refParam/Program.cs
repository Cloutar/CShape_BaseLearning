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
            /*
             * ref参数
             * 
             * 1.作用
             * 将一个变量传入一个函数中进行"处理", "处理"完成后, 再将"处理"后的值带出函数.
             * 
             * 2.要求
             * 函数外必须为变量赋值, 而函数内可以不赋值
             * 
             * 3.语法
             * 形参和实参前面都要加ref关键字
             * 加了ref, 传递的就是一个地址, 也就是"引用传递"
             */

            int num = 5;
            Add(ref num);

            Console.WriteLine("num: " + num);

            Console.ReadKey();
        }

        static void Add(ref int num) {
            num += 10;
            Console.WriteLine(num);
        }

    }
}
