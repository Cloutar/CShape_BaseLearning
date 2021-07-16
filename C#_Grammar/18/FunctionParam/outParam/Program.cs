using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outParam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * out 参数
             * 
             * 1.作用
             * 一个函数中如果返回多个不同类型的值, 就需要用到out参数.
             * 
             * 2. 要求
             * 函数外可以不为变量赋值, 而函数内必须为其赋值.
             * 
             * 3.语法
             * 形参和实参前面都要加out关键字
             */

            int a = 10;
            int b = 5;
            int m_max;
            int m_min;
            int m_total;
            double m_avg;
            Number(a, b, out m_max, out m_min, out m_total, out m_avg);

            Console.WriteLine("max: {0}, min: {1}, total: {2}, avg: {3}", m_max, m_min, m_total, m_avg);
            Console.ReadKey();

        }

        static void Number(int a, int b, out int max, out int min, out int total, out double avg) {
            if (a > b) {
                max = a;
                min = b;
            }
            else {
                max = b;
                min = a;
            }
            total = a + b;
            avg = total / 2;
        }
    }
}
