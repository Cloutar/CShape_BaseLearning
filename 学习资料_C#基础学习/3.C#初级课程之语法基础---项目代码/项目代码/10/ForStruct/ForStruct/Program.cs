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
            //int i = 1 : 初始表达式.   只执行一次.
            //i <= 10 : 条件表达式.
            //i++ : 增量表达式.

            /*
                  //i = 1           //11
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i); //1 2 3 4 5 6 7 8 9 10 
            }
            */

            //计算1+2+3...+100 的和。
            /*
            int total = 0;  //和.

            for (int i = 1; i <= 100; i++)
            {
                total += i; //total = total + i; 100.
            }

            Console.WriteLine(total);   //5050.
            */

            //比如：正常情况下，人每活一天，就要吃三顿饭.

            /*
            //       i = 1            2
            for (int i = 1; i <= 30; i++)
            {
                //1 2
                Console.WriteLine("今天是5月的第{0}天", i);
                
                //       j = 1          4
                for (int j = 1; j <= 3; j++)
                {
                    // 1 2  3
                    Console.WriteLine("今天的第{0}顿饭", j);
                }
            }

             */

            //九九乘法表(学习分析问题).


            //       i = 1          2
            for (int i = 1; i <= 9; i++)    //横. 行.
            {
                //      j = 1  3 <= 2  3
                for(int j = 1; j <= i; j++)  //竖. 列.
                {
                    //1*1=1 1*2=2
                    Console.Write("{0}*{1}={2}\t", j, i, i * j);
                }
                Console.WriteLine();    //换行.
            }

            Console.ReadKey();
        }
    }
}
