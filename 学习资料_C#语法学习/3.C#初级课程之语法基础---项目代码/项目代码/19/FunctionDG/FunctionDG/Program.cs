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
            //练习：用递归实现1+2+3+...+N 之和。
            //int a = Number(5);
            int a = AddNum(5);


            Console.WriteLine("a:" + a);

            Console.ReadKey();
        }

        /// <summary>
        /// for循环实现.
        /// </summary>
        static int Number(int n)
        {
            int total = 0;
            for(int i = 0; i <= n; i++)
            {
                total += i;
            }
            return total;
        }

        /// <summary>
        /// 递归实现.
        /// </summary>
        ///                   5/4/3/2/1.
        static int AddNum(int n)
        {
            //如果传递过来的是1,直接返回最终计算结果：1.
            if(n == 1) return 1;
            //     5 + AddNum(4);   :10 10+5 return:15
            //     4 + AddNum(3);   :6  4+6  return 10
            //     3 + AddNum(2);   :3  3+3  return:6
            //     2 + AddNum(1);   :1       return:3
            return n + AddNum(n - 1);
        }
    }
}
