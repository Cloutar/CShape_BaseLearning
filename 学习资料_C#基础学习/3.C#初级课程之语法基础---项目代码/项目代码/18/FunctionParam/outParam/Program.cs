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
            //演示：声明一个Number 函数，传入2 个数值，返回最大，最小，和，平均值。
            int a = 10;
            int b = 5;

            int m_max;
            int m_min;
            int m_total;
            double m_avg;

            Number(a, b, out m_max, out m_min, out m_total, out m_avg);
            Console.WriteLine("Max:{0},Min:{1},Total:{2},Avg:{3}", m_max, m_min, m_total, m_avg);

            Console.ReadKey();
        }

        static void Number(int a, int b, out int max, out int min, out int total, out double avg)
        {
            //最大，最小.
            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }

            //和.
            total = a + b;
            //平均值.
            avg = total / 2;
        }

    }
}
