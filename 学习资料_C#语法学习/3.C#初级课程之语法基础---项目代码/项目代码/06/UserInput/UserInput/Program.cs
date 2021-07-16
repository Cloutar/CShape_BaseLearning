using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.用户输入.
            //string name = "Monkey";
            string name;
            
            //ReadLine : 读 行 读取一行用户的输入.
            name = Console.ReadLine();
            Console.WriteLine("我的名字是:{0}",name);
            Console.ReadKey();
            */

            /*
            //提示用户依次输入姓名,性别,年龄,然后最后打印输出用户输入的信息。
            string name;
            string gender;
            string age;

            Console.WriteLine("请输入您的姓名:");
            name = Console.ReadLine();
            Console.WriteLine("请输入您的性别:");
            gender = Console.ReadLine();
            Console.WriteLine("请输入您的年龄:");
            age = Console.ReadLine();

            Console.WriteLine("我的名字{0},性别{1},年龄{2}",name,gender,age);
            */
            
            //2.转义符.
            //\n：表示换号
            Console.WriteLine("我的名字叫Monkey,\n性别为男");

            //\"：表示一个英文半角的双引号
            Console.WriteLine("我的名字叫\"Monkey\"");

            //\t：表示一个tab 键的大空格
            Console.WriteLine("我的名字叫\tMonkey");

            //\b：表示一个BackSpace 退格键,会把前面的一个字符删掉
            Console.WriteLine("我的名字叫\bMonkey");

            //\\：表示一个\
            Console.WriteLine("我的名字叫\\Monkey");

            /*@:用在字符串的前面,有两种用途。
                ①取消“\”在字符串中的转义作用，使其单纯的就表示一个斜线[多用于路径]
                ②将字符串按照原格式输出
             */
            string path = @"D:\C#_CODE\06";
            Console.WriteLine(path);

            Console.WriteLine(@"我的名         字叫  M  o  n k  e   y");

            Console.ReadKey();
        }
    }
}
