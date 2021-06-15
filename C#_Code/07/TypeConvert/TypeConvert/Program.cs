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
            //1. 隐式类型转换(自动类型转换)
            /*
             * 条件1: 两种类型兼容
             * 条件2: 原类型要小于目标类型(小的转大的)
             * 例: int->double int->float
             */
            //int num_1 = 10;
            //float num_2;
            //double num_3;

            //隐式类型转换
            //num_2 = num_1;
            //num_3 = num_1;


            //2.显式类型转换(强制类型转换)
            /*
             * 条件1: 两种类型兼容
             * 条件2: 原类型大于目标类型(大的转小的)
             * 例: double->int float->int
             */
            //float num_1 = 3.5f;
            //double num_2 = 3.1415926;

            //int num_3 = (int)num_1;
            //int num_4 = (int)num_2;

            //Console.WriteLine("{0}---{1}---{2}---{3}", num_1, num_2, num_3, num_4);


            //3.表达式中的类型转换
            /*
             * 两个int类型, 加减乘除取余之后, 依然是整数类型
             * 如果一个操作书为double类型, 则整个表达式可提升为double类型
             */
            //int a = 10;
            //float b = 10.6f;
            //float c = a + b;


            //4.Convert类型转换
            /*
             * 两个变量的类型如果相互兼容, 可以使用自动类型转换或者强制类型转换.
             * 如果两个变量的类型不兼容, 比如string和int, string和double.
             * 这个时候我们可以用Convert进行转换.
             */
            //string num_1 = "3.15";
            //string num_2 = "198";
            //double num_3 = Convert.ToDouble(num_1);
            //int num_4 = Convert.ToInt32(num_2);
            //Console.WriteLine(num_1 + num_2);
            //Console.WriteLine(num_3 + num_4);
 

            //加法计算器
            //int a;
            //int b;
            //Console.WriteLine("请输入加数: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入被加数");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0}+{1}={2}", a, b, a + b);


            //5.常量
            //const 数据类型 常量名 = 值
            //常量名的命名一般是全大写, 单词与单词之间用下划线分割
            const int NUM_ONE = 10;

            //错误: 常量不能二次赋值
            //NUM_ONE = 20;

            Console.ReadKey();
        }
    }
}
