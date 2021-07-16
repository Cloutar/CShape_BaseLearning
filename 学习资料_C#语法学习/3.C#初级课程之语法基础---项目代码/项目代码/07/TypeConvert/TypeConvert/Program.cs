using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.隐式类型转换[自动类型转换]. 数值.
            int num_1 = 10;
            float num_2;
            double num_3;

            //隐式类型转换.
            num_2 = num_1;
            num_3 = num_1;
            */

            /*
            //2.显式类型转换[强制类型转换].
            float num_1 = 3.5f;
            double num_2 = 3.1415926;

            int num_3 = (int)num_1;
            int num_4 = (int)num_2;

            Console.WriteLine("{0}--{1}--{2}--{3}",num_1,num_2,num_3,num_4);
            */

            /*
            //3.表达式中的类型转换.
            int a = 10;
            float b = 5.6f;
            float c = a + b;
            */

            /*
            //4.Convert 类型转换.
            string num_1 = "3.15";
            string num_2 = "192";
            double num_3 = Convert.ToDouble(num_1);
            int num_4 = Convert.ToInt32(num_2);
            Console.WriteLine(num_1 + num_2);
            Console.WriteLine(num_3 + num_4);
            */

            /*
            //加法计算器.
            int a;
            int b;
            Console.WriteLine("请输入加数:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入被加数:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            */

            //常量.
            //const 数据类型 常量名= 值;
            int num_1 = 10;
            const int num_2 = 10;
            const string SERVER_IP = "153.56.147.20";

            num_1 = 20;
            //num_2 = 30;  常量不能二次赋值.

            Console.WriteLine(num_1);
            Console.ReadKey();
        }
    }
}
