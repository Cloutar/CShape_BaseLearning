using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var
{
    class Program
    {
        static void Main(string[] args)
        {
            //变量的语法

            //数据类型 变量名;  1.声明变量
            int score;

            //变量名 = 值; =:赋值.   2.赋值变量
            score = 17;

            //数据类型 变量名 = 值
            int lifeValue = 3;

            //3.使用变量
            Console.WriteLine(score);
            Console.WriteLine(lifeValue);
            Console.ReadKey();
        }
    }
}
