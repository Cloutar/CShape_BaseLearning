using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // = 赋值.
            int age = 15;

            // + 相连.
            string name = "Monkey";
            Console.WriteLine(name + age);
            // + 相加.
            Console.WriteLine(5 + 5);
            
            */


            /*
            // + - * /
            Console.WriteLine(5 + 5);   //10.
            Console.WriteLine(15 - 5);  //10.
            Console.WriteLine(5 * 5);   //25.
            Console.WriteLine(10 / 3);  //3.
            Console.WriteLine(10.0f / 3);   //3.3333
            
            */

            /*
            //计算三科总成绩和平均成绩.
            float chinese = 90;
            float english = 80.5f;
            float math = 50;

            float total = chinese + english + math;
            float avg = total / 3;

            Console.WriteLine("总成绩:" + total + "平均成绩:" + avg);
            
            */

            /*
            // % 取余.
            Console.WriteLine(10 % 3);  //1.
            
            */

            /*
            //计算365 是由几个100,几个10,几个1 组成.
            int day = 985;
            int bai = day / 100;
            int shi = (day % 100) / 10;
            int ge = day % 10;

            Console.WriteLine("百位是：" + bai + "十位是：" + shi + "个位是：" + ge);
            
            */

            /*
            // 前++ 后++
            int a = 10;
            int b = 10;
            a++;
            ++b;
            Console.WriteLine("a:" + a);    //11.
            Console.WriteLine("b:" + b);    //11.

            int c = 10;
            int d = 10;

            int f = ++c;
            int g = d++;

            Console.WriteLine("f:" + f);    //11.
            Console.WriteLine("g:" + g);    //10.
            Console.WriteLine("d:" + d);    //11.
            
             */

            //+= -= *= /= %= 复合赋值运算符.
            int num_1 = 10;
            num_1 += 5;     // num_1 = num_1 + 5;
            Console.WriteLine(num_1);

            int num_2 = 20;
            num_2 -= 8;     // num_2 = num_2 - 8;
            Console.WriteLine(num_2);

            int num_3 = 30;
            num_3 *= 2;     // num_3 = num_3 * 2;
            Console.WriteLine(num_3);

            Console.ReadKey();

        }
    }
}
