using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1. while语句 语法.
            int i = 1;                   //初始表达式
            while (i <= 10) {            //条件表达式
                Console.WriteLine(i);
                i++;                     //增量表达式
            }
             */

            /*
            //计算1+2+3...+100的和
            int total = 0;   //和
            int i = 1;
            while (i <= 100) {
                total += i;
                i++;
            }
            Console.WriteLine(total);
             */


            //2. do-while语句 语法.
            /*
            int i = 1;                    //初始
            do {
                Console.WriteLine(i);
                i++;                     //增量
            }while(i <= 100);            //条件
             */
            bool b = false;

            /*
            do
            {
                Console.WriteLine("我会执行");      //一定会执行一次
            } while (b == true);
             */


            /*
            //break
            for (int i = 0; i <= 10; i++) {
                if (i >= 5) {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("我执行了");
             */


            for (int i = 0; i <= 10; i++ ) {
                if (i % 2 == 0) {
                    continue;
                }
                Console.WriteLine(i);
            }


                Console.ReadKey();
        }
    }
}
