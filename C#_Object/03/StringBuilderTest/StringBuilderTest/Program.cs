using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringBuilderTest
{
    class Program
    {
        static void Main(string[] args) {

            /*
             * 字符串的缺点
             * 当需要对一个字符串变量重复赋值时, 在内存中会产生大量的辣鸡数据信息.
             * 当重复赋值的频率很高时, 执行的效率就会降低.
             */

            /*
             * 使用Stopwatch 秒表计时器来记录程序运行的时间
             */

            Stopwatch sw = new Stopwatch();
            sw.Start();

            //1. 创建StringBuilder 类型的变量
            StringBuilder sb = new StringBuilder();

            //2. 往sb 中追加数据
            sb.Append("Monkey");
            sb.Append(123456);
            sb.Append(true);

            for (int i = 0; i <= 100; i++) {
                sb.Append(i);
            }

            //将sb转成字符串形式
            Console.WriteLine(sb.ToString());

            //3. 清空sb中的数据
            sb.Clear();

            Console.WriteLine("清空后: " + sb.ToString());

            sw.Stop();
            Console.WriteLine(sw.Elapsed);


            Console.ReadKey();

        }
    }
}
