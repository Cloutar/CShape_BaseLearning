using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. for语句 语法.

            /*
            //int i = 1 : 初始表达式.
            //i <= 10 : 条件表达式
            //i++ : 增量表达式
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }
             */

            /*
            int total = 0;
            for (int i = 1; i <= 100; i++) {
                total += i;
            }
            Console.WriteLine(total);
             */

            /*
            //嵌套for
            for (int i = 1; i <= 30; i++) {
                Console.WriteLine("今天是5月的第{0}天", i);
                for (int j = 1; j <= 3; j++) {
                    Console.WriteLine("今天的第{0}顿饭", j);
                }
            }
             */


            //九九乘法表
            string str;

            for (int i = 1; i <= 9; i++) {

                str = "";
                for (int j = 1; j <= i; j++) {
                    str += j + "x" + i + "=" + j * i + " ";
                    if (j * i < 10) {
                        str += " ";
                    }
                }
                Console.WriteLine(str);

            }


            Console.ReadKey();
        }
    }
}
