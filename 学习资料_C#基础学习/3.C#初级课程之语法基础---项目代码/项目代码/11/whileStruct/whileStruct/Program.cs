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
            int i = 1;      //初始表达式.
            //   11 <= 10
            while(i <= 10)  //条件表达式.
            {
                Console.WriteLine(i);//1 2 3 4 5 6 7 8 9 10
                i++;//11    //增量表达式.
            }

            Console.WriteLine("----------------------------");

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }
            */
            /*
            //计算1+2+3...+100 的和.
            int total = 0;   //和.
            int i = 1;       //初始表达式.
            while(i <= 100)  //条件.
            {
                total += i;
                i++;         //增量.
            }

            Console.WriteLine(total);*/

            //2. do-while 语句 语法.

            /*
            int i = 1;  //初始.

            do
            {
                Console.WriteLine(i);
                i++;    //增量.
            }while(i <= 100);   //条件.
            */
            /*
            bool b = false;

            do
            {
                Console.WriteLine("我是Monkey");
            }while(b == true);
            */
            
            
            /*
            for (int i = 0; i <= 10; i++)
            {
                if(i >= 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            */

            for (int i = 0; i <= 10; i++)
            {
                if(i % 2 == 0)  //0 2 4 6 8 10 
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("后面的.");
            Console.ReadKey();
        }
    }
}
