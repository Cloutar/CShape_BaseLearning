using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDG
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 递归
             * 递归算法是一种直接或者间接调用自身函数或者方法的算法
             * [自己调用自己]
             * 
             * 递归原则
             * 1. 函数会一直调用自己, 直到满足特定条件(递归要有一个结束条件);
             * 2. 递归调用时会传递些参数, 每次调用都会将一个新的参数传递给自己;
             */



            //递归 1+2+3...+N
            Console.WriteLine(Number(100));
            Console.WriteLine(Number(50));


            Console.WriteLine(AddNum(100));
            Console.WriteLine(AddNum(50));
            Console.ReadKey();


        }

        //me
        //递归四套路: static 全局 引用 常规
        static int i = 1;
        static int total = 0;
        static int Number(int n) {
            if (i > n)
            {
                int sum = total;
                i = 1;
                total = 0;
                return sum;
            }
            else {
                total += i;
                i++;
                return Number(n);
            }
        }


        static int AddNum(int n) {
            //
            if (n == 1) return 1;
            //
            return n + AddNum(n-1);
        }

    }
}
