using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 设计模式
             * "代码的通关攻略"
             * 
             * 
             * 单例设计模式
             * 设计一个类的时候, 需要保证整个程序在运行期间只存在一个实例对象.
             * 解决这个问题, 我们就需要用到"单例(模式)"
             * 注意:
             * 单例设计模式是用于非静态类中的, 在静态类中写单例无意义
             * 
             * 
             * 
             */

            Web w1 = new Web("百度", "www.baidu.com");
            Web w2 = new Web("腾讯", "www.qq.com");
            w1.Show();
            w2.Show();

            //Monkey m1 = new Monkey();
            Monkey m1 = Monkey.Instance();
            Monkey m2 = Monkey.Instance();

            Console.WriteLine(w1 == w2);
            Console.WriteLine(m1 == m2);

            Console.ReadKey();

        }
    }
}
