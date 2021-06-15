using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1. if else-if 语句 语法      --- 区间(范围)判断
            int H = 15;

            if (H > 0 && H <= 8) {
                Console.WriteLine("我在睡觉中...");
            }
            else if (H > 8 && H < 17) {
                Console.WriteLine("我在上班中...");
            }
            else if (H > 17 && H <= 20)
            {
                Console.WriteLine("我的自由时间");
            }
            else {
                Console.WriteLine("不知道干啥的时间");
            }
             */

            /*
            //例子: 游戏评级
            int time = 20;

            if (time > 0 && time <= 20) {
                Console.WriteLine("S级");
            }
            else if (time > 20 && time <= 30) {
                Console.WriteLine("A级");
            }
            else if (time > 30 && time <= 40) {   //不包含30秒, 包含40秒
                Console.WriteLine("B级");
            }
            else if (time > 40) {
                Console.WriteLine("C级");
            }
             */


            /*
            //2. switch-case 语句 语法.    --- 定值判断
            int week = 1;

            //switch (week) { 
            //表达式的情况: 
            switch (week + 2) {
                case 1:
                    Console.WriteLine("今天周一");
                    break;
                case 2:
                    Console.WriteLine("今天周二");
                    break;
                case 3:
                    Console.WriteLine("今天周三");
                    break;
                case 4:
                    Console.WriteLine("今天周四");
                    break;
                case 5:
                    Console.WriteLine("今天周五");
                    break;
                case 6:
                    Console.WriteLine("今天周六");
                    break;
                default:
                    Console.WriteLine("其他日子全休息");
                    break;
            }
             */

            //例子: 四则运算
            double num_a = 10;
            double num_b = 5;
            string option = "-";

            switch (option) { 
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", num_a, num_b, num_a + num_b);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", num_a, num_b, num_a - num_b);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", num_a, num_b, num_a * num_b);
                    break;
                case "/":
                    Console.WriteLine("{0} / {1} = {2}", num_a, num_b, num_a / num_b);
                    break;
            }


            Console.ReadKey();
        }
    }
}
